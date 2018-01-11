using System;
using Nancy.Hosting.Self;
using SDK.Interfaces;
using log4net;

namespace SDK.RestServer
{
    public class HttpRestServer : ITask
    {
        private readonly NancyHost mNancyHost;
        private readonly ILog mLogger;

        public HttpRestServer(ILog logger, ushort port)
        {
            mLogger = logger;
            Port = port;
            
            var url = "http://localhost:" + Port;
            mNancyHost = new NancyHost(new Uri(url));
        }

        public HttpRestServer(ILog logger)
        {
            mLogger = logger;
            Port = 8080;

            var url = "http://localhost:" + Port;
            mNancyHost = new NancyHost(new Uri(url));
        }

        public ushort Port { get; set; }

        public void Start()
        {
            mNancyHost.Start();
            if(mLogger != null)
                mLogger.Info("HttpRest server start at " + Port);
        }

        public void Stop()
        {
            mNancyHost.Stop();
            if (mLogger != null)
                mLogger.Info("HttpRest server stopped");
        }
    }
}
