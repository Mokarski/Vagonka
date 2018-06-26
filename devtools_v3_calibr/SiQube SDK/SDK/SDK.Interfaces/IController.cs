using System;
using System.Net.Sockets;

namespace SDK.Interfaces
{
    public interface IController : IDisposable
    {
        /// <summary>
        /// Handler for TcpClient connection for incoming port #10856
        /// </summary>
        /// <param name="client"></param>
        void Handler(TcpClient client);

        /// <summary>
        /// Are IController interface available (connected)?
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Get controller id
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Available rpc methods
        /// </summary>
        string[] Methods { get; }

        /// <summary>
        /// Notify module any topic
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="args"></param>
        /// <returns>true if plugin has "module.observe" method and has "topic" in SubscribeList or false</returns>
        bool Notify(string topic, string args);

        /// <summary>
        /// Timeout for waiting response on Invoke() call
        /// </summary>
        TimeSpan InvokeGuardtime { get; set; }

        /// <summary>
        /// Call json-rpc method
        /// </summary>
        /// <param name="request"></param>
        /// <returns>raw json response</returns>
        string JsonInvoke(IJsonRequest request);

        /// <summary>
        /// Call json-rpc method
        /// </summary>
        /// <param name="returnType"></param>
        /// <param name="request"></param>
        /// <returns>null or object of requested type</returns>
        object Invoke(Type returnType, IJsonRequest request);
    }
}