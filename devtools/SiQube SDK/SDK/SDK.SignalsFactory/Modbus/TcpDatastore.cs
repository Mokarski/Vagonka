using System.Net;
using System.Net.Sockets;
using System.Threading;
using Modbus.Data;
using Modbus.Device;
using SDK.Interfaces;
using SDK.NetworksServices.Interfaces;

namespace SDK.SignalsFactory.Modbus
{
    public class TcpDatastore : ITask
    {
        private readonly IJournal mJournal;
        private readonly byte mModbusId;
        private readonly int mPort;
        private Thread mProcesingThread;
        private readonly TcpListener mSlaveTcpListener;
        private readonly ModbusTcpSlave mSlave;

        public void Start()
        {
            if (mProcesingThread != null)
                return;

            if (mSlaveTcpListener == null)
                return;

            // create and start the TCP slave           
            mSlaveTcpListener.Start();
            mProcesingThread = new Thread(mSlave.Listen);
            mProcesingThread.Start();

            mJournal.Info(string.Format("Modbus database started at 127.0.0.1:{0}", mPort), MessageLevel.System);
        }

        public void Stop()
        {
            if(mProcesingThread != null)
                mProcesingThread.Abort();

            if(mSlaveTcpListener != null)
                mSlaveTcpListener.Stop();

            mJournal.Info(string.Format("Modbus database stopped at 127.0.0.1:{0}", mPort), MessageLevel.System);
        }

        public TcpDatastore(IJournal journal, DataStore store, byte modbusId, int port)
        {
            mJournal = journal;
            mModbusId = modbusId;
            mPort = port;

            mSlaveTcpListener = new TcpListener(IPAddress.Any, mPort);
            mSlave = ModbusTcpSlave.CreateTcp(mModbusId, mSlaveTcpListener);
            mSlave.DataStore = store;
        }  
    }
}