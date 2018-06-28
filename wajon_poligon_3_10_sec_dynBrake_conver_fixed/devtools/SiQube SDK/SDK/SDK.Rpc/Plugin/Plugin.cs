using System;
using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using Jayrock.Json;
using Jayrock.Json.Conversion;
using Jayrock.JsonRpc;
using Jayrock.Services;
using SDK.Interfaces;
using SDK.Rpc.Common;


namespace SDK.Rpc.Plugin
{
    [System.ComponentModel.DesignerCategory("")]
    public class Plugin : IPlugin
    {
        #region private members

        // plugin name
        private string mPluginName = "Unknown";

        // list of json service dispatchers
        private readonly IDictionary<string, JsonRpcDispatcher> mRpcMethods = new Dictionary<string, JsonRpcDispatcher>();

        // connection to proxy daemon
        private TcpClient mJsonClientConnection;

        // thread for internal JsonRpcService implementation
        private readonly Thread mProcessHandler;
        private uint mIdRequest;

        #endregion

        #region public interface

        public Plugin()
        {
            Ip = "127.0.0.1";
            InputPort = 20856;
            OutputPort = 20857;

            AddService(this);

            mProcessHandler = new Thread(ProcessHandler);
        }

        public event Observe OnObserve;
        public event Shutdown OnShutdown;

        public string Ip { get; set; }
        public int InputPort { get; set; }
        public int OutputPort { get; set; }

        #region general service methods

        private ServiceClass mClass;
        public ServiceClass GetClass()
        {
            return mClass ?? (mClass = JsonRpcServices.GetClassFromType(GetType()));
        }
        
        /// <summary>
        /// Добавить json сервис в обработчик
        /// </summary>
        /// <param name="aService"></param>
        /// <returns></returns>
        public bool AddService(IService aService)
        {
            // check duplicate method names
            foreach (var method in aService.GetClass().GetMethods())
            {
                if (mRpcMethods.ContainsKey(method.Name))
                    return false;
            }

            var dispatcher = new JsonRpcDispatcher(aService);
            foreach (var method in aService.GetClass().GetMethods())
            {
                mRpcMethods.Add(method.Name, dispatcher);
            }

            //Debug.WriteLine(aService.GetClass() + " succefully registered");
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Register(string name)
        {
            mPluginName = name;

            // start input processing thread
            if (mProcessHandler.IsAlive) return;

            mProcessHandler.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            mProcessHandler.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Unregister()
        {
            // try to close output port
            if (mJsonClientConnection != null)
            {
                mJsonClientConnection.Close();
                mJsonClientConnection = null;
            }

            // abort input processing thread
            if (!mProcessHandler.IsAlive) return;

            mProcessHandler.Abort();
        }
        #endregion

        #region plugin basic json interface

        [JsonRpcMethod("module.name")]
        public string JsonGetName()
        {
            return mPluginName;
        }

        [JsonRpcMethod("module.observe")]
        public void JsonObserve(string topic, string args)
        {
            if (OnObserve != null)
                OnObserve(topic, args);
        }

        [JsonRpcMethod("module.shutdown")]
        public void JsonShutdown()
        {
            if (OnShutdown != null)
                OnShutdown();
        }


        [JsonRpcMethod("module.methods")]
        public string[] ListMethods()
        {
            // методы описывающие процесс в список не попадают и остаются скрытыми, так как могут повторятся у разных модулей
           return mRpcMethods.Keys.Where(method => !method.Contains("module.")).ToArray();
           //return mRpcMethods.Keys.Where(method => !method.Contains("module.") && !method.Contains("observe") && !method.Contains("name")).ToArray();
        }
        #endregion

        #endregion

        #region InputJsonConnection

        /// <summary>
        /// Обработчик json запросов
        /// </summary>
        /// <param name="request">json-rpc запрос</param>
        /// <returns>json-rpc ответ</returns>
        private string Process(string request)
        {
            if (request == null)
                throw new ArgumentNullException("request");
            if (request.Length == 0)
                throw new ArgumentException("request");

            try
            {
                JsonRpcDispatcher dispatcher;
                if (mRpcMethods.TryGetValue(new JsonRequest(request).Method, out dispatcher))
                    return dispatcher.Process(request);


                return "{\"id\":0,\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Bad request\",\"errors\":\"\"}}";
            }
            catch (Exception ex)
            {
                //Debug.WriteLine("Plugin.Process() unknown json request: " + ex);

                return "{\"id\":0,\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Bad request\",\"errors\":\"" + ex + "\"}}";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        void ProcessHandler()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            TcpClient client = null;

            while (true)
            {
                try
                {
                    client = new TcpClient();
                    client.Connect(Ip, InputPort);

                    var streamer = new Streamer(client.GetStream());

                    while (client.Connected)
                    {
                        streamer.WriteLine(Process(streamer.ReadLine(TimeSpan.MaxValue)));
                    }

                    //Debug.WriteLine("server disconnected");

                    streamer.Dispose();
                    client.Close();
                    client = null;
                }
                catch (Exception ex)
                {

                    if (ex is ThreadAbortException)
                        throw;

                    if (client != null)
                        client.Close();

                    client = null;
                }
            }
        }

        #endregion

        #region OutputJsonConnection

        public void Subscribe(string topic)
        {
            Invoke(AnyType.Value,
                "proxy.subscribe",
                new Dictionary<string, string> { { "name", mPluginName }, { "topic", topic } });
        }

        public void Unsubscribe(string topic)
        {
            Invoke(AnyType.Value,
                "proxy.unsubscribe",
                new Dictionary<string, string> { { "name", mPluginName }, { "topic", topic } });
        }

        public void Notify(string topic, string subject)
        {
            Invoke(AnyType.Value,
                "proxy.notify",
                new Dictionary<string, string> { { "topic", topic }, { "args", subject } });
        }

        public void Notify(string topic)
        {
            Notify(topic, null);
        }

        public string JsonInvoke(string method, IDictionary args)
        {
            return Invoke(typeof(JsonBuffer), method, args).ToString();
        }

        public object Invoke(string method)
        {
            return Invoke(AnyType.Value, method);
        }

        public object Invoke(Type returnType, string method)
        {
            return Invoke(returnType, method, null);
        }

        public object Invoke(string method, IDictionary args)
        {
            return Invoke(AnyType.Value, method, args);
        }

        public object Invoke(Type returnType, string method, IDictionary args)
        {
            try
            {
                JsonRpcDispatcher internalDispatcher;
                if (mRpcMethods.TryGetValue(method, out internalDispatcher))
                {
                    // internal method
                    return (new ResponseParser(internalDispatcher.Process((new JsonRequest(0, method, args)).ToString()), returnType)).Result();
                }
                
                // Heardbeat test
                // try to get updated state of connection. It's hack
                try
                {
                    var timeout = GetJsonRpc().WriteTimeout;
                    GetJsonRpc().WriteTimeout = 2;

                    GetJsonRpc().WriteByte(0);
                    GetJsonRpc().WriteByte(0);
                    GetJsonRpc().WriteByte(0);
                    GetJsonRpc().WriteByte(0);
                    GetJsonRpc().WriteByte(0);
                    
                    Thread.Sleep(5);
                    GetJsonRpc().WriteTimeout = timeout;
                }
                catch(IOException)
                {
                    //Debug.WriteLine("remote server connection test");
                }


                // external method
                return JsonRpcCaller.Invoke(GetJsonRpc(),
                                             returnType,
                                             (++mIdRequest), method, args);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Stream GetJsonRpc()
        {
            try
            {
                if (mJsonClientConnection == null)
                {
                    mJsonClientConnection = new TcpClient();
                    mJsonClientConnection.Connect(Ip, OutputPort);
                    return mJsonClientConnection.Connected ? mJsonClientConnection.GetStream() : null;
                }

                
                if (mJsonClientConnection.Connected)
                {
                    return mJsonClientConnection.GetStream();
                }

                // disconnected by remote server
                // close and reopen
                mJsonClientConnection.Close();
                mJsonClientConnection = null;

                mJsonClientConnection = new TcpClient();
                mJsonClientConnection.Connect(Ip, OutputPort);
                return mJsonClientConnection.Connected ? mJsonClientConnection.GetStream() : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
    }
}

