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
            // TODO: возвращаем журнал событий с данного времени и глубиной
            // reverse = true - предыдущие от этой даты (более свежие), false - более старые
            return null;
        }

        public void DataIODump(ISensor[] sensors, IOutput[] outputs)
        {
            // TODO: запись в отдельную БД только для данных
            // время, значение датчика, его уникальный id
        }

        public IDataIOState GetState()
        {
            throw new NotImplementedException();
        }
    }
}       