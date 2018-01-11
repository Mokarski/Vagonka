using System;
using System.IO;
using System.Threading;

namespace SDK.Prospero.Hardware
{
    public class GpioKeyboard
    {
        private static readonly Thread ProcessingThread = new Thread(Processing);
        private static Stream mStream;

        public static Action OnUpdate;

        private static void Processing()
        {
            try
            {
                while (true)
                {
                    //var inputEvent = new LinuxEventParser.InputEvent();

                    var data = new byte[16];
                    for (var i = 0; i < 16; i++)
                    {
                        var rv = mStream.ReadByte();
                        if (rv > 0)
                            data[i] = (byte)rv;
                    }
                    var inputEvent = LinuxEventParser.ParseEvent(data);
                    //Console.Write("e");
                    if (inputEvent.type == LinuxEventParser.EventTypes.EV_KEY)
                    {
                        //Console.WriteLine(":");
                            Application.GetInstance().PostEvent(
                                 inputEvent.value == 1 ? Application.EventType.KeyboardRelease : Application.EventType.KeyboardPress,
                                 new KeyboardData { Keycode = (int)inputEvent.code });

                            if (OnUpdate != null)
                                OnUpdate();
                    }

                    Thread.Sleep(20);


                    //Thread.Sleep(200);
                }
            }
            catch (ThreadAbortException)
            {
                // correct shutdown                    
            }

            //Console.WriteLine("<-- Gpio Processing");
        }

        public static void Init(Stream aStream)
        {
            mStream = aStream;
            ProcessingThread.Start();
        }


    }
}