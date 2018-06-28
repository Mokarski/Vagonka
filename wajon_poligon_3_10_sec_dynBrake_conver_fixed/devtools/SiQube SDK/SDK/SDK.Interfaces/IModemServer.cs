namespace SDK.Interfaces
{
    public interface IModemServer : ITask
    {
        int Port { get; }
        IModem TryToGet(string id);
        ushort[] Invoke(string id, byte slaveId, ushort register, ushort count);
        bool Invoke(string id, byte slaveId, ushort register, ushort[] data);
    }
}