using System;
using System.Collections.Generic;
using System.Net.Sockets;
using Jayrock.Json;
using SDK.Interfaces;
using SDK.Rpc.Common;

namespace SDK.Rpc.Server
{
    public class Controller : IController
    {
        private TcpClient mTcpConnection;
        private TimeSpan mInvokeGuartime;
        private readonly List<string> mRemoteMethods = new List<string>();
        private readonly object mSyncInvoke = new object();

        public void Handler(TcpClient client)
        {
            mTcpConnection = client;
            InvokeGuardtime = new TimeSpan(0, 0, 30);
            
            Id = "";

            // get name of rpcModule
            var id = RequestId();
            if (string.IsNullOrEmpty(id))
            {
                mTcpConnection.Close();
                return;
            }

            Id = id;

            // get list of available methods
            var methods = RequestMethodsList();
            if (methods == null)
            {
                mTcpConnection.Close();
                return;
            }

            mRemoteMethods.AddRange(methods);            
        }

        public bool IsActive
        {
            get
            {
                // это корректно, но несет затраты по времени и трафику
                /*
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
                */

                return mTcpConnection != null && mTcpConnection.Connected;
            }
        }

        /// <summary>
        /// Get uniq name of rpcModule
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Available rpc methods
        /// </summary>
        public string[] Methods { get { return mRemoteMethods.ToArray(); }}

        /// <summary>
        /// Notify rpcModule any topic
        /// </summary>
        public bool Notify(string topic, string args)
        {
            if (!IsActive) return false;

            JsonInvoke(new JsonRequest(0, "proxy.notify", new Dictionary<string, string> { { "topic", topic }, { "args", args } }));
            return true;
        }

        /// <summary>
        /// Timeout for waiting response on Invoke() call. Default 5 seconds
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
            if (!IsActive)
                return "{\"id\":" + "-" + ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Connection disactive\",\"errors\":\"\"}}";

            if (request == null)
                return "{\"id\":" + "-" + ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"JsonRequest cannot be null\",\"errors\":\"\"}}";

            lock (mSyncInvoke)
            {
                if (mRemoteMethods.Contains(request.Method))
                    try
                    {
                        return (string) JsonRpcCaller.Invoke(mTcpConnection.GetStream(),
                                                             typeof (JsonBuffer),
                                                             request);
                    }
                    catch (Exception)
                    {
                        Dispose();
                        return "{\"id\":" + request.Id +
                               ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Timeout method call\",\"errors\":\"\"}}";
                    }

                return "{\"id\":" + request.Id +
                       ",\"error\":{\"name\":\"JSONRPCError\",\"message\":\"Method unavailable\",\"errors\":\"\"}}";
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

            if (request == null)
                return null;

            lock (mSyncInvoke)
            {
                if (mRemoteMethods.Contains(request.Method))
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

                return null;   
            }
        }

        public void Dispose()
        {
            if (mTcpConnection != null)
                mTcpConnection.Close();
        }



        string RequestId()
        {
            if (!IsActive) return "";


            return (string)JsonRpcCaller.Invoke(mTcpConnection.GetStream(),
                                                    typeof(string),
                                                    new JsonRequest(0, "smart.id", null));
        }

        IEnumerable<string> RequestMethodsList()
        {
            if (!IsActive) return null;


            return (string[]) JsonRpcCaller.Invoke(mTcpConnection.GetStream(),
                                                    typeof(string[]),
                                                    new JsonRequest(0, "proxy.methods", null));
        }


    }
}