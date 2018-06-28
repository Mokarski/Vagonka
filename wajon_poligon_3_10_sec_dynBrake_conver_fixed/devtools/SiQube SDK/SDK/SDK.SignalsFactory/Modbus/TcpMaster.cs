using System;
using System.Net.Sockets;
using Modbus.Device;
using SDK.NetworksServices.Interfaces;

namespace SDK.SignalsFactory.Modbus
{
    public class TcpMaster : MasterConnection
    {
        private readonly IJournal mJournal;
        private readonly string mUrl;

        private TcpClient mTcpClient;
        private readonly int mPort;
        
        private bool mIsFirstError = true;

        public TcpMaster(IJournal journal, string url, int port)
        {
            mJournal = journal;
            mUrl = url;
            mPort = port;

            ReadTimeout = 1000;
        }

        public bool Open()
        {
            if (mTcpClient != null)
                return false;
            
            try
            {
                mTcpClient = new TcpClient(mUrl, mPort)
                                 {
                                     Client = {Blocking = true}, 
                                     ReceiveTimeout = ReadTimeout,
                                     SendTimeout = ReadTimeout
                                 };                                 

                if(mConnection != null)
                    mConnection.Dispose();

                mConnection = ModbusIpMaster.CreateIp(mTcpClient);
                //mJournal.Warning("Create connection " + mUrl + ":" + mPort);
                mIsFirstError = true;
                return true;
            }
            catch (ArgumentNullException)
            {
                if (mIsFirstError)
                    if(mJournal != null)
                        mJournal.Error("Не могу уст. соединение с " + mUrl + ":" + mPort + ": ArgumentNullException", MessageLevel.System);

                mTcpClient = null;
                mIsFirstError = false;
            }
            catch (SocketException)
            {
                if (mIsFirstError)
                    if(mJournal != null)
                        mJournal.Error("Не могу уст. соединение с " + mUrl + ":" + mPort + ": SocketException", MessageLevel.System);

                mTcpClient = null;
                mIsFirstError = false;
            }
           
            return false;
        }

        public void Close()
        {            
            try
            {
                
                if(mTcpClient != null)
                    if(mTcpClient.Connected)
                        mTcpClient.Client.Disconnect(false);
                
                mTcpClient = null;

                
                if (mConnection != null)
                {
                    mConnection.Transport.Dispose();
                   
                    mConnection.Dispose();
                    mConnection = null;
                }
            }
            catch (SocketException)
            {
                mTcpClient = null;
            }
        }
    }
}