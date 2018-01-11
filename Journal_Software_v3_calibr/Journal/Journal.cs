using System;
using SDK.Interfaces.Sensors;
using log4net;

namespace Journal
{
    public class Journal : IJournal
    {
        private readonly ILog mLogger;

        public Journal(ILog logger)
        {
            if(logger == null)
                throw new ArgumentNullException("logger");

            mLogger = logger;
        }

        public void Info(object message)
        {
            //mLogger.Info(message);
        }

        public void Error(object message)
        {
            //mLogger.Error(message);
        }

        public void Warning(object message)
        {
            //mLogger.Warn(message);
        }

        public void Fatal(object message)
        {
            //mLogger.Fatal(message);
        }

        public IJournalMessage GetRecords(DateTime time, byte count, bool reverse)
        {
            // TODO: ���������� ������ ������� � ������� ������� � ��������
            // reverse = true - ���������� �� ���� ���� (����� ������), false - ����� ������
            return null;
        }

        public void DataIODump(ISensor[] sensors, IOutput[] outputs)
        {
            // TODO: ������ � ��������� �� ������ ��� ������
            // �����, �������� �������, ��� ���������� id
        }

        public IDataIOState GetState()
        {
            throw new NotImplementedException();
        }
    }
}       