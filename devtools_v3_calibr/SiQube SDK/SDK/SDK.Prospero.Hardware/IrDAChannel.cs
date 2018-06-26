using System;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace SDK.Prospero.Hardware
{
    public delegate string IrDAMessage(string message);

    public static class IrDAChannel
    {
        private static Thread mProceesingThread;             
        private static SerialPort mIrdaPort;
        private static string mPortName;

        /// <summary>
        /// Thread handler for irda data transfer. On event call a suitable delegate method
        /// </summary>
        private static void ThreadHandler()
        {
            try
            {
                while (true)
                {
                    if (mIrdaPort == null)
                    {
                        try
                        {
                            //Console.WriteLine("Open irda port");
                            mIrdaPort = new SerialPort(mPortName, 115200, Parity.None, 8, StopBits.One)
                                            {
                                                Handshake = Handshake.None,
                                                BaudRate = 115200,
                                                RtsEnable = true,
                                                NewLine = "\r\n",
                                                WriteTimeout = 10,
                                            };
                            mIrdaPort.Open();
                        }
                        catch (IOException)
                        {
                            //Console.WriteLine("Ooops on opening {0}", mPortName);
                            mIrdaPort = null;
                        }
                        catch (ArgumentException)
                        {
                            //Console.WriteLine("Cann't find {0}", mPortName);
                            mIrdaPort = null;
                        }
                        catch(UnauthorizedAccessException){}

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        try
                        {
                            if (mIrdaPort.IsOpen)
                            {
                                /*
                                  посылка блока:
                                      $DATA,
                                      section_num_placement,
                                      section_num_ctrl,
                                      DD1,
                                      DPS,
                                      INC, // int angle
                                      STOP, // general stop
                                      BLOCK, // general block
                                      egk_bitmap_os,
                                      *FF\r\n
                                */
                                #region test request
                                /*
                                {
                                    if (OnDataMessage != null)
                                    {
                                        switch (mReportId)
                                        {
                                            case 0:
                                                Report(OnDataMessage("$DATA,4,3,260,300,15,0,0,0*FF"));
                                                mReportId = 1;
                                                break;

                                            case 1:
                                                //Report(OnDataMessage("$DATA,,,,,,,,*FF"));
                                                Report(OnDataMessage("$DATA,4,3,251,300,15,0,0,0*FF"));
                                                mReportId = 2;
                                                break;

                                            case 2:
                                                Report(OnDataMessage("$DATA,4,5,156,500,-15,0,0,0*FF"));
                                                //Report(OnDataMessage("$DATA,4,3,252,300,15,0,0,0*FF"));
                                                mReportId = 3;
                                                break;

                                            case 3:
                                                //Report(OnDataMessage("$DATA,,,,,,,,*FF"));
                                                Report(OnDataMessage("$DATA,4,3,250,300,15,0,0,0*FF"));
                                                mReportId = 4;
                                                break;

                                            case 4:
                                                Report(OnDataMessage("$DATA,4,4,523,400,-9,0,0,0*FF"));
                                                //Report(OnDataMessage("$DATA,4,3,254,300,15,0,0,0*FF"));
                                                mReportId = 5;
                                                break;

                                            case 5:
                                                //Report(OnDataMessage("$DATA,,,,,,,,*FF"));
                                                
                                                // emulation of connect losing
                                                Thread.Sleep(2000);
                                                mReportId = 0;
                                                break;
                                        }
                                    }
                                    Thread.Sleep(200);
                                }
                                */
                                #endregion

                                #region working code
                                
                                var data = mIrdaPort.ReadLine();

                                if (data.Contains("$DATA"))
                                {
                                    if (OnDataMessage != null)
                                    {
                                        Report(OnDataMessage(data));
                                    }
                                }
                                
                                #endregion
                            }
                            else
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        catch (TimeoutException) { }
                    }
                }
            }
            catch (ThreadAbortException)
            {
                //Console.WriteLine("ooops, irda thread was aborted");
                if (mIrdaPort != null)
                    if (mIrdaPort.IsOpen)
                        mIrdaPort.Close();
            }
        }

        public static void Init(string port)
        {
            if (mProceesingThread != null)
                return;

            mPortName = port;

            mProceesingThread = new Thread(ThreadHandler);
            mProceesingThread.Start();
        }

        public static void Dispose()
        {
            if (mProceesingThread != null)
                mProceesingThread.Abort();
        }

        public static event IrDAMessage OnDataMessage;

        private static void Report(string data)
        {
            if (mIrdaPort == null) return;

            if (!mIrdaPort.IsOpen) return;

            HwCore.UpdateTimeout();      

            if(string.IsNullOrEmpty(data)) return;

            mIrdaPort.WriteLine(data);
        }
    }
}
