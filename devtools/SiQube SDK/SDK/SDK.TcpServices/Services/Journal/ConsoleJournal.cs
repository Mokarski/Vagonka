using System;
using SDK.NetworksServices.Interfaces;

namespace SDK.NetworksServices.Services.Journal
{       
    public class ConsoleJournal : IJournal
    {
        private readonly object mLockMessage = new object();

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

        public void Debug(string message, MessageLevel level)
        {
            PrintToConsole(message, ConsoleColor.DarkGray);
        }

        public void Info(string message, MessageLevel level)
        {
            PrintToConsole(message, ConsoleColor.White);
        }

        public void Error(string message, MessageLevel level)
        {
            PrintToConsole(message, ConsoleColor.Red);
        }

        public void Warning(string message, MessageLevel level)
        {
            PrintToConsole(message, ConsoleColor.Yellow);
        }

        public void Fatal(string message, MessageLevel level)
        {
            PrintToConsole(message, ConsoleColor.DarkRed);
        }

        public JournalMessage GetRecords(DateTime time, byte count, bool reverse)
        {
            // TODO: возвращаем журнал событий с данного времени и глубиной
            // reverse = true - предыдущие от этой даты (более свежие), false - более старые
            return null;
        }

        public JournalMessages GetRecords(JournalCondition condition)
        {
            return new JournalMessages();
        }
    }
}