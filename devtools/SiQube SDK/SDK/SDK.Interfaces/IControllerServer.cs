namespace SDK.Interfaces
{
    public interface IControllerServer: ITask
    {
        int Port { get; }
        bool IsActive(string id);
        string Invoke(string id, IJsonRequest request);
        IController TryToGet(string id);
    }
}