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
    public class ModemServer : IModemServer
    {
        private Thread mThread;
        private TcpListener mServerListner;

        private readonly Dictionary<string, Modem> mDevices = new Dictionary<string, Modem>();
        private readonly ILog mLogger;


        public ModemServer(ILog logger, ushort port)
        {
            mLogger = logger;
            Port = port;
        }

        public ModemServer(ILog logger)
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

            if (mLogger != null) mLogger.Info("Modem server start at " + Port);
        }

        [DefaultValue(3400)]
        public int Port { get; set; }

        public bool IsActive(string id)
        {
            Modem rv;
            if (mDevices.TryGetValue(id, out rv))
            {
                if (rv.IsActive)
                    return true;

                mDevices.Remove(id);

                if (mLogger != null) mLogger.Debug("Delete connection for modem id: " + id);
                
                return false;
            }

            return false;
        }

        public IModem TryToGet(string id)
        {
            Modem rv;
            mDevices.TryGetValue(id, out rv);
            return rv;
        }

        public ushort[] Invoke(string id, byte slaveId, ushort register, ushort count)
        {
            var modem = TryToGet(id);
            if(modem == null)
                return null;


            return modem.ReadMultipleRegisters(slaveId, register, count);
        }

        public bool Invoke(string id, byte slaveId, ushort register, ushort[] data)
        {
            var modem = TryToGet(id);
            if(modem == null)
                return false;
            
            return modem.WriteMultipleRegisters(slaveId, register, data);
        }

        public void Stop()
        {
            // if we haven't active thread than we don't live :) 
            if (!mThread.IsAlive)
                return;

            mThread.Abort();

            while (mThread.IsAlive) { Thread.Sleep(100); }

            if (mLogger != null) mLogger.Info("Modem server stopped");
        }

        private void ProcessingThread()
        {
            while (true)
            {
                mServerListner.Start();

                try
                {
                    var client = mServerListner.AcceptTcpClient();

                    var device = new Modem();
                    device.Handler(client);
                    if (!device.IsActive) continue;

                    if (mLogger != null) mLogger.Debug("Add new connection for modem id: " + device.Id);

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