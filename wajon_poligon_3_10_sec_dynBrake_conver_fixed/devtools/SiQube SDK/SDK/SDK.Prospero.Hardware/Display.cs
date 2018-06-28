using System;
using System.IO;

namespace SDK.Prospero.Hardware
{
    public static class Display
    {
        /// <summary>
        /// TFT display backlight brigthtness
        /// </summary>
        public static byte Brightness
        {
            get
            {
                try
                {
                    using (var rv = new StreamReader("/sys/class/backlight/mxs-bl/brightness"))
                    {
                        return Byte.Parse(rv.ReadToEnd());
                    }
                }
                catch (DirectoryNotFoundException) { }
                catch (FileNotFoundException) { }
                catch (ArgumentException) { }
                catch (IOException) { }

                return 0;
            }
            set
            {
                try
                {
                    using (var rv = new StreamWriter("/sys/class/backlight/mxs-bl/brightness"))
                    {
                        rv.WriteLine(value);
                    }
                }
                catch (DirectoryNotFoundException) { }
                catch (FileNotFoundException) { }
                catch (ArgumentException) { }
                catch (IOException) { }
            }
        }

        public static byte DefaultBrightness { get; set; }

        public static void SetDefaultBrightness()
        {
            Brightness = DefaultBrightness;
        }
    }
}