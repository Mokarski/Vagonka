using System;

namespace Journal
{
    public enum MessageType
    {
        Debug,
        Info,
        Warn,
        Error,
        Fatal
    }
    
    // Должен быть таскаемый через proto
    public interface IJournalMessage
    {
        MessageType Type { get; }
        DateTime Time { get; }
        string Message { get; }
    }
}