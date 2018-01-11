using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Jayrock.Json;
using Jayrock.JsonRpc;
using Jayrock.Services;
using SDK.Interfaces;
using SDK.Rpc.Common;
using log4net;

namespace SDK.Rpc.Plugin
{
    
    class RpcModule
    {
        private TcpClient mTcpConnection;
        private TimeSpan mInvokeGuartime;
        
        /// <summary>
        /// Handler for TcpClient connection for incoming port #10856
        /// </summary>
        /// <param name="client"></param>
        public void Handler(TcpClient client)
        {
            SubscribeList = new List<string>();
            mTcpConnection = client;

            InvokeGuardtime = new TimeSpan(0, 0, 5);
            Name = "";
            Methods = new string[] { };


            // get name of rpcModule
            var name = (string)Invoke(typeof(string), new JsonRequest(0, "module.name", null));
            if (name == null)
            {
                mTcpConnection.Close();
                //Console.WriteLine("Unknown connection on rpcModule proxy interface");
                return;
            }

            if (name == "Unknown")
            {
                mTcpConnection.Close();
                //Console.WriteLine("ModuleIntercconnection name cann't be blank");
                return;
            }

            Name = name;

            // get list of available methods
            var methods = (string[])Invoke(typeof(string[]), new JsonRequest(0, "module.methods", null));
            if (methods == null)
            {
                mTcpConnection.Close();
                //Console.WriteLine("Module {0} hasn't any methods and will be disconnected", Name);
                return;
            }

            Methods = methods;
        }

        /// <summary>
        /// Send rpc request to shutdown rpcModule (daemon) (method "rpcModule.shutdown")
        /// </summary>
        public void Shutdown()
        {
            if (IsActive)
                Invoke(typeof(object), new JsonRequest(0, "module.shutdown", null));
        }

        /// <summary>
        /// Are RpcModule interface available (connected)?
        /// </summary>
        public bool IsActive
        {
            get
            {
                try
                {
                    if (mTcpConnection != null && mTcpConnection.Connected)
                    {
                        mTcpConnection.GetStream().WriteByte(0);
                        mTcpConnection.GetStream().Flush();
                    }
                }
                catch (Exception)
                {
                    return false;
                }

                return mTcpConnection != null && mTcpConnection.Connected;
            }
        }

        /// <summary>
        /// Get uniq name of rpcModule
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Available rpc methods
        /// </summary>
        public string[] Methods { get; private set; }


        /// <summary>
        /// Notify rpcModule any topic
        /// </summary>
        /// <param name="topic"></param>
        /// <param name="args"></param>
        /// <returns>true if plugin has "rpcModule.observe" method and has "topic" in SubscribeList or false</returns>
        public bool Notify(string topic, string args)
        {
            if (!IsActive) return false;

            if (SubscribeList.Contains(topic))
            {
                Invoke(typeof(object), new JsonRequest(0, "module.observe", new Dictionary<string, string> { { "topic", topic }, { "args", args } }));
                return true;
            }

            return false;
        }

        /// <summary>
        /// Timeout for waiting response on Invoke() call
        /// </summary>
        public TimeSpan InvokeGuardtime
        {
            get { return mInvokeGuartime; }
            set
            {
                mInvokeGuartime = value;

                try
                {
                    if (mTcpConnection != null)
                        mTcpConnection.ReceiveTimeout = (int)mInvokeGuartime.TotalMilliseconds;
                }
                catch (Exception)
                {
                    mTcpConnection = null;
                }

            }
        }

        /// <summary>
        /// Call json-rpc method
        /// </summary>
        /// <param name="request"></param>
        /// <returns>raw json response</returns>
        public string JsonInvoke(IJsonRequest request)
        {
            if (!IsActive) return null;

            try
            {
                return (string)JsonRpcCaller.Invoke(mTcpConnection.GetStream(),
                                                     typeof(JsonBuffer),
                                                     request);
            }
            catch (Exception)
            {
                Dispose();
                return "{\"id\":" + request.Id + ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Timeout method call\",\"errors\":\"\"}}";
            }
        }


        /// <summary>
        /// Call json-rpc method
        /// </summary>
        /// <param name="returnType"></param>
        /// <param name="request"></param>
        /// <returns>null or object of requested type</returns>
        public object Invoke(Type returnType, IJsonRequest request)
        {
            if (!IsActive) return null;

            try
            {
                return JsonRpcCaller.Invoke(mTcpConnection.GetStream(),
                                             returnType,
                                             request);
            }
            catch (Exception)
            {
                Dispose();
                return null;
            }
        }

        /// <summary>
        /// List of subscribtion. You can add and remove direct
        /// </summary>
        public List<string> SubscribeList { get; private set; }

        public void Dispose()
        {
            if (mTcpConnection != null)
                mTcpConnection.Close();
        }
    }

    class RpcModuleList : IDisposable
    {
        // key - rpcModule name. Used on (un)subscribe / notify
        private readonly ConcurrentDictionary<string, RpcModule> mAvailableModules = new ConcurrentDictionary<string, RpcModule>();

        // key - full name of json-rpc method. Used on Invoke's
        private readonly ConcurrentDictionary<string, RpcModule> mAvailableMethods = new ConcurrentDictionary<string, RpcModule>();

        /// <summary>
        ///  Add name and methods to internal lists
        /// </summary>
        /// <param name="rpcModule">RpcModule instance</param>
        public bool Register(RpcModule rpcModule)
        {
            if (mAvailableModules.TryAdd(rpcModule.Name, rpcModule))
            {
                foreach (var method in rpcModule.Methods)
                {
                    mAvailableMethods.TryAdd(method, rpcModule);
                }
                return true;
            }

            return false;
        }

        /// <summary>
        ///  Remove name and methods from internal lists
        /// </summary>
        /// <param name="name">name of rpcModule</param>
        void Unregister(string name)
        {
            RpcModule rpcModule;

            mAvailableModules.TryRemove(name, out rpcModule);

            if (rpcModule == null) return;

            foreach (var method in rpcModule.Methods)
            {
                RpcModule rv;
                mAvailableMethods.TryRemove(method, out rv);
            }

            // debug
            //Console.WriteLine("Unregistered RpcModule({0})", rpcModule.Name);
            PrintRemoteMethods();

        }

        public RpcModule TryGetByName(string name)
        {
            RpcModule rpcModule;
            mAvailableModules.TryGetValue(name, out rpcModule);

            return rpcModule;
        }

        public RpcModule TryGetByMethod(string method)
        {
            RpcModule rpcModule;
            mAvailableMethods.TryGetValue(method, out rpcModule);

            return rpcModule;
        }

        public string[] Methods()
        {
            return mAvailableMethods.Keys.ToArray();
        }

        /// <summary>
        /// Check connections and unregistered all disconnected modules
        /// </summary>
        public void Checkout()
        {
            foreach (var module in mAvailableModules.Values.Where(module => !module.IsActive))
            {
                Unregister(module.Name);
            }
        }
  
        public void Dispose()
        {
            mAvailableMethods.Clear();

            foreach (var module in mAvailableModules.Values)
            {
                module.Dispose();
            }

            mAvailableModules.Clear();
        }

        public void PrintRemoteMethods()
        {
            // debug purpose only            
            {
                Console.WriteLine("\nList of available remote methods: {0}", Methods().Count());
                foreach (var method in Methods())
                {
                    Console.WriteLine("\t" + method);
                }
            }
        }

        public void Notify(string topic, string args)
        {
            foreach (var module in mAvailableModules.Values.Where(module => module.IsActive))
            {
                module.Notify(topic, args);
            }
        }
    }
    
    [System.ComponentModel.DesignerCategory("")]
    public class ProxyService : IService , IProxy
    {
        private readonly Thread mProcessingThread;
        private Thread mModuleThread;
        private Thread mHandlerThread;

        private readonly ILog mLogger;

        private readonly RpcModuleList mRpcModuleList;
        private readonly ConcurrentDictionary<string, JsonRpcDispatcher> mInternalRpcMethods = new ConcurrentDictionary<string, JsonRpcDispatcher>();

        private readonly object mInvokeLock = new object();
        private readonly TcpListener mModuleListener;
        private readonly TcpListener mHandlerListener;

        private readonly List<RpcHandler> mHandlers = new List<RpcHandler>();

        public ProxyService(ILog logger)
        {
            mLogger = logger;

            mRpcModuleList = new RpcModuleList();

            mModuleListener = new TcpListener(IPAddress.Any, 20856);  // Plugin.InputPort = 20856;
            mHandlerListener = new TcpListener(IPAddress.Any, 20857); // Plugin.OutputPort = 20857;

            mProcessingThread = new Thread(ProcessingThread);

            // register myself as a IService
            AddService(this);
        }

        private void PrintInernalMethods()
        {
            // debug purpose only
            if (mLogger == null) return;

            mLogger.Debug("\nIProxy: list of available internal methods: " + mInternalRpcMethods.Count());
            foreach (var method in mInternalRpcMethods.Keys)
            {
                if(mLogger.IsDebugEnabled)
                    mLogger.Debug("\t" + method);
            }
        }


        /// <summary>
        /// We wait new connection from modules in this thread
        /// </summary>
        private void ModuleThread()
        {
            mModuleListener.Start();

            while (true)
            {
                try
                {
                    var client = mModuleListener.AcceptTcpClient();

                    var module = new RpcModule { InvokeGuardtime = new TimeSpan(0, 0, 5) }; // 5 seconds is default
                    module.Handler(client);

                    // yes, it's correct rpcModule connection
                    if (module.IsActive)
                    {
                        // add rpcModule and methods to list
                        if (mRpcModuleList.Register(module))
                        {
                            if(mLogger != null) 
                                mLogger.Debug("RpcModule(" + module.Name + ") succefully added");

                            // debug
                            if (mLogger != null) 
                                if(mLogger.IsDebugEnabled)
                                    mRpcModuleList.PrintRemoteMethods();
                        }
                        else
                        {
                            if (mLogger != null) 
                                mLogger.Debug("RpcModule(" + module.Name + ") cann't added");

                            module.Dispose();
                        }
                    }

                    Thread.Sleep(200);
                }
                catch (ThreadAbortException)
                {                                       
                    mModuleListener.Stop();

                    throw;
                }
                catch (Exception ex)
                {
                    if (!(ex is SocketException || ex is IOException || ex is InvalidOperationException))
                        if (mLogger != null) 
                            mLogger.Warn("Unexpected exception " + ex.GetType() + " at ModuleThread " + ex.Message);

                }
            }
        }


        /// <summary>
        /// We wait new connection from IRpcHandlers in this thread
        /// </summary>
        private void HandlerThread()
        {
            mHandlerListener.Start();

            while (true)
            {
                try
                {
                    var client = mHandlerListener.AcceptTcpClient();

                    var module = new RpcHandler { RequestGuardtime = new TimeSpan(0, 5, 0) }; // 5 minute is default
                    module.Handler(client);
                    AddHandler(module);

                    if (mLogger != null) 
                        mLogger.Debug("IRpcHandler connection request received");

                    Thread.Sleep(200);
                }
                catch (ThreadAbortException)
                {
                    mHandlerListener.Stop();

                    throw;
                }
                catch (Exception ex)
                {
                    if (!(ex is SocketException || ex is IOException || ex is InvalidOperationException))
                        if (mLogger != null) 
                            mLogger.Warn("Unexpected exception " + ex.GetType() + " at HandlerThread " + ex.Message);

                }
            }
        }

        /// <summary>
        /// General thread of json-rpc request processing
        /// </summary>
        private void ProcessingThread()
        {
            mModuleThread = new Thread(ModuleThread);
            mModuleThread.Start();

            mHandlerThread = new Thread(HandlerThread);
            mHandlerThread.Start();

            while (true)
            {
                try
                {
                    // keep lists of modules/methods actualy
                    mRpcModuleList.Checkout();   
                 
                    // processing incoming requests
                    HandlersCheckout();

                    // update rate is 20 msec
                    Thread.Sleep(20);
                }
                catch (ThreadAbortException)
                {
                    // close additional thread
                    {
                        mModuleThread.Abort();
                        if (mModuleListener != null)
                            mModuleListener.Stop();

                        while (mModuleThread.IsAlive)
                        {
                            Thread.Sleep(100);
                        }
                    }

                    // close additional thread
                    {
                        mHandlerThread.Abort();
                        if (mHandlerListener != null)
                            mHandlerListener.Stop();

                        while (mHandlerThread.IsAlive)
                        {
                            Thread.Sleep(100);
                        }
                    }

                    // close all connection and clear lists
                    mRpcModuleList.Dispose();

                    throw;
                }
                catch (Exception ex)
                {
                    if (!(ex is SocketException || ex is IOException || ex is ObjectDisposedException || ex is InvalidOperationException))
                        if (mLogger != null) 
                            mLogger.Warn("Unexpected exception " + ex.GetType() + " at ModuleThread " + ex.Message);
                }
            }
        }

        public void Start()
        {
            // we started also
            if (mProcessingThread.IsAlive)
                return;

            mProcessingThread.Start();

            if (mLogger != null) 
                mLogger.Info("Proxy running");
        }

        public void Stop()
        {
            // if we haven't thread active than we don't live :) 
            if (!mProcessingThread.IsAlive)
                return;

            mProcessingThread.Abort();

            while (mProcessingThread.IsAlive) { Thread.Sleep(100); }

            if (mLogger != null) 
                mLogger.Info("Proxy stoped");
        }

        public bool AddService(IService service)
        {
            // check duplicate method names
            foreach (var method in service.GetClass().GetMethods())
            {
                if (mInternalRpcMethods.ContainsKey(method.Name))
                    return false;
            }
            
            var dispatcher = new JsonRpcDispatcher(service);
           
            foreach (var method in service.GetClass().GetMethods())
            {
                //if (!method.Name.Contains("system."))
                    mInternalRpcMethods.TryAdd(method.Name, dispatcher);
            }

            if (OnListChanged != null)
                OnListChanged(Methods());

            // debug
            PrintInernalMethods();
            return true;
        }

        public string Invoke(IJsonRequest request)
        {
            if(!mProcessingThread.IsAlive)
                return OnError(request, null);
            
            lock (mInvokeLock)
            {
                // return "error: bad request"
                if (request == null)
                    return OnError(null, null);

                // debug
                //Console.WriteLine(DateTime.Now + "\tProxyService.Invoke({0}, {1}, {2})", request.Id, request.Method, request.Args);

                // Try to get remote rpcModule for this request. If no any rpcModule to this - call InternalProcess()
                var module = mRpcModuleList.TryGetByMethod(request.Method);
                
                var response =  (module != null) ? module.JsonInvoke(request) : InternalProcess(request);
                // debug
                //Console.WriteLine("response: " + response);
                
                return response;
            }
        }

        private string InternalProcess(IJsonRequest request)
        {
            JsonRpcDispatcher dispatcher;
            mInternalRpcMethods.TryGetValue(request.Method, out dispatcher);

            try
            {
                if (dispatcher != null)
                {
                    return dispatcher.Process(request.ToString());
                }
            }
            catch (BadRequestException e)
            {
                return OnError(request, e.ToString());
            }

            return OnError(request, null);
        }

        private static string OnError(IJsonRequest request, string exception)
        {
            if(request != null)
            {                
                if(!string.IsNullOrEmpty(exception))
                    return "{\"id\":" + request.Id + ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Bad request\",\"errors\":\"\"}}";
               
                    return "{\"id\":"+ request.Id + ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Bad request\",\"errors\":\"" + exception + "\"}}";
            }

            return "{\"id\":0,\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Bad request\",\"errors\":\"\"}}";
        }


        #region IService implementation
        private ServiceClass mClass;

        public virtual ServiceClass GetClass()
        {
            return mClass ?? (mClass = JsonRpcServices.GetClassFromType(GetType()));
        }


        [JsonRpcMethod("proxy.subscribe")]//, Idempotent = true)]
        [JsonRpcHelp("your description of proxy.subscribe method here")]
        internal bool Subscribe(string name, string topic)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(topic))
                return false;

            var module = mRpcModuleList.TryGetByName(name);


            if (module == null)
                return false;

            module.SubscribeList.Add(topic);
            return true;
        }

        [JsonRpcMethod("proxy.unsubscribe")]//, Idempotent = true)]
        [JsonRpcHelp("your description of proxy.unsubscribe method here")]
        internal bool Unsubscribe(string name, string topic)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(topic))
                return false;

            var module = mRpcModuleList.TryGetByName(name);


            if (module == null)
                return false;

            return module.SubscribeList.Remove(topic);
        }

        [JsonRpcMethod("proxy.notify")]//, Idempotent = true)]
        [JsonRpcHelp("your description of proxy.notify method here")]
        public bool Notify(string topic, string args)
        {

            if (OnObserve != null)
                OnObserve(topic, args);
            
            mRpcModuleList.Notify(topic, args);

            // accept to invoker that invoke was processed
            return true;
        }

        public event Observe OnObserve;
        public event ListChanged OnListChanged;

        [JsonRpcMethod("proxy.methods")]//, Idempotent = true)]
        public string[] Methods()
        {

                var rv = mInternalRpcMethods.Keys.ToList();
                rv.AddRange(mRpcModuleList.Methods());

                return rv.ToArray();
        }

        #endregion

        #region Outcoming handler methods
        /// <summary>
        ///  Add name and methods to internal lists
        /// </summary>
        /// <param name="handler">IRpcHandler instance</param>
        void AddHandler(RpcHandler handler)
        {
            lock (mHandlers)
            {
                if (handler.IsActive)
                    mHandlers.Add(handler);

                if (OnListChanged != null)
                    OnListChanged(Methods());
            }
        }

        /// <summary>
        ///  Remove name and methods from internal lists
        /// </summary>
        /// <param name="handler">IRpcHandler instance</param>
        void Unregister(RpcHandler handler)
        {
            lock (mHandlers)
                mHandlers.Remove(handler);

            if (OnListChanged != null)
                OnListChanged(Methods());
        }

        /// <summary>
        /// Check connections and unregistered all disconnected modules
        /// </summary>
        void HandlersCheckout()
        {
            lock (mHandlers)
            {
                var enumerator = mHandlers.GetEnumerator();
                do
                {
                    var handler = enumerator.Current;
                    if (handler == null)
                        continue;

                    if (handler.IsActive)
                    {
                        var request = handler.GetRequest();
                        if (request != null)
                        {
                            handler.SendResponse(Invoke(request));
                        }
                    }
                    else
                    {
                        Unregister(handler);
                        enumerator = mHandlers.GetEnumerator();
                    }


                } while (enumerator.MoveNext());
            }
        }
        #endregion

        #region IDisposable
        public void Dispose()
        {

            Stop();

            lock (mHandlers)
            {
                foreach (var handler in mHandlers)
                {
                    handler.Dispose();
                }

                mHandlers.Clear();
            }
        }
        #endregion
    }
}
