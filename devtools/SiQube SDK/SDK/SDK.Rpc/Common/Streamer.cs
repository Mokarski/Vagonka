using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SDK.Rpc.Common
{
    internal class Streamer : IDisposable
    {
        private readonly Stream mStream;
        private readonly StreamWriter mWriter;
        private readonly StreamReader mReader;

        private readonly List<byte> mBuffer;

        /// <summary>
        /// Stream managment
        /// </summary>
        /// <param name="stream"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Streamer(Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException();

            mStream = stream;
            mWriter = new StreamWriter(mStream);
            mReader = new StreamReader(mStream);
            mBuffer = new List<byte>();
        }

        /// <summary>
        /// Read line
        /// </summary>
        /// <param name="timeout">Read timeout. Work on unblocking stream only</param>
        /// <exception cref="ArgumentNullException">Stream disconnected</exception>
        /// <exception cref="ObjectDisposedException">Stream disconnected</exception>
        /// <exception cref="IOException">Stream disconnected</exception>
        /// <returns>Data string or blank string</returns>
        public string ReadLine(TimeSpan timeout)
        {
            var stopAt = (timeout == TimeSpan.MaxValue) ? DateTime.MaxValue : DateTime.Now.Add(timeout);

            while(DateTime.Now.CompareTo(stopAt) < 0) 
            {
                // if stream is blovking, we stop here to recieve any byte
                // if stream is unblocking, we get "-1"  value and return 
                var data = mStream.ReadByte();

                // break cycle
                if (data < 0)
                    return "";

                if (data <= 0) continue;

                // skip "/r/n"
                if(data != 13 && data != 10)
                    mBuffer.Add((byte) data);

                if (data != 10) continue; // 10 is EOF

                // get line
                var line = (new ASCIIEncoding()).GetString(mBuffer.ToArray());
                mBuffer.Clear();

                return (line);
            }

            return "";
        }

        /// <summary>
        /// Write data to stream
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException">Stream disconnected</exception>
        /// <exception cref="ObjectDisposedException">Stream disconnected</exception>
        /// <exception cref="IOException">Stream disconnected</exception>
        public void WriteLine(string data)
        {
            mWriter.WriteLine(data);
            mWriter.Flush();
        }

        /// <summary>
        /// Release all resources used by Streamer
        /// </summary>
        public void Dispose()
        {
            if(mWriter != null)
                mWriter.Close();

            if (mReader != null)
                mReader.Close();
        }
    }
}