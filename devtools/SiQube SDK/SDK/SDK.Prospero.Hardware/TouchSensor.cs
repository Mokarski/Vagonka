using System;
using System.IO;
using System.Threading;

namespace SDK.Prospero.Hardware
{
    public static class TouchSensor
    {       
        private static int mY;
        private static int mX;
        private static bool mPress;
        private static readonly Thread ProcessingThread = new Thread(Processing);
        private static Stream mStream;
        private static bool mPressMessage;

        public static Action OnTouch;


        private static void Processing()
        {
            try
            {
                while (true)
                {
                    var inputEvent = new LinuxEventParser.InputEvent();

                    // get new event
                    while (inputEvent.type != LinuxEventParser.EventTypes.EV_SYN)
                    {
                        var data = new byte[16];
                        for (var i = 0; i < 16; i++)
                        {
                            var rv = mStream.ReadByte();
                            if (rv > 0)
                                data[i] = (byte)rv;
                        }
                        inputEvent = LinuxEventParser.ParseEvent(data);

                        if (inputEvent.type == LinuxEventParser.EventTypes.EV_ABS)
                        {
                            switch (inputEvent.code)
                            {
                                case LinuxEventParser.CodeTypes.ABS_X:
                                    {
                                        mY = inputEvent.value;
                                        Application.GetInstance().PostEvent(Application.EventType.MouseMove, AdcToAbsolute(mX, mY));
                                        //Console.WriteLine("mY: {0},{1}", AdcToAbsolute(mX, mY).X, AdcToAbsolute(mX, mY).Y);
                                    }
                                    break;

                                case LinuxEventParser.CodeTypes.ABS_Y:
                                    {
                                        mX = inputEvent.value;
                                        Application.GetInstance().PostEvent(Application.EventType.MouseMove, AdcToAbsolute(mX, mY));
                                        //Console.WriteLine("mX: {0},{1}", AdcToAbsolute(mX, mY).X, AdcToAbsolute(mX, mY).Y);
                                    }
                                    break;

                                case LinuxEventParser.CodeTypes.PRESSURE:
                                    {
                                        mPressMessage = true;
                                        mPress = inputEvent.value == 1;
                                    }
                                    break;

                            }

                            if (OnTouch != null)
                                OnTouch();
                        }

                    }
                    // need send press message here

                    if(mPressMessage)
                    {
                        Application.GetInstance().PostEvent(
                             mPress ? Application.EventType.MouseDown : Application.EventType.MouseUp,
                             AdcToAbsolute(mX, mY));

                        //Console.WriteLine("{2}: {0},{1}", AdcToAbsolute(mX, mY).X, AdcToAbsolute(mX, mY).Y, mPress ? "Down" : "Up");

                        mPressMessage = false; 
                    }
                }
            }
            catch (ThreadAbortException)
            {
                // correct shutdown                    
            }            
        }

        public static void Init(Stream aStream)
        {
            mStream = aStream;
            ProcessingThread.Start();
        }

        // TODO: calibration needed!
        private static MouseData AdcToAbsolute(int x, int y)
        {
            //Console.WriteLine("{0}:{1} - {2}:{3}", x, y, ((x - 280)/16), ((y - 220)/12));

            //return new MouseData { X = ((x - 280) / 16), Y = 320 - ((y - 220) / 12) }; // MI0280  
            return new MouseData { X = (x - 120) / 8, Y = ((y - 250) / 13) };  // MI0430
        }

        public static void Stop()
        {
            ProcessingThread.Abort();
        }
    }
}