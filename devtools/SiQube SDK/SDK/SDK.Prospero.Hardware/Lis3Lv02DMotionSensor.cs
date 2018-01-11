using System;
using System.IO;
using System.Threading;
using SDK.UI;

namespace SDK.Prospero.Hardware
{
    public delegate void MotionEvent(MotionData data);

    public static class Lis3Lv02DMotionSensor
    {
        private static Thread mProceesingThread;
        private static MotionData mLastPosition;

        private static void ThreadHandler()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        using (var accelerometer = new StreamReader("/sys/devices/platform/lis3lv02d/position"))
                        {
                            var data = accelerometer.ReadLine();
                            if (String.IsNullOrEmpty(data)) continue;

                            short x, y, z;
                            var parameters = data.Split(new[] { '(', ',', ')' });
                            Int16.TryParse(parameters[1], out x);
                            Int16.TryParse(parameters[2], out y);
                            Int16.TryParse(parameters[3], out z);

                            var pos = new MotionData(x, y, z);
                            if (Equals(pos, mLastPosition)) continue;

                            mLastPosition = pos;

                            if (OnMotion != null)
                                OnMotion(mLastPosition);
                        }
                    }
                    catch (DirectoryNotFoundException) { }
                    catch (FileNotFoundException) { }
                    catch (ArgumentException) { }
                    catch (IOException) { }

                    //Thread.Sleep(200);
                    Thread.Sleep(1000);
                }
            }
            catch (ThreadAbortException) { }
        }

        public static void Init()
        {
            if (mProceesingThread != null)
                return;

            mProceesingThread = new Thread(ThreadHandler);
            mProceesingThread.Start();
        }

        public static void Dispose()
        {
            if (mProceesingThread != null)
                mProceesingThread.Abort();
        }

        public static event MotionEvent OnMotion;
    }
}