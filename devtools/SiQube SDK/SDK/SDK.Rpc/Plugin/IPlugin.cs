using System;
using System.Collections;
using Jayrock.Services;

namespace SDK.Interfaces
{
    public delegate void Observe(string topic, string args);
    public delegate void Shutdown();
    public delegate void ListChanged(string[] methods);

    public interface IPlugin : IService
    {
        bool AddService(IService service);

        #region register on proxy server

        void Register(string name);
        void Unregister();

        // auxiary parameters for remote debug puprose only
        string Ip { get; set; }

        #endregion

        #region work with subscribe message

        void Subscribe(string topic);
        void Unsubscribe(string topic);
        void Notify(string topic, string subject);
        void Notify(string topic);

        // for observe mechanism you must call Register() before
        event Observe OnObserve;
        #endregion

        #region json-rpc requests to other daemons
        string JsonInvoke(string method, IDictionary args);
        object Invoke(string method);
        object Invoke(Type returnType, string method);
        object Invoke(string method, IDictionary args);
        object Invoke(Type returnType, string method, IDictionary args);
        #endregion

        event Shutdown OnShutdown;
    }
}
