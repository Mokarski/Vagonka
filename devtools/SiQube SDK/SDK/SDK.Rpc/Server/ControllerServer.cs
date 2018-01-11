using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SDK.Interfaces;
using log4net;

namespace SDK.Rpc.Server
{
    
    public class ControllerServer : IControllerServer
    {
        private Thread mThread;
        private TcpListener mServerListner;

        private readonly Dictionary<string, Controller> mDevices = new Dictionary<string, Controller>();
        private readonly ILog mLogger;


        public ControllerServer(ILog logger, ushort port)
        {
            mLogger = logger;
            Port = port;
        }

        public ControllerServer(ILog logger)
        {
            mLogger = logger;
        }

        public void Start()
        {
            if (mThread == null)
                mThread = new Thread(ProcessingThread);

            // we started also
            if (mThread.IsAlive)
                return;

            mServerListner = new TcpListener(IPAddress.Any, Port);

            mThread.Start();

            if (mLogger != null) mLogger.Info("Controller server start at " + Port);
        }

        [DefaultValue(3300)]
        public int Port { get; set; }

        public bool IsActive(string id)
        {
            Controller rv;
            if (mDevices.TryGetValue(id, out rv))
            {
                if (rv.IsActive)
                    return true;

                mDevices.Remove(id);
                
                if (mLogger != null) mLogger.Debug("Delete connection for controller id: " + id);

                return false;
            }

            return false;
        }

        public string Invoke(string id, IJsonRequest request)
        {
            Controller rv;
            mDevices.TryGetValue(id, out rv);

            return rv != null ? rv.JsonInvoke(request) : null;
        }

        public IController TryToGet(string id)
        {
            Controller rv;
            mDevices.TryGetValue(id, out rv);
            return rv;
        }

        public void Stop()
        {
            // if we haven't active thread than we don't live :) 
            if (!mThread.IsAlive)
                return;

            mThread.Abort();

            while (mThread.IsAlive) { Thread.Sleep(100); }

            if (mLogger != null) mLogger.Info("Controller server stopped");
        }

        private void ProcessingThread()
        {
            while (true)
            {
                mServerListner.Start();

                try
                {
                    var client = mServerListner.AcceptTcpClient();

                    var device = new Controller();
                    device.Handler(client);
                    if (!device.IsActive) continue;

                    if (mLogger != null) mLogger.Debug("Add new connection for controller id: " + device.Id);
                    
                    // update connections list
                    mDevices.Remove(device.Id);
                    mDevices.Add(device.Id, device);
                }
                catch (ThreadAbortException)
                {
                    mServerListner.Stop();
                    throw;
                }
                catch (Exception ex)
                {
                    mServerListner.Stop();
                    if (mLogger != null) mLogger.Error(ex);
                }
            }
        }
    }
     
}