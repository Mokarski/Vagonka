using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using ProtoBuf;

namespace SDK.NetworksServices.ProtoBufRemote
{
    /// <summary>
    /// An RpcChannel that communicates over a Stream. Does not work with any Stream, it must be a bidrectional channel
    /// like NetworkStream.
    /// </summary>
    public class StreamRpcChannel : RpcChannel
    {
        private readonly Queue<RpcMessage> mQueuedMessages = new Queue<RpcMessage>();
        private readonly Mutex mQueueMutex = new Mutex();
        private readonly AutoResetEvent mQueueEvent = new AutoResetEvent(false);
        private readonly ManualResetEvent mCloseEvent = new ManualResetEvent(false);
        private readonly Thread mReadThread;
        private readonly Thread mWriteThread;
        private readonly Stream mReadStream;
        private readonly Stream mWriteStream;
        private long mTotalBytesRead;
        private long mTotalBytesWritten;

        public StreamRpcChannel(RpcController controller, Stream readStream, Stream writeStream)
            : base(controller)
        {
            mReadStream = readStream;
            mWriteStream = writeStream;
            mReadThread = new Thread(ReadRun);
            mWriteThread = new Thread(WriteRun);
        }

        public override void Stop()
        {
            CloseAndJoin();
        }

        public override long TotalBytesRead { get { return Interlocked.Read(ref mTotalBytesRead); } }        
        public override long TotalBytesWritten { get { return Interlocked.Read(ref mTotalBytesWritten); } }

        public override void Start()
        {
            mReadThread.Start();
            mWriteThread.Start();
        }

        /// <summary>
        /// Closes all the streams and requests that the channel shutdown, then joins the channel threads until they
        /// have terminated.
        /// </summary>
        public void CloseAndJoin(bool isCloseWriteStream = true)
        {
            //readStream must be closed, it's the only way we can terminate the readThread cleanly. Even async reads
            //don't support cancellation
            mReadStream.Close();
            if (isCloseWriteStream)
                mWriteStream.Close();
            mCloseEvent.Set();
            mReadThread.Join();
            mWriteThread.Join();
        }

        internal override void Send(RpcMessage message)
        {
            mQueueMutex.WaitOne();

            mQueuedMessages.Enqueue(message);
            mQueueEvent.Set();

            mQueueMutex.ReleaseMutex();
        }

        private void ReadRun()
        {
            var buffer = new byte[1024];
            var bytesRemaining = sizeof(int);
            var bufferPos = 0;
            var isReadingSize = true;

            while (true)
            {
                int bytesRead;
                try
                {
                    bytesRead = mReadStream.Read(buffer, bufferPos, bytesRemaining);
                    Interlocked.Add(ref mTotalBytesRead, bytesRead);
                    if (bytesRead == 0)
                        break;
                }
                catch (InvalidOperationException)
                {
                    break;
                }
                catch (IOException)
                {
                    break;
                }

                bufferPos += bytesRead;
                bytesRemaining -= bytesRead;

                if (bytesRemaining == 0)
                {
                    if (isReadingSize)
                    {
                        bytesRemaining = BitConverter.ToInt32(buffer, 0);
                        bufferPos = 0;
                        isReadingSize = false;

                        if (bytesRemaining > buffer.Length)
                            buffer = new byte[bytesRemaining];
                    }
                    else
                    {
                        var memStream = new MemoryStream(buffer, 0, bufferPos);
                        var message = Serializer.Deserialize<RpcMessage>(memStream);
                        Receive(message);

                        isReadingSize = true;
                        bytesRemaining = sizeof(int);
                        bufferPos = 0;
                    }
                }
            }
        }

        private void WriteRun()
        {
            var waitHandles = new WaitHandle[] { mQueueEvent, mCloseEvent };
            bool isTerminated = false;
            var memStream = new MemoryStream();
            while (!isTerminated)
            {
                int waitIndex = WaitHandle.WaitAny(waitHandles);

                mQueueMutex.WaitOne();
                while (mQueuedMessages.Count > 0)
                {
                    RpcMessage message = mQueuedMessages.Dequeue();
                    try
                    {
                        memStream.Position = 0;
                        Serializer.SerializeWithLengthPrefix(memStream, message, PrefixStyle.Fixed32);
                        mWriteStream.Write(memStream.GetBuffer(), 0, (int)memStream.Position);
                        Interlocked.Add(ref mTotalBytesWritten, memStream.Position);
                    }
                    catch (InvalidOperationException)
                    {
                        isTerminated = true;
                        break;
                    }
                    catch (IOException)
                    {
                        isTerminated = true;
                        break;
                    }
                }
                mQueueMutex.ReleaseMutex();

                if (waitIndex == 1)
                    break;
            }

            mWriteStream.Flush();
        }
    }
}
