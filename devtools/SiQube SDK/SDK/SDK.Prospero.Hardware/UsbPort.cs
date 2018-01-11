using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SDK.Prospero.Hardware
{
    public delegate void UsbEvent();

    public static class UsbPort
    {
        private static Thread mProceesingThread;
        private static void ThreadHandler()
        {

            try
            {
                var state = false;
                while (true)
                {

                    if(state != IsOnline)
                    {
                        state = IsOnline;
                        if(state)
                        {
                            if (OnConnect != null)
                                OnConnect();
                        }
                        else
                        {
                            if (OnDisconnect != null)
                                OnDisconnect();      
                        }
                    }

                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException)
            {

            }
        }


        /// <summary>
        /// Is USB port 0 connected?
        /// </summary>
        public static bool IsOnline
        {
            get
            {
                try
                {
                    using (var rv = new StreamReader("/sys/class/power_supply/usb/online"))
                    {
                        return UInt32.Parse(rv.ReadToEnd()) > 0;
                    }
                }
                catch (DirectoryNotFoundException) { }
                catch (FileNotFoundException) { }
                catch (ArgumentException) { }
                catch (IOException) { }

                return true;
            }
        }

        public static event UsbEvent OnConnect;
        public static event UsbEvent OnDisconnect;


        public static void Init()
        {
            if(mProceesingThread != null)
                return;
            
            mProceesingThread = new Thread(ThreadHandler);
            mProceesingThread.Start();
        }

        public static void Dispose()
        {
            if (MultiGadget.IsRun)
                MultiGadget.Stop();

            if (mProceesingThread != null)
                mProceesingThread.Abort();
        }

        public static class MultiGadget
        {
            public static bool IsRun { get; private set; }

            public static event UsbEvent OnStart;
            public static void Start()
            {
                if (IsRun)
                    return;

                try
                {
                    var startInfo = new ProcessStartInfo { FileName = "/sbin/modprobe", Arguments = "g_multi file=/opt/appfs.img stall=0" };
                    Process.Start(startInfo);

                    if (OnStart != null)
                        OnStart();

                    IsRun = true;
                }
                catch (InvalidOperationException) { }
                catch (ArgumentNullException) { }
                catch (Win32Exception) { }
            }

            public static event UsbEvent OnStop;
            public static void Stop()
            {
                if (!IsRun)
                    return;

                try
                {
                    var startInfo = new ProcessStartInfo { FileName = "/sbin/rmmod", Arguments = "g_multi" };
                    Process.Start(startInfo);

                    /*
                    startInfo = new ProcessStartInfo { FileName = "/sbin/reboot", Arguments = "" };
                    Process.Start(startInfo);
                    */

                    if (OnStop != null)
                        OnStop();

                    IsRun = false;
                }
                catch (InvalidOperationException) { }
                catch (ArgumentNullException) { }
                catch (Win32Exception) { }
            }

        }
    }
}