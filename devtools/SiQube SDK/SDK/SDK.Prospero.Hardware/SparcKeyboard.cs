using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using SDK.UI;

namespace SDK.Prospero.Hardware
{
    // TODO
    /*
     root@freescale /mnt/software/bin$ mono ./SDK.UI.Linux.exe wxga
        wxga app
        HwInit
        * Assertion at class.c:7883, condition `ac->rank' not met

        Stacktrace:

          at <unknown> <0xffffffff>
          at (wrapper managed-to-native) object.__icall_wrapper_mono_array_new_specific (intptr,int) <0xffffffff>
          at System.Collections.Generic.List`1<byte>.ToArray () <0x0001b>
          at System.IO.Ports.SerialPort.ReadTo (string) <0x000df>
          at System.IO.Ports.SerialPort.ReadLine () <0x00017>
          at (wrapper remoting-invoke-with-check) System.IO.Ports.SerialPort.ReadLine () <0xffffffff>
          at SDK.Prospero.Hardware.SparcKeyboard.ThreadHandler () <0x002bb>
          at System.Threading.Thread.StartInternal () <0x0007f>
          at (wrapper runtime-invoke) object.runtime_invoke_void__this__ (object,intptr,intptr,intptr) <0xffffffff>
 
     */
    
    public static class SparcKeyboard
    {
        private static SerialPort mKeyPort;
        private static Thread mProceesingThread;
        private static string mPortName;
        private static UInt32 mState;

        /// <summary>
        /// Thread handler for keypress event. On event call a OnKeyEvent() delegate method
        /// </summary>
        private static void ThreadHandler()
        {
            try
            {
                while (true)
                {                    
                    if (mKeyPort == null)
                    {
                        try
                        {
                            mKeyPort = new SerialPort(mPortName, 115200, Parity.None, 8, StopBits.One)
                                           {
                                               Handshake = Handshake.None,
                                               BaudRate = 115200,
                                               //RtsEnable = true,
                                               NewLine = "\r\n",
                                               ReadBufferSize = 8192 * 16,
                                               WriteTimeout = 10
                                           };
                            
                            if(mKeyPort != null)
                            {
                                mKeyPort.Open();

                                if (mKeyPort.IsOpen)
                                {
                                    Backlight.Brightness(30);
                                    //mKeyPort.WriteLine("$LED,30,30*FF");
                                    //mKeyPort.WriteLine("$PWR,0*FF");
                                }

                            }
                        }
                        catch (UnauthorizedAccessException) {}
                        catch (IOException)
                        {
                            //Console.WriteLine("Ooops on opening {0}", mPortName);
                            mKeyPort = null;
                        }
                        catch (ArgumentException)
                        {
                            //Console.WriteLine("Cann't find {0}", mPortName);
                            mKeyPort = null;
                        }

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        try
                        {
                            if (mKeyPort.IsOpen)
                            {
                                //Thread.Sleep(5000);
                                //var data = "$KBD,2";
                                
                                var data = mKeyPort.ReadLine();
                                
                                //Application.GetInstance().DebugTimeToConsole(">");

                                if (data.Contains("$KBD"))
                                {
                                    var parameters = data.Split(new[] { ',', '*' });
                                    uint rv;                                    
                                    if (UInt32.TryParse(parameters[1], out rv))                                    
                                    {

                                        //Console.WriteLine("keyboard: rv - 0x{0:X}, mState - 0x{1:X}", rv, mState);
                                        if(mState != rv)
                                        {
                                            for (var i = 0; i < KeyToAscii.Length; i++)
                                            {
                                                if (((rv >> i) & 0x01) == 1)
                                                {
                                                    if (((mState >> i) & 0x01) == 0)
                                                    {
                                                        //Application.GetInstance().DebugTimeToConsole("r");
                                                        Application.GetInstance().PostEvent(Application.EventType.KeyboardPress, new KeyboardData { Keycode = KeyToAscii[i] });
                                                        //Console.WriteLine("{2}: keyboard press: {0} - {1}", i, KeyToAscii[i], DateTime.Now.ToString("mm:ss.fff"));
                                                    }

                                                }
                                                else
                                                {
                                                    if (((mState >> i) & 0x01) == 1)
                                                    {
                                                        //Application.GetInstance().DebugTimeToConsole("r");
                                                        Application.GetInstance().PostEvent(Application.EventType.KeyboardRelease, new KeyboardData { Keycode = KeyToAscii[i] });
                                                        //Console.WriteLine("{1}: keyboard release: {0}", i, DateTime.Now.ToString("mm:ss.fff"));
                                                    }
                                                }
                                            }

                                            mState = rv;                                            
                                        }
                                    }

                                    if (OnUpdate != null)
                                        OnUpdate();
                                }

                                //Application.GetInstance().DebugTimeToConsole("<");
                            }
                        }
                        catch (TimeoutException) { }
                        catch (IOException) { }
                    }
                }
            }
            catch (ThreadAbortException)
            {
                if (mKeyPort != null)
                    if (mKeyPort.IsOpen)
                        mKeyPort.Close();
            }
        }

        public static int[] KeyToAscii; 

        public static void Init(string port)
        {
            if (mProceesingThread != null)
                return;

            mPortName = port;

            mState = 0;

            mProceesingThread = new Thread(ThreadHandler);
            mProceesingThread.Start();
        }

        public static void Dispose()
        {
            if (mProceesingThread != null)
                mProceesingThread.Abort();
        }

        public static class Backlight
        {
            /// <summary>
            /// Switch-on keyboard led backlight
            /// </summary>
            public static void Off()
            {
                if (mKeyPort == null)
                    return;

                if (!mKeyPort.IsOpen)
                    return;

                mKeyPort.WriteLine("$PWR,1*FF");
                while (mKeyPort.BytesToWrite > 0) { Thread.Sleep(20); }

                Thread.Sleep(200);
            }

            /// <summary>
            /// Switch-off keyboard led backlight
            /// </summary>
            public static void On()
            {
                if (mKeyPort == null)
                    return;

                if (!mKeyPort.IsOpen)
                    return;

                mKeyPort.WriteLine("$PWR,2*FF");
            }

            public static void Brightness(uint percent, uint map = 0)
            {
                if (mKeyPort == null)
                    return;

                if (!mKeyPort.IsOpen)
                    return;

                var percentLed = percent > 100 ? 100 : percent;
                //var orangeLed = active > 100 ? 100 : active;
                mKeyPort.WriteLine("$LED,"+ map + "," + percent + "*FF");   
                //mKeyPort.WriteLine("$LED,"+ blueLed + "," + orangeLed + "*FF");   //носимый 
            }
        }

        public static event Action OnUpdate;
    }
}