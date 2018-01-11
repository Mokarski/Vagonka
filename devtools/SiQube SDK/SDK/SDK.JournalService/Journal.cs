using System;
using log4net;

namespace SDK.JournalService
{
    public class Journal : IJournal
    {
        private readonly ILog mLogger;
        private readonly object mLockMessage = new object();

        public bool IsColorConsole { get; set; }

        public Journal(ILog logger)
        {
            if(logger == null)
                throw new ArgumentNullException("logger");

            IsColorConsole = true;
            mLogger = logger;
        }

        private string PrepareMessage(string message)
        {
            return string.Format("{0}: {1}", DateTime.Now.ToString("HH:mm:ss.fff"), message);
        }

        private void PrintToConsole(string message, ConsoleColor color)
        {
            lock (mLockMessage)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(PrepareMessage(message));
                Console.ForegroundColor = ConsoleColor.Gray;   
            }
        }

        public void Debug(string message)
        {
            if (IsColorConsole)
            {
                PrintToConsole(message, ConsoleColor.DarkGray);
            }

            //mLogger.Info(message);
        }

        public void Info(string message)
        {
            if(IsColorConsole)
            {
               PrintToConsole(message, ConsoleColor.White);
            }
            
            //mLogger.Info(message);
        }

        public void Error(string message)
        {
            if (IsColorConsole)
            {
                PrintToConsole(message, ConsoleColor.Red);
            }
            
            mLogger.Error(message);
        }

        public void Warning(string message)
        {
            if (IsColorConsole)
            {
                PrintToConsole(message, ConsoleColor.Yellow);
            }
            
            //mLogger.Warn(message);
        }

        public void Fatal(string message)
        {
            if (IsColorConsole)
            {
                PrintToConsole(message, ConsoleColor.DarkRed);
            }

            mLogger.Fatal(message);
        }

        public IJournalMessage GetRecords(DateTime time, byte count, bool reverse)
        {
            // TODO: возвращаем журнал событий с данного времени и глубиной
            // reverse = true - предыдущие от этой даты (более свежие), false - более старые
            return null;
        }
    }
}       