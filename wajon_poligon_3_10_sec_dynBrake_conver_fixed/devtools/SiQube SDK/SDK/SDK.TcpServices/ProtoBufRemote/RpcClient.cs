using System;
using System.Collections.Generic;
using System.Threading;
using SDK.Common;

namespace SDK.NetworksServices.ProtoBufRemote
{
    public class RpcClient : IDisposable
    {
        private int mNextId;
        private readonly ProxyBuilder mProxyBuilder = new ProxyBuilder();
        private readonly IDictionary<int, PendingCall> mPendingCalls = new Dictionary<int, PendingCall>();
        private readonly IDictionary<Type, Type> mProxyTypes = new Dictionary<Type, Type>();

        private readonly RpcController mController;

        private readonly PeriodicTask mPing;
        public RpcClient(RpcController controller, int pingPeriod = Timeout.Infinite)
        {
            mController = controller;
            controller.Client = this;

            ResponseTimeout = TimeSpan.MaxValue;
            mPing = new PeriodicTask(pingPeriod)
                        {
                            OnPeriod = () =>
                                           {
                                               if (mController.Channel == null) return;
                                               
                                               if (!mController.Channel.IsReady)
                                               {
                                                   //Console.WriteLine("!isReady");
                                                   return;
                                               }

                                               mController.Send(new RpcMessage {CallMessage = new RpcMessage.Call {Service = ""}});
                                               //Console.WriteLine("{2}: read: {0}, write: {1}", mController.Channel.TotalBytesRead, mController.Channel.TotalBytesWritten, DateTime.Now.ToString("mm:ss.hhh"));
                                           }
                        };

            mPing.Start();
        }

        public TimeSpan ResponseTimeout { get; set; }

        public bool IsReady
        {
            get
            {
                if(mController == null)
                    return false;

                return mController.Channel != null && mController.Channel.IsReady;
            }
        }

        public TService GetProxy<TService>() where TService : class
        {
            Type proxyType;
            if (!mProxyTypes.TryGetValue(typeof(TService), out proxyType))
            {
                proxyType = mProxyBuilder.Build(typeof(TService));
                mProxyTypes.Add(typeof(TService), proxyType);
            }
            return (TService)Activator.CreateInstance(proxyType, this);
        }

        public dynamic GetProxy(string serviceName)
        {
            return new DynamicProxy(this, serviceName);
        }

        internal virtual PendingCall Call(string serviceName, string methodName, object[] args, AsyncCallback callback,
                                          object state)
        {
            RpcMessage.Parameter[] parameters = CreateParameters(args, serviceName, methodName);
            return Call(serviceName, methodName, parameters, callback, state);
        }

        internal virtual PendingCall Call(string serviceName, string methodName, RpcMessage.Parameter[] parameters,
                                          AsyncCallback callback, object state)
        {
            var message = new RpcMessage
                              {
                                  CallMessage = new RpcMessage.Call
                                          {Service = serviceName, Method = methodName, ExpectsResult = true}
                              };
            if (parameters != null)
            {
                foreach (var param in parameters)
                    message.CallMessage.Parameters.Add(param);
            }

            PendingCall pendingCall;

            lock (mPendingCalls)
            {
                int id = GetFreeId();
                message.Id = id;
                pendingCall = new PendingCall(id, serviceName, methodName, callback, state);
                mPendingCalls.Add(id, pendingCall);
            }

            //channel send is thread-safe already
            mController.Send(message);

            return pendingCall;
        }

        internal virtual void CallWithoutResult(string serviceName, string methodName, object[] args)
        {
            CallWithoutResult(serviceName, methodName, CreateParameters(args, serviceName, methodName));
        }

        internal virtual void CallWithoutResult(string serviceName, string methodName,
                                                RpcMessage.Parameter[] parameters)
        {
            var message = new RpcMessage
                              {
                                  CallMessage = new RpcMessage.Call
                                          {Service = serviceName, Method = methodName, ExpectsResult = false}
                              };
            if (parameters != null)
            {
                foreach (var param in parameters)
                    message.CallMessage.Parameters.Add(param);
            }

            //channel send is thread-safe already
            mController.Send(message);
        }

        internal virtual void ReceiveResult(RpcMessage message)
        {
            // TODO: есть проблема с многопоточностью - если несколько потоков пытаются получить обмен
            //Console.WriteLine("ReceiveResult: {0}", message.Id);
            //if (mPendingCalls.ContainsKey(message.Id))
            {
                PendingCall pendingCall = mPendingCalls[message.Id];
                mPendingCalls.Remove(message.Id);
                pendingCall.ReceiveResult(message.ResultMessage);                
            }            
        }

        private int GetFreeId()
        {
            return mNextId++;
        }

        private static RpcMessage.Parameter[] CreateParameters(object[] args, string service, string method)
        {
            RpcMessage.Parameter[] parameters = new RpcMessage.Parameter[args.Length];
            for (int i = 0; i < args.Length; ++i)
            {
                string errorMsg;
                if (!ParameterConverter.ToMessage(args[i], out parameters[i], out errorMsg))
                {
                    throw new InvalidRpcCallException(service, method,
                        String.Format("Couldn't use parameter in rpc call ({0}).", errorMsg));

                }
            }
            return parameters;
        }

        public void Dispose()
        {
            //mPing.Stop();
        }
    }
}
