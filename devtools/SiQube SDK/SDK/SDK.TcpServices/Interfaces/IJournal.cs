using System;
using System.Collections.Generic;
using ProtoBuf;

namespace SDK.NetworksServices.Interfaces
{
    public interface IJournal
    {
        void Debug(string message, MessageLevel level);
        void Fatal(string message, MessageLevel level);
        void Warning(string message, MessageLevel level);
        void Error(string message, MessageLevel level);
        void Info(string message, MessageLevel level);

        JournalMessages GetRecords(JournalCondition condition);
    }

    [ProtoContract]
    public enum MessageLevel
    {
        User = 0,
        System = 1
    }

    [ProtoContract]
    public enum MessageType
    {
        Debug = 0,
        Info = 1,
        Warning = 2,
        Error = 3,
        Fatal = 4
    }

    [ProtoContract]
    public class JournalMessage
    {
        [ProtoMember(1)]
        public MessageType Type { get; set; }

        [ProtoMember(2)]
        public DateTime Time { get; set; }

        [ProtoMember(3)]
        public string Message { get; set; }

        [ProtoMember(4)]
        public MessageType Level { get; set; }
    }

    [ProtoContract]
    public class JournalMessages
    {
        [ProtoMember(1)]
        public List<JournalMessage> Messages { get; set; }
    }

    [ProtoContract]
    public class JournalCondition
    {
        [ProtoMember(1)]
        public DateTime Time { get; set; }

        [ProtoMember(2)]
        public byte Limit { get; set; }

        [ProtoMember(3)]
        public bool Reverse { get; set; }
    }
}
