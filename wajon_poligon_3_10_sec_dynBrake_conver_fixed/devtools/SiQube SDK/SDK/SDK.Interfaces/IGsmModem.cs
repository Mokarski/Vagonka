using System;

namespace SDK.Interfaces
{
    
    public delegate void ExecuteErrorHandler();
    public interface IGsmChannel
    {
        string PortName { get; }

        bool ExecuteRequest(string command, out string[] response, TimeSpan timeout);
        void Close();

        event ExecuteErrorHandler OnExecuteError;

        bool DebugMode { get; set; }
    }

    public interface IGsmHardware : IDisposable
    {
        bool PowerOn();
        void PowerOff();
        void Reset();
        bool IsPowered { get; }

        string Imei { get; }
        string OperatorName { get; }
        byte GprsRegistration { get; }
        int Rssi { get; }
        ITimeData NetworkTime { get; }

        /// <summary>
        ///  Main port for AT and Gprs (PPP) context
        /// </summary>
        IGsmChannel DataPort { get; }

        /// <summary>
        /// Auxiary port for RSSI and user events
        /// </summary>
        IGsmChannel AuxPort { get; }

        void ToCommandMode();
    }

    public interface IGprsSession : IDisposable
    {
        void Connect();
        void Disconnect();
        bool IsConnected { get; }
        DateTime Uptime { get; }
    }

    public interface IGsmModem : ITask
    {
        IGprsSession Session { get; }
        IGsmHardware Hardware { get; }
    }
}
