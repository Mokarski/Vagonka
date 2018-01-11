using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using ProtoBuf;
using SDK.Common;

namespace SDK.NetworksServices.ProtoBufRemote
{
    public class TcpClientRpcChannel : RpcChannel
    {
        private readonly TcpClient mClient;
        //private readonly string mId;
        private readonly Queue<RpcMessage> mQueuedMessages = new Queue<RpcMessage>();
        private readonly object mQueuedMessagesLock = new object();

        private readonly Thread mReadThread;
        private readonly Thread mWriteThread;

        private long mTotalBytesRead;
        private long mTotalBytesWritten;

        private long mTransfered = -1;

        private readonly PeriodicTask mTimeout;
        public TcpClientRpcChannel(RpcController controller, TcpClient client, int timeout)//, string id)
            : base(controller)
        {
            mClient = client;
            //mId = id;

            mTimeout = new PeriodicTask(timeout)
                           {
                               OnPeriod = () =>
                                              {
                                                  if (mTransfered != (mTotalBytesRead + mTotalBytesWritten))
                                                  {
                                                      mTransfered = (mTotalBytesRead + mTotalBytesWritten);
                                                  }
                                                  else
                                                  {
                                                      Stop();

                                                      Console.WriteLine("TCPRpcClient timeout - stop");
                                                  }
                                              }
                           };

            mReadThread = new Thread(ReadProcessing);
            mWriteThread = new Thread(WriteProccessing);

            mTimeout.Start();
        }

        public override long TotalBytesRead { get { return Interlocked.Read(ref mTotalBytesRead); } }
        public override long TotalBytesWritten { get { return Interlocked.Read(ref mTotalBytesWritten); } }

        public override void Start()
        {
            mReadThread.Start();
            mWriteThread.Start();

            IsReady = true;
        }

        internal override void Send(RpcMessage message)
        {
            lock (mQueuedMessagesLock)
                mQueuedMessages.Enqueue(message);
        }

        private void WriteProccessing()
        {
            var memStream = new MemoryStream();
            var stream = mClient.GetStream();

            while (mClient.Connected)
            {
                try
                {
                    while (mQueuedMessages.Count > 0)
                    {
                        RpcMessage message;
                        lock (mQueuedMessagesLock)
                            message = mQueuedMessages.Dequeue();

                        memStream.Position = 0;
                        Serializer.SerializeWithLengthPrefix(memStream, message, PrefixStyle.Fixed32);

                        stream.Write(memStream.GetBuffer(), 0, (int)memStream.Position);
                        stream.Flush();

                        Interlocked.Add(ref mTotalBytesWritten, memStream.Position);
                    }

                    Thread.Sleep(20);
                }
                catch (Exception ex)
                {


                    if (ex is InvalidOperationException || ex is IOException)
                    {
                        // выход с ошибкой - гасим второй поток
                        Console.WriteLine("ReadThread  - Abort");
                        mReadThread.Abort();

                        ErrorHandler();

                        return;
                    }

                    if (ex is ThreadAbortException)
                    {
                        // просто выход
                        Console.WriteLine("ThreadAbortException - return");
                        return;
                    }

                    Console.WriteLine("client RPC message/Serialize operation error");
                    // что-то или не наше, или не стандартное
                    throw;
                }
            }

            Stop();
        }

        private void ReadProcessing()
        {
            var buffer = new byte[1024];
            var bytesRemaining = sizeof(int);
            var bufferPos = 0;
            var isReadingSize = true;

            var stream = mClient.GetStream();

            while (mClient.Connected)
            {
                try
                {
                    var bytesRead = stream.Read(buffer, bufferPos, bytesRemaining);
                    Interlocked.Add(ref mTotalBytesRead, bytesRead);
                    if (bytesRead == 0)
                        continue;

                    bufferPos += bytesRead;
                    bytesRemaining -= bytesRead;

                    if (bytesRemaining != 0) continue;

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
                catch (Exception ex)
                {

                    if (ex is InvalidOperationException || ex is IOException)
                    {
                        // выход с ошибкой - гасим второй поток
                        Console.WriteLine("ReadProcessign thread - stop");
                        mWriteThread.Abort();

                        ErrorHandler();

                        return;
                    }

                    if (ex is ThreadAbortException)
                    {
                        // просто выход
                        Console.WriteLine("ReadProcessign thread Abort - error");
                        return;
                    }

                    // что-то или не наше, или не стандартное
                    Console.WriteLine("ReadProcessign exception - stop");
                    throw;
                }
                Thread.Sleep(20);
            }

            Stop();
        }

        private void ErrorHandler()
        {
            Stop();

            if (OnError != null)
                OnError();
        }

        /// <summary>
        /// Closes all the streams and requests that the channel shutdown, then joins the channel threads until they
        /// have terminated.
        /// </summary>
        public override void Stop()
        {
            IsReady = false;
            mTimeout.Stop();

            if (mReadThread.IsAlive)
                mReadThread.Abort();

            if (mWriteThread.IsAlive)
                mWriteThread.Abort();

            if (mClient != null)
                mClient.Close();
        }
    }
}