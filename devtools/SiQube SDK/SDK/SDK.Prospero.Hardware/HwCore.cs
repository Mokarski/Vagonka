using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SDK.Prospero.Hardware
{    
    public class HwCore
    {
        private static DateTime mLastEventTime;
        private static Thread mProceesingThread;
        private static void HandDown(MotionData data)
        {

            if (UsbPort.IsOnline) return;
            if (data.X >= -800) return;

            SparcKeyboard.Backlight.Off();
            Thread.Sleep(50);
            Standby();
            mLastEventTime = DateTime.Now;
            SparcKeyboard.Backlight.On();
        }

        private static void ThreadHandler()
        {
            var type = Application.OperationSystem;

            try
            {
                while (true)
                {
                    try
                    {
                        if(type == Application.OS.Linux)
                        {
                            if (DateTime.Now.Subtract(mLastEventTime).TotalSeconds > StandbyTimeout.TotalSeconds)
                            {
                                if (DeepStandby)
                                {
                                    if (UsbPort.IsOnline == false)
                                    {
                                        SparcKeyboard.Backlight.Off();
                                        Thread.Sleep(50);
                                        Standby();
                                        SparcKeyboard.Backlight.On();
                                    }
                                    mLastEventTime = DateTime.Now;
                                }
                                else
                                {
                                    Display.Brightness = 10;
                                }
                            }
                            else
                            {
                                Display.SetDefaultBrightness();
                            }
                        }
                        
                        Thread.Sleep(200);
                    }
                    catch (DirectoryNotFoundException) { }
                    catch (FileNotFoundException) { }
                    catch (IOException) { }
                }
            }
            catch (ThreadAbortException) { }
        }

        public static bool DeepStandby { get; set; }
        public static TimeSpan StandbyTimeout { get; set; }

        public static void UpdateTimeout()
        {
            //Console.WriteLine("UpdateTimeout");
            mLastEventTime = DateTime.Now;
        }

        /// <summary>
        /// Go to standby mode
        /// </summary>
        public static void Standby()
        {
            try
            {
                if (UsbPort.IsOnline == false)
                    using (var rv = new StreamWriter("/sys/power/state"))
                    {
                        rv.WriteLine("standby");
                    }
            }
            catch (DirectoryNotFoundException) { }
            catch (FileNotFoundException) { }
            catch (ArgumentException) { }
            catch (IOException) { }
        }

        /// <summary>
        /// Poweroff
        /// </summary>
        public static void Poweroff()
        {
            try
            {
                Process.Start("poweroff");
            }
            catch (System.ComponentModel.Win32Exception)
            {
            }
        }

        public static void Init(Application.OS type)
        {
            if (mProceesingThread != null)
                return;

            mLastEventTime = DateTime.Now;
    
            if(StandbyTimeout == new TimeSpan())
                StandbyTimeout = TimeSpan.MaxValue;

            switch (type)
            {
                case Application.OS.Linux:
                    {
                        //UsbPort.Init();
                        //UsbPort.OnConnect += UsbPort.MultiGadget.Start;
                        //UsbPort.OnDisconnect += UsbPort.MultiGadget.Stop;
                        //Console.WriteLine("HwInit");

                        UpdateTimeout();
                        //TouchSensor.Init(new FileStream(@"/dev/input/ts0", FileMode.Open));
                        TouchSensor.OnTouch += UpdateTimeout;

                        //GpioKeyboard.Init(new FileStream("/dev/input/gpio-keys", FileMode.Open));
                        GpioKeyboard.OnUpdate += UpdateTimeout;

                        SparcKeyboard.OnUpdate += UpdateTimeout;
                        
                        /*
                        SparcKeyboard.Init("/dev/ttySP1");
                        SparcKeyboard.KeyToAscii = new int[]{'1', // auto
                                                        'Q',
                                                        'A',
                                                        'L', // left
                                                        'Z',
                                                        'X',
                                                        'C',
                                                        'V',
                                                        'B',
                                                        'N',
                                                        'R', // right
                                                        'H',
                                                        'Y',
                                                        '6'
                                                       };
                        */
                        //IrDAChannel.Init("/dev/ttySP2");                       

                        //Lis3Lv02DMotionSensor.Init();
                        Lis3Lv02DMotionSensor.OnMotion += HandDown;
                         
                    }
                    break;

                case Application.OS.Windows:
                    {
                        SparcKeyboard.Init("COM7");                        
                        //IrDAChannel.Init("COM30");
                    }
                    break;
            }


            mProceesingThread = new Thread(ThreadHandler);
            mProceesingThread.Start();
        }

        public static void Dispose()
        {
            UsbPort.Dispose();
            SparcKeyboard.Dispose();
            IrDAChannel.Dispose();
            Lis3Lv02DMotionSensor.Dispose();
            
            if (mProceesingThread != null)
                mProceesingThread.Abort();
        }
    }
}
