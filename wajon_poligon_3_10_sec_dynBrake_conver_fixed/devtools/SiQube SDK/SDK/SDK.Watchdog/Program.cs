using System;
using System.IO;
using System.Threading;

namespace SDK.Watchdog
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region hack for usb0 ip set
            const string kIp = "30.0.0.2";
            const string kNetmask = "255.255.255.252";

            Console.WriteLine("set usb0 ip: {0} netmask {1}", kIp, kNetmask);
            Process.Start("/sbin/ifconfig", "usb0 " + kIp + " netmask " + kNetmask);
            #endregion
            */

            // main part
            ProcessHelper processHelper = null;
            try
            {
                processHelper = new ProcessHelper(ParseProcessFileName(args), ParseInterval(args));
                processHelper.Start();

                while (true)
                {
                    Thread.Sleep(500);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (processHelper != null)
                processHelper.Stop();
        }

        private static int ParseInterval(string[] args)
        {
            if (args.Length < 2)
                throw new Exception("Не задан интервал проверки файла запуска в секундах");

            int interval;
            if (!int.TryParse(args[1], out interval) || (interval < 1))
                throw new Exception("Интервал проверки файла запуска не является числом или меньше 1");

            return interval;
        }

        private static string ParseProcessFileName(string[] args)
        {
            if (args.Length == 0)
                throw new Exception("Не задан файл для запуска");

            var processFileName = args[0];
            if (!File.Exists(processFileName))
                throw new Exception("Файл для запуска не найден");

            return processFileName;
        }
    }
}
