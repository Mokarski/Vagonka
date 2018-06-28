using System;
using System.Net.Sockets;
using System.Threading;
using SDK.NetworksServices.Interfaces;
using SDK.NetworksServices.ProtoBufRemote;
using SDK.NetworksServices.Services.Journal;

namespace SDK.NetworksServices.Client.Journal
{
    public class JournalClient : IJournal, IDisposable
    {
        private readonly string mUrl;
        private static RpcController mRpcController;
        private static RpcClient mRpcClient;
        private static IJournal mJournal;

        private RpcChannel mRpcChannel;
        private TcpClient mTcpClient;
        private readonly Thread mThread;

        public JournalClient(string url)
        {
            mUrl = url;

            if (mRpcController == null)
            {
                mRpcController = new RpcController();
                mRpcClient = new RpcClient(mRpcController, 2500) {ResponseTimeout = TimeSpan.FromMilliseconds(10000)};

                mJournal = mRpcClient.GetProxy<IJournal>();
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
                    }
                };
                mRpcChannel.Start();
            }
            catch (SocketException){}
        }

        public void Debug(string message, MessageLevel level = MessageLevel.User)
        {
            mJournal.Debug(message, level);
        }

        public void Fatal(string message, MessageLevel level = MessageLevel.User)
        {
            mJournal.Fatal(message, level);
        }

        public void Warning(string message, MessageLevel level = MessageLevel.User)
        {
            mJournal.Warning(message, level);
        }

        public void Error(string message, MessageLevel level = MessageLevel.User)
        {
            mJournal.Error(message, level);
        }

        public void Info(string message, MessageLevel level = MessageLevel.User)
        {
            mJournal.Info(message, level);
        } 

        public JournalMessages GetRecords(JournalCondition condition)
        {
            try
            {
                return mJournal.GetRecords(condition);
            }
            catch (InvalidRpcCallException)
            {
                return null;
            }
        }

        public void Dispose()
        {
            if(mThread.IsAlive)
                mThread.Abort();
        }
    }
}