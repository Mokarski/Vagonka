using System;
using Jayrock.Services;

namespace SDK.Interfaces
{
    public interface IProxy : IDisposable, ITask
    {
        /// <summary>
        /// Register local IService
        /// </summary>
        /// <param name="service"></param>
        bool AddService(IService service);

        /// <summary>
        /// Do json-rpc
        /// </summary>
        /// <param name="request"></param>
        /// <returns>raw json response</returns>
        string Invoke(IJsonRequest request);

        bool Notify(string topic, string args);
        event Observe OnObserve;
        event ListChanged OnListChanged;

        string[] Methods();
    }
}
