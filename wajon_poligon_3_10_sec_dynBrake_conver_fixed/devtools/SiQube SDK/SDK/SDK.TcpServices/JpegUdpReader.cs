using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SDK.Common;

namespace SDK.NetworksServices
{
    public class JpegUdpReader : IDisposable
    {
        private const int kListenPort = 6000;

        static readonly byte[] StopCmd = new byte[]
                                             {
                                                 0,0,0,0,
                                                 0,0,0,0,
                                                 0,0,0,0,
                                                 0,0,0,0,
                                                 0,0,0,0,
                                                 0,0,0,0,
                                                 0,0,0,0,
                                                 0,0,0,0
                                             };

        static readonly byte[] StartCmd = new byte[]
                                              {
                                                  0,0,0,1,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0
                                              };




        static readonly byte[] LightCmd = new byte[]
                                              {
                                                  0,0,0,2,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0,
                                                  0,0,0,0
                                              };


        /// <summary>
        /// Событие по приходу нового кадра
        /// </summary>
        public event FrameEvent OnFrame;

        private UdpClient mListener;
        private Thread mThread;
        private readonly byte mDuty;
        private readonly string mUrl;

        private readonly DelayedTask mConnectionChecker = new DelayedTask(5000);

        /// <summary>
        /// Приемник JPEG кадров с IP камеры
        /// </summary>
        /// <param name="url">IP камеры</param>
        /// <param name="duty">Процент включения подсветки</param>
        public JpegUdpReader(string url, byte duty)
        {
            mDuty = duty;
            mUrl = url;
            mThread = new Thread(Processing);

            mConnectionChecker.OnTimeout += sender =>
                                              {
                                                  sender.Stop();
                                                  mThread.Abort();
                                                  //Console.WriteLine("thread abort");

                                                  mThread = new Thread(Processing);
                                                  mThread.Start();
                                                  //Console.WriteLine("thread restart");
                                              };
            //mConnectionChecker.Start();
            mThread.Start();
            //Console.WriteLine("thread start");
        }

        private void Processing()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("udp camera processing start trying at: {0}", mUrl);
                    if (!mConnectionChecker.IsStart)
                        mConnectionChecker.Start();

                    mListener = new UdpClient(mUrl, kListenPort);
                    Thread.Sleep(100);
                    mListener.Send(StopCmd, StopCmd.Length);
                    Thread.Sleep(1000);

                    LightCmd[31] = 0;
                    mListener.Send(LightCmd, LightCmd.Length);
                    Thread.Sleep(1000);

                    mListener.Send(StartCmd, StartCmd.Length);
                    Thread.Sleep(1000);

                    LightCmd[31] = mDuty;
                    mListener.Send(LightCmd, LightCmd.Length);

                    mListener.Client.ReceiveTimeout = 3000;

                    Thread.Sleep(100);

                    var packetData = new byte[4500][];
                    var image = new byte[1600 * 1200 * 3];
                    var packetsInFrame = 0;
                    var currentFrame = 0;

                    while (mListener.Client.Connected)
                    {
                        if (!mConnectionChecker.IsStart)
                            mConnectionChecker.Start();

                        {
                            IPEndPoint remoteEp = null;
                            var bytes = mListener.Receive(ref remoteEp);
                            if (bytes.Length != 0)
                            {
                                var frame = bytes[0] << 8 | bytes[1];

                                if (currentFrame == 0)
                                    currentFrame = frame;

                                if (currentFrame != frame)
                                {
                                    // clear data
                                    for (var i = 0; i < ((packetsInFrame < packetData.Length) ? packetsInFrame : packetData.Length); i++)
                                    {
                                        packetData[i] = null;
                                    }
                                    packetsInFrame = 0;
                                    currentFrame = 0;
                                    //Console.WriteLine("c");
                                }
                                else
                                {
                                    var id = bytes[2] << 8 | bytes[3];
                                    packetData[id] = bytes;
                                    packetsInFrame++;
                                    //Console.Write("{0}:{1} ", frame, id);
                                    //Console.Write(".");
                                }
                            }
                            else
                            {
                                // собираем пакет
                                if (packetsInFrame < packetData.Length)
                                {
                                    //Console.Write(packetsInFrame + " ");
                                    var isvalid = true;

                                    var dstIndex = 0;
                                    for (var i = 0; i < packetsInFrame; i++)
                                    {
                                        if (packetData[i] != null)
                                        {
                                            //var id = packetData[i][2] << 8 | packetData[i][3];
                                            //var frameid = packetData[i][0] << 8 | packetData[i][1];

                                            //Console.Write("{0}:{1}:{2} ", frameid, id, packetData[i].Length);
                                            Array.Copy(packetData[i], 4, image, dstIndex, (packetData[i].Length - 4));
                                            dstIndex += (packetData[i].Length - 4);
                                        }
                                        else
                                        {
                                            // error
                                            //Console.Write("b");
                                            isvalid = false;
                                            break;
                                        }
                                    }
                                    //Console.WriteLine("s\n");

                                    if (isvalid)
                                    {
                                        var rv = new byte[dstIndex + 1];
                                        Array.Copy(image, rv, (dstIndex + 1));

                                        if (OnFrame != null)
                                            OnFrame(rv);

                                        //File.WriteAllBytes("F:/dump/image"  + currentFrame + ".jpg", rv);

                                        //Console.Write("g");

                                        mConnectionChecker.Stop();
                                    }
                                }

                                // clear data
                                for (var i = 0; i < ((packetsInFrame < packetData.Length) ? packetsInFrame : packetData.Length); i++)
                                {
                                    packetData[i] = null;
                                }
                                packetsInFrame = 0;
                                currentFrame = 0;
                            }
                        }
                    }

                    //Console.WriteLine("ooops, disconected");
                }
                catch (ThreadAbortException)
                {
                    //Console.WriteLine("udp camera processing aborted");
                    return;
                }
                catch (SocketException)
                {
                    //Console.WriteLine("Socket at {0}", mUrl);
                }
                catch (TimeoutException)
                {
                    //Console.WriteLine("Timeout");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Thread.Sleep(1000);
            }
        }

        public void Dispose()
        {
            if (mThread != null)
                if (mThread.IsAlive)
                    mThread.Abort();

            if (mListener != null)
                mListener.Close();
        }
    }

    public delegate void FrameEvent(byte[] data);
}