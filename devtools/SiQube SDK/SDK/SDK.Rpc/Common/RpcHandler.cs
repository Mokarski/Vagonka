using System;
using System.Net.Sockets;
using System.Timers;

namespace SDK.Rpc.Common
{
    internal class RpcHandler
    {
        private TcpClient mTcpConnection;
        private Streamer mStreamer;
        private TimeSpan mRequestGuardtime;
        private readonly Timer mTimer;

        public RpcHandler()
        {
            mTimer = new Timer();
            mTimer.Elapsed += OnTimedEvent;

            RequestGuardtime = new TimeSpan(0, 5, 0);
        }

        /// <summary>
        /// Handler for TcpClient connection for incoming data
        /// </summary>
        /// <param name="client"></param>
        public void Handler(TcpClient client)
        {
            mTcpConnection = client;
            mStreamer = new Streamer(mTcpConnection.GetStream());
            mTcpConnection.Client.Blocking = false; // for this type of connection we MUST have unblocking read GetRequest
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Are connection available
        /// </summary>
        /// <returns>if false, you can don't track this interface</returns>
        public bool IsActive
        {
            get
            {
                return mTcpConnection != null && mTcpConnection.Connected;
            }
        }

        /// <summary>
        /// How much time we can wait new request
        /// If we don't receive any request in RequestGuardtime - we do Dispose(). ModuleInterface can up new connection on Invoke()
        /// </summary>
        public TimeSpan RequestGuardtime
        {
            get { return mRequestGuardtime; }
            set
            {
                mRequestGuardtime = value;

                RestartTimer();
            }
        }

        private void RestartTimer()
        {
            mTimer.Stop();
            mTimer.Interval = mRequestGuardtime.TotalMilliseconds;
            mTimer.Enabled = true;
            mTimer.Start();
        }

        /// <summary>
        /// Get new request from interface
        /// </summary>
        /// <returns>null if hasn't new request or get one new JsonRequest</returns>
        public JsonRequest GetRequest()
        {
            if (!IsActive) return null;

            try
            {            
                var request = mStreamer.ReadLine(new TimeSpan(0, 0, 0, 0, 500)); // wait nothing
                if(!string.IsNullOrEmpty(request))
                {
                    RestartTimer();
                    return new JsonRequest(request);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return null;
        }

        /// <summary>
        /// Send response for json-rpc request, getting from GetRequet() method
        /// </summary>
        /// <param name="response"></param>
        public void SendResponse(string response)
        {
            if(IsActive)
                mStreamer.WriteLine(response);
        }

        public void Dispose()
        {
            if (mTcpConnection != null)
                mTcpConnection.Close();
            
            if (mStreamer != null)
                mStreamer.Dispose();
        }
    }
}