using SDK.NetworksServices.Interfaces;

namespace SDK.NetworksServices.Services.Journal
{
    public class SqLiteJournal : IJournal
    {
        private readonly JournalDbConnection mConnection = JournalDbConnection.Instance;
        private readonly ConsoleJournal mConsole = new ConsoleJournal();

        public bool IsConsoleEnable { get; set; }

        public void Debug(string message, MessageLevel level)
        {
            mConnection.Save(MessageType.Debug, message);
            
            if(IsConsoleEnable)
                mConsole.Debug(message, level);
        }

        public void Fatal(string message, MessageLevel level)
        {
            mConnection.Save(MessageType.Fatal, message);

            if (IsConsoleEnable)
                mConsole.Fatal(message, level);
        }

        public void Warning(string message, MessageLevel level)
        {
            mConnection.Save(MessageType.Warning, message);

            if (IsConsoleEnable)
                mConsole.Warning(message, level);
        }

        public void Error(string message, MessageLevel level)
        {
            mConnection.Save(MessageType.Error, message);

            if (IsConsoleEnable)
                mConsole.Error(message, level);
        }

        public void Info(string message, MessageLevel level)
        {
            mConnection.Save(MessageType.Info, message);

            if (IsConsoleEnable)
                mConsole.Info(message, level);
        }

        public JournalMessages GetRecords(JournalCondition condition)
        {
            //mConsole.Debug("->>", MessageLevel.System);
            //Thread.Sleep(15000);
            
            var rv = mConnection.GetRecords(condition);
            //mConsole.Debug("<<-", MessageLevel.System);

            return rv;
        }
    }
}