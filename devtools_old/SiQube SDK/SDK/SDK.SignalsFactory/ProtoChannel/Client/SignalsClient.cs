using System;
using System.Net.Sockets;
using System.Threading;
using SDK.NetworksServices.ProtoBufRemote;
using SDK.SignalsFactory.ProtoChannel.Interface;

namespace SDK.SignalsFactory.ProtoChannel.Client
{
    internal class SignalsClient : ISignalsClient, IDisposable
    {
        private readonly string mUrl;
        private static RpcController mRpcController;
        private static RpcClient mRpcClient;
        private static ISignalsClient mSignalsClient;

        private RpcChannel mRpcChannel;
        private TcpClient mTcpClient;
        private readonly Thread mThread;

        public SignalsClient(string url)
        {
            mUrl = url;

            if (mRpcController == null)
            {
                mRpcController = new RpcController();
                mRpcClient = new RpcClient(mRpcController, 2500) {ResponseTimeout = TimeSpan.FromMilliseconds(10000)};

                mSignalsClient = mRpcClient.GetProxy<ISignalsClient>();
            }

            mThread = new Thread(ChannelChecker);
            mThread.Start();
        }

        private void ChannelChecker()
        {
            while (true)
            {
                try
                {
                    IsChannelReady();
                    Thread.Sleep(1000);
                }
                catch (ThreadAbortException)
                {
                    mRpcChannel.Stop();
                    mRpcClient.Dispose();
                }
            }
        }

        private void IsChannelReady()
        {
            if (mRpcController.Channel != null && mRpcController.Channel.IsReady)
                return;

            try
            {
                mTcpClient = new TcpClient(mUrl, Settings.Port) {SendTimeout = 3000};

                mRpcChannel = new TcpClientRpcChannel(mRpcController, mTcpClient, Timeout.Infinite)//, "client")
                {
                    OnError = () =>
                    {
                        Console.WriteLine("-- client fuck");
                        if (mTcpClient != null)
                        {
                            mTcpClient.Close();
                        }

                        if(OnError != null)
                            OnError();
                    }
                };
                mRpcChannel.Start();
            }
            catch (SocketException){}
        }

        /// <summary>
        /// нет св€зи при работе с сервером
        /// </summary>
        public Action OnError;

        public void Dispose()
        {
            if(mThread.IsAlive)
                mThread.Abort();
        }

        /// <summary>
        /// ѕолучить статус сигналов
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public SignalsResponse GetStatus(SignalsRequest ids)
        {
            try
            {
                return mSignalsClient.GetStatus(ids);
            }
            catch (InvalidRpcCallException)
            {
                return null;
            }
        }

        /// <summary>
        /// ѕолучить спецификации доступных сигналов
        /// </summary>
        /// <returns></returns>
        public SignalSpecificationResponse GetSignals()
        {
            try
            {
                return mSignalsClient.GetSignals();
            }
            catch (InvalidRpcCallException)
            {
                return null;
            }
        }

        /// <summary>
        /// ”становить новое значение дл€ удаленного сигнала
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Update(string id, float value)
        {
            try
            {
                return mSignalsClient.Update(id, value);
            }
            catch (InvalidRpcCallException)
            {
                return false;
            }
        }

        public ConfigSectionsResponse GetConfig()
        {
            try
            {
                return mSignalsClient.GetConfig();
            }
            catch (InvalidRpcCallException)
            {
                return null;
            }
        }
    }
}