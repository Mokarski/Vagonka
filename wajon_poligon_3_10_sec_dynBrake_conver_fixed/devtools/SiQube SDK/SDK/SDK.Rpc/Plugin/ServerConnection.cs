using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using SDK.Interfaces;
using SDK.Rpc.Common;
using log4net;

namespace SDK.Rpc.Plugin
{
    public class ServerConnection : ITask
    {
        private readonly Thread mThread;
        private readonly ILog mLogger;
        private readonly RpcHandler mRpcHandler;
        private readonly IProxy mProxy;
        private readonly string mHost;
        private readonly int mPort;
        private TimeSpan mRequestGuardtime;
        private bool mProxyUpdated;

        public ServerConnection(ILog logger, IProxy proxy, string host, int port)
        {
            mLogger = logger;
            mProxy = proxy;
            mProxy.OnListChanged += ProxyOnOnListChanged;
            mHost = host;
            mPort = port;
                   
            ReconnectionTimeout = new TimeSpan(0, 0, 10);
            mRequestGuardtime = new TimeSpan(0, 5, 0);

            mThread = new Thread(ProcessingThread);

            mRpcHandler = new RpcHandler();
        }

        private void ProxyOnOnListChanged(string[] methods)
        {
            if (mRpcHandler != null)
                if (mRpcHandler.IsActive)
                {
                    if (mLogger != null) 
                        mLogger.Debug("ProxyOnOnListChanged");

                    mProxyUpdated = true;
                }
        }

        private void ProcessingThread()
        {
            while (true)
            {
                var client = new TcpClient {SendTimeout =  3 * 60 * 1000}; // таймаут на отправку данных на сервер

                try
                {
                    client.Connect(mHost, mPort);

                    if (!client.Connected)
                    {
                        client.Close();
                        continue;
                    }

                    // yahoo, we have connected tcp client
                    mRpcHandler.Handler(client);
                    mRpcHandler.RequestGuardtime = mRequestGuardtime;
                    mProxyUpdated = false;

                    while (mRpcHandler.IsActive && !mProxyUpdated)
                    {
                        // get our request and process here
                        var request = mRpcHandler.GetRequest();
                        if(request != null)
                        {
                            if(mProxy != null)
                                mRpcHandler.SendResponse(mProxy.Invoke(request));
                        }

                        Thread.Sleep(50);
                    }

                    mRpcHandler.Dispose();

                }
                catch (ThreadAbortException)
                {
                    mRpcHandler.Dispose();
                    client.Close();

                    throw;
                }
                catch (Exception ex)
                {
                    if (mLogger != null)
                    {
                        if (!(ex is SocketException || ex is IOException || ex is ObjectDisposedException))
                            mLogger.Warn("Unexpected exception " + ex.GetType() + " at ConnectionThread " + ex.Message);
                        else
                            mLogger.Debug("Expected exception " + ex.GetType() + " at ConnectionThread " + ex.Message);
                    }


                    // timeout for re-connection
                    Thread.Sleep(ReconnectionTimeout); 
                }
            }
        }

        public void Start()
        {
            // we started also
            if (mThread.IsAlive)
                return;

            mThread.Start();

            if (mLogger != null)
                mLogger.Info("ServerConnection running");
        }

        public void Stop()
        {
            // if we haven't active thread than we don't live :) 
            if (!mThread.IsAlive)
                return;

            mThread.Abort();

            while (mThread.IsAlive) { Thread.Sleep(100); }

            if (mLogger != null)
                mLogger.Info("ServerConnection stoped");
        }

        /// <summary>
        /// Статус соединения с сервером
        /// </summary>
        public bool IsConnected { get { return mRpcHandler.IsActive; } }

        /// <summary>
        /// Время ожидания запроса от сервера. При превышении идет отключение от сервера
        /// По умолчанию 5 минут
        /// </summary>
        public TimeSpan RequestGuardtime
        {
            get { return mRequestGuardtime; }
            set { mRequestGuardtime = value; }
        }

        /// <summary>
        /// Время таймаута для переподключения в случае обрыва соединения или невозможности подключится (защита подключения)
        /// По умолчанию 10 секунд
        /// </summary>
        public TimeSpan ReconnectionTimeout { get; set; }
    }
}
