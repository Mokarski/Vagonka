using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Timers;
using SDK.Interfaces;
using Timer = System.Timers.Timer;

namespace SDK.Common
{
    public class LocationService : ITask
    {
        private static Thread mProceesingThread;
        private static SerialPort mPort;
        private static string mPortName;

        public Action<string> OnCheckIn;
        public Action<string> OnCheckOut;
        private static Timer mTimer;

        public bool IsOnStation { get; private set; }
        public string StationName { get; private set; }


        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            mTimer.Stop();

            if (!IsOnStation) return;
            IsOnStation = false;

            if (OnCheckOut != null)
            {
                //Console.WriteLine("OnCheckOut");
                OnCheckOut(StationName);
            }

        }


        private bool IsMultipassStation(string name)
        {
            switch (name)
            {
                case "Liverpool Street":
                case "Stanstead Airport":
                case "Starbucks":
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Thread handler for ble data transfer. On event call a suitable delegate method
        /// </summary>
        private void ThreadHandler()
        {
            try
            {
                while (true)
                {
                    if (mPort == null)
                    {
                        try
                        {
                            //Console.WriteLine("Open ble port");
                            mPort = new SerialPort(mPortName, 115200, Parity.None, 8, StopBits.One)
                            {
                                Handshake = Handshake.None,
                                BaudRate = 115200,
                                RtsEnable = true,
                                NewLine = "\r\n",
                                WriteTimeout = 10,
                            };
                            mPort.Open();
                        }
                        catch (IOException)
                        {
                            Console.WriteLine("Ooops on opening {0}", mPortName);
                            mPort = null;
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Cann't find {0}", mPortName);
                            mPort = null;
                        }
                        catch (UnauthorizedAccessException) { }

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        try
                        {
                            if (mPort.IsOpen)
                            {
                                var data = mPort.ReadLine();

                                //Heathrow Terminal : - 68                                
                                var rv = data.Split(new[] { ':', '-' });
                                if (rv.Length > 2)
                                {
                                    //Application.GetInstance().PostEvent(Application.EventType.BLEMessage, new BLEBeacon { Name = rv[0], Rssi = -1 * Convert.ToInt32(rv[rv.Length - 1]) });

                                    //Console.WriteLine("{0}:{1}", rv[0], -1 * Convert.ToInt32(rv[rv.Length - 1]));
                                    var rssi = -1*Convert.ToInt32(rv[rv.Length - 1]);

                                    if (IsOnStation == false)
                                        StationName = rv[0].Trim();

                                    {

                                        //Console.WriteLine("beacon: {0}",((BLEBeacon) aData).Rssi);

                                        if (rssi > -75)
                                        {
                                            //Console.WriteLine(StationName);
                                            //if (StationName.Length > 6)
                                            {

                                                if (IsMultipassStation(StationName))
                                                if (IsOnStation == false)
                                                {
                                                    //mStation.Text = ((BLEBeacon)aData).Name;
                                                    IsOnStation = true;

                                                    if (OnCheckIn != null)
                                                    {
                                                        //Console.WriteLine("OnCheckIn");
                                                        OnCheckIn(StationName);     
                                                    }

                                                }



                                                mTimer.Stop();
                                                mTimer.Interval = new TimeSpan(0, 0, 0, 2, 0).TotalMilliseconds;
                                                mTimer.Enabled = true;
                                                mTimer.Start();
                                            }
                                        }
                                    }
                                }


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
                Console.WriteLine("ooops, ble thread was aborted");
                if (mPort != null)
                    if (mPort.IsOpen)
                        mPort.Close();
            }
        }

        public void Init(string port)
        {
            if (mProceesingThread != null)
                return;

            mPortName = port;

            mTimer = new Timer();
            mTimer.Elapsed += OnTimedEvent;

            mProceesingThread = new Thread(ThreadHandler);

        }

        public void Start()
        {
            if (mProceesingThread != null)
                mProceesingThread.Start();
        }

        public void Stop()
        {
            if (mProceesingThread != null)
                mProceesingThread.Abort();
        }
    }
}