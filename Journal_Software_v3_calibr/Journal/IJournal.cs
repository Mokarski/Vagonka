using System;
using SDK.Interfaces.Sensors;

namespace Journal
{
    public interface IJournal
    {
        void Fatal(object message);
        void Warning(object message);
        void Error(object message);
        void Info(object message);
        IJournalMessage GetRecords(DateTime time, byte count, bool reverse);
        void DataIODump(ISensor[] sensors, IOutput[] outputs);

        IDataIOState GetState();
    }

    public interface IDataIOState
    {
        DateTime Time { get; }
        SensorState[] Sensors { get; }
    }

    public class SensorState
    {
        public string Id { get; set; }
        public ushort Value { get; set; }
    }
}