using System;
using System.IO;
using System.IO.Ports;
using Modbus.Device;
using SDK.NetworksServices.Interfaces;

namespace SDK.SignalsFactory.Modbus
{
    public class RS485Master : MasterConnection
    {
        private readonly IJournal mJournal;

        private SerialPort mPort;
        private readonly string mPortName;

        private readonly int mBaudrate;
        private readonly bool mIsRtu;

        private bool mIsFirstError = true;

        public RS485Master(IJournal journal, string portName, int baudrate, bool isRtu)
        {
            mJournal = journal;
            mPortName = portName;
            mBaudrate = baudrate;
            mIsRtu = isRtu;

            ReadTimeout = 100;
            Retries = 0; // was 1

        }

        public int Retries { get; private set; }

        public bool Open()
        {
            if (mPort != null)
                return false;

            try
            {
                mPort = new SerialPort(mPortName, mBaudrate, Parity.None, 8, StopBits.One) { ReadTimeout = ReadTimeout };
                mPort.Open();

                if (mPort.IsOpen)
                {
                    mConnection = mIsRtu ? ModbusSerialMaster.CreateRtu(mPort) : ModbusSerialMaster.CreateAscii(mPort);
                    mConnection.Transport.Retries = Retries; // 0,  was 1
                    mConnection.Transport.ReadTimeout = ReadTimeout;

                    mIsFirstError = true;
                    return true;
                }
            }
            catch (IOException)
            {
                if(mIsFirstError)
                    mJournal.Error("Не могу открыть посл. порт " + mPortName, MessageLevel.System);

                if (mPort != null)
                    if (mPort.IsOpen)
                        mPort.Close();

                mPort = null;
                mIsFirstError = false;
            }
            catch (ArgumentException)
            {
                if (mIsFirstError)
                    mJournal.Error("Не могу открыть посл. порт " + mPortName, MessageLevel.System);

                if (mPort != null)
                    if (mPort.IsOpen)
                        mPort.Close();

                mPort = null;
                mIsFirstError = false;
            }
            catch (UnauthorizedAccessException)
            {
                if (mIsFirstError)                
                    mJournal.Error("Не хватает прав для записи в посл. порт " + mPortName, MessageLevel.System);
                
                if(mPort != null)
                    if(mPort.IsOpen)
                        mPort.Close();

                mPort = null;
                mIsFirstError = false;
            }
            catch (NullReferenceException)
            {
                if (mIsFirstError)                
                    mJournal.Error("Не указано имя посл. порта", MessageLevel.System);

                if (mPort != null)
                    if (mPort.IsOpen)
                        mPort.Close();

                mPort = null;
                mIsFirstError = false;
            }

            return false;
        }

        public bool IsOpen()
        {
            return mPort != null && mPort.IsOpen;
        }

        public void Close()
        {
            try
            {
                if (mConnection != null)
                {
                    mConnection.Dispose();
                    mConnection = null;
                }

                if (mPort.IsOpen)
                    mPort.Close();

                mPort.Dispose();
                mPort = null;
            }
            catch (IOException)
            {
                mPort = null;
            }
            catch (NullReferenceException)
            {
            }
        }
    }
}