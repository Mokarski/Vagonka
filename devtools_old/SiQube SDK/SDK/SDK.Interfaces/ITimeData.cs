using System;

namespace SDK.Interfaces
{
    public interface ITimeData
    {
        DateTime LocalTime { get; }
        TimeSpan ZoneOffset { get; }
    }
}