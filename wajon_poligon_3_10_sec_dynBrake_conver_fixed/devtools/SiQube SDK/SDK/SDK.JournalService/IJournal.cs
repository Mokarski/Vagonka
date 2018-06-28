using System;

namespace SDK.JournalService
{
    public interface IJournal
    {
        void Fatal(string message);
        void Warning(string message);
        void Error(string message);
        void Info(string message);
        void Debug(string message);

        IJournalMessage GetRecords(DateTime time, byte count, bool reverse);
        
        //void DataIODump(ISignal[] signals);
        //IDataIOState GetState();

    }
    /*
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
    */
}