using System;
using System.IO;
using System.Reflection;
using Modbus.Device;

namespace SDK.SignalsFactory.Modbus
{
    public class MasterConnection
    {
        protected IModbusMaster mConnection;
        private readonly object mConnectionLock = new object();

        public int ReadTimeout { get; set; }

        public bool Write(byte id, ushort address, ushort[] data)
        {
            if (mConnection != null)
                lock (mConnectionLock)
                {
                    try
                    {
                        mConnection.WriteMultipleRegisters(id, address, data);
                        return true;
                    }
                    catch (Exception e)
                    {
                        if (e is FormatException ||
                            e is NotImplementedException ||
                            e is TimeoutException ||
                            e is IOException ||
                            e is NullReferenceException ||
                            e is ObjectDisposedException ||
                            e is TargetInvocationException)
                        {
                            //Console.ForegroundColor = ConsoleColor.Red;
                            //Console.WriteLine("{0}:{1}: write fail", id, address);
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            
                            return false;
                        }

                        throw;
                    }
                }

            return false;
        }

        public ushort[] ReadInputs(byte id, ushort address, byte count)
        {
            if (mConnection != null)
                lock (mConnectionLock)
                {
                    try
                    {
                        return mConnection.ReadInputRegisters(id, address, count);
                    }
                    catch (Exception e)
                    {
                        if (e is FormatException ||
                            e is NotImplementedException ||
                            e is TimeoutException ||
                            e is IOException ||
                            e is NullReferenceException ||
                            e is ObjectDisposedException)
                        {
                            //Console.ForegroundColor = ConsoleColor.Red;
                            //Console.WriteLine("inputs fuck");
                            //Console.ForegroundColor = ConsoleColor.Gray;

                            return null;
                        }
                        
                        throw;
                    }
                }

            return null;
        }

        public ushort[] ReadHoldings(byte id, ushort address, byte count)
        {
            if (mConnection != null)
                lock (mConnectionLock)
                {
                    try
                    {                       
                        return mConnection.ReadHoldingRegisters(id, address, count);
                    }
                    catch (Exception e)
                    {
                        if (e is FormatException ||
                            e is NotImplementedException ||
                            e is TimeoutException ||
                            e is IOException ||
                            e is NullReferenceException ||
                            e is ObjectDisposedException)
                        {
                            //Console.ForegroundColor = ConsoleColor.Red;
                            //Console.WriteLine("holdings fuck");
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            
                            return null;
                        }
                        
                        throw;
                    }
                }

            return null;
        }

        public ushort[] ReadWriteMultipleRegisters(byte id, ushort readAddress, byte count, ushort writeAddress, ushort[] data)
        {
            if (mConnection != null)
                lock (mConnectionLock)
                {
                    try
                    {
                        return mConnection.ReadWriteMultipleRegisters(id, readAddress, count, writeAddress, data);
                    }
                    catch (Exception e)
                    {
                        if (e is FormatException ||
                            e is NotImplementedException ||
                            e is TimeoutException ||
                            e is IOException ||
                            e is NullReferenceException ||
                            e is ObjectDisposedException)
                        {
                            //Console.ForegroundColor = ConsoleColor.Red;
                            //Console.WriteLine("ReadWriteMultipleRegisters fuck");
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            
                            return null;
                        }
                        
                        throw;
                    }
                }

            return null;
        }
    }
}