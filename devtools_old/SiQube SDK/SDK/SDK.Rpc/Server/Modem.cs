using System;
using System.Net.Sockets;
using System.Text;
using Modbus.Device;
using Modbus.Utility;
using SDK.Interfaces;


namespace SDK.Rpc.Server
{
    public class Modem : IModem
    {
        public void Dispose()
        {
            Connection.Dispose();           
        }

        public void Handler(TcpClient client)
        {
            try
            {
                Connection = ModbusSerialMaster.CreateRtu(client);
                //mConnection.Transport.Retries = 3;
                Connection.Transport.ReadTimeout = 3000;
                
                var inputs = Connection.ReadInputRegisters(0, 0, 4);
                var id = new byte[8];
                for (var i = 0; i < 4; i++)
                {
                    id[i] = (byte) (inputs[i] & 0xFF);
                    id[i + 1] = (byte) ((inputs[i] >> 8 )& 0xFF);
                }
    
                Id = Encoding.ASCII.GetString(id);
            }
            catch (Exception ex)
            {
                
                // Connection exception
                // No response from server
                // The server maybe close the connection or response timeout
                if(ex.Source.Equals("System"))
                    IsActive = false;

                // The server return error code. You can get the function code and exception code.
                //if(ex.Source.Equals("nModbusPC")) { }
            }

            IsActive = true;
        }

        public bool IsActive { get; private set; }
        public string Id { get; private set; }
        public TimeSpan InvokeGuardtime
        { 
            get { return new TimeSpan(0, 0, 0, 0, Connection.Transport.ReadTimeout); }
            set { Connection.Transport.ReadTimeout = (int) value.TotalMilliseconds; }                
       }

       ModbusMaster Connection { get; set; }

       public float[] ReadFloatValues(byte slaveId, ushort register, int count)
       {
           if (IsActive)
           try
           {
               var numInputs = (ushort)(count * 2);
               var inputs = Connection.ReadInputRegisters(slaveId, register, numInputs);

               var result = new float[count];
               for (var i = 0; i < count; i++)
               {
                   var index = i * 2;
                   result[i] = ModbusUtility.GetSingle(inputs[index + 1], inputs[index]);
               }

               return result;
           }
           catch (Exception ex)
           {

               // Connection exception
               // No response from server
               // The server maybe close the connection or response timeout
               if (ex.Source.Equals("System"))
                   IsActive = false;

               // The server return error code. You can get the function code and exception code.
               //if(ex.Source.Equals("nModbusPC")) { }
           }

           return null;       
       }

       public uint[] ReadUintValues(byte slaveId, ushort register, int count)
       {
           if (IsActive)           
           try
           {
               var numInputs = (ushort)(count * 2);
               var inputs = Connection.ReadInputRegisters(slaveId, register, numInputs);

               var result = new uint[count];
               for (var i = 0; i < count; i++)
               {
                   var index = i * 2;
                   result[i] = ModbusUtility.GetUInt32(inputs[index + 1], inputs[index]);
               }

               return result;                     
           }
           catch (Exception ex)
           {

               // Connection exception
               // No response from server
               // The server maybe close the connection or response timeout
               if (ex.Source.Equals("System"))
                   IsActive = false;

               // The server return error code. You can get the function code and exception code.
               //if(ex.Source.Equals("nModbusPC")) { }
           }

           return null;    
       }

       public bool WriteMultipleRegisters(byte slaveId, ushort register, ushort[] data)
       {
           if (IsActive)
           try
           {
               Connection.WriteMultipleRegisters(slaveId, register, data);

               return true;
           }
           catch (Exception ex)
           {

               // Connection exception
               // No response from server
               // The server maybe close the connection or response timeout
               if (ex.Source.Equals("System"))
                   IsActive = false;

               // The server return error code. You can get the function code and exception code.
               //if(ex.Source.Equals("nModbusPC")) { }
           }

           return false;
       }

        public ushort[] ReadMultipleRegisters(byte slaveId, ushort register, ushort count)
        {
            if (IsActive)
                try
                {
                    return Connection.ReadInputRegisters(slaveId, register, count);

                }
                catch (Exception ex)
                {

                    // Connection exception
                    // No response from server
                    // The server maybe close the connection or response timeout
                    if (ex.Source.Equals("System"))
                        IsActive = false;

                    // The server return error code. You can get the function code and exception code.
                    //if(ex.Source.Equals("nModbusPC")) { }
                }

            return null;
        }
    }
}