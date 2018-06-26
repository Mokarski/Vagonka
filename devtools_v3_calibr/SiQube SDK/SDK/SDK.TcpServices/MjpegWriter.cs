using System;
using System.IO;
using System.Text;

namespace SDK.NetworksServices
{
    /// <summary>
    /// Provides a stream writer that can be used to write images as MJPEG 
    /// or (Motion JPEG) to any stream.
    /// </summary>
    public class MjpegWriter : IDisposable
    {
        public MjpegWriter(Stream stream)
            : this(stream, "--boundary")
        {

        }

        public MjpegWriter(Stream stream, string boundary)
        {

            Stream = stream;
            Boundary = boundary;
        }

        public string Boundary { get; private set; }
        public Stream Stream { get; private set; }

        public void WriteHttpHeader()
        {
            Write("HTTP/1.1 200 OK\r\n");
            Stream.Flush();
        }

        public void WriteMimeHeader()
        {
            //"HTTP/1.1 200 OK\r\n" +
            //"Content-Type: multipart/mixed; boundary=" +
            
            Write(string.Format("Content-Type: multipart/x-mixed-replace; boundary=" + Boundary + "\r\n"));
            Stream.Flush();
        }

        private void WriteFrame(byte[] data)
        {
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine(Boundary);
            sb.AppendLine("Content-Type: image/jpeg");
            sb.AppendLine("Content-Length: " + data.Length.ToString(""));
            sb.AppendLine();

            Write(sb.ToString());
            Write(data);
            //Write("\r\n");

            Stream.Flush();

        }

        private void Write(byte[] data)
        {
            Stream.Write(data, 0, data.Length);
        }

        private void Write(string text)
        {
            var data = Encoding.ASCII.GetBytes(text);
            Stream.Write(data, 0, data.Length);
        }

        #region IDisposable Members

        public void Dispose()
        {
            try
            {
                if (Stream != null)
                    Stream.Dispose();

            }
            finally
            {
                Stream = null;
            }
        }

        #endregion

        public void WriteFrame()
        {
            if (mImage == null)
                return;

            WriteFrame(mImage);

            /*
            var sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendLine(Boundary);
            sb.AppendLine("Content-Type: image/jpeg");
            sb.AppendLine("Content-Length: " + mImage.Length.ToString(""));
            sb.AppendLine();

            Write(sb.ToString());
            Write(mImage);
            Write("\r\n");

            Stream.Flush();
            */

        }

        private byte[] mImage = new byte[] { };
        public void UpdateData(byte[] image)
        {
            mImage = image;
            //Console.Write(".");
        }
    }
}