using System;
using System.IO;

namespace SDK.Prospero.Hardware
{
    public static class Battery
    {
        private static float mLastValue;
        private static DateTime mLastTimeRequest;


        /// <summary>
        /// Get LiPol battery voltage
        /// </summary>
        public static float Voltage
        {
            get
            {
                try
                {
                    if (File.Exists("/sys/class/power_supply/battery/voltage_now"))
                    {
                        if (DateTime.Now.Subtract(mLastTimeRequest).TotalSeconds >= 5)
                            using (var rv = new StreamReader("/sys/class/power_supply/battery/voltage_now"))
                            {
                                mLastValue = ((Single.Parse(rv.ReadToEnd()) / 1000000) + 0.1f);
                                mLastTimeRequest = DateTime.Now;
                                return mLastValue;
                            }    
                    }

                }
                catch (DirectoryNotFoundException) {}
                catch (FileNotFoundException) {}
                catch(ArgumentException){}
                catch(IOException){}

                //return float.NaN;
                return mLastValue;
            }
        }
    }
}