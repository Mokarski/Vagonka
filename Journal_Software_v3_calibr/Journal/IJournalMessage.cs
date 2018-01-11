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
    
    // ������ ���� ��������� ����� proto
    public interface IJournalMessage
    {
        MessageType Type { get; }
        DateTime Time { get; }
        string Message { get; }
    }
}