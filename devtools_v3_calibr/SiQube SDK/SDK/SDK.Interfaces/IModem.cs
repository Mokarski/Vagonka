using System;
using System.Net.Sockets;

namespace SDK.Interfaces
{
    public interface IModem : IDisposable
    {
        /// <summary>
        /// Handler for TcpClient connection
        /// </summary>
        /// <param name="client"></param>
        void Handler(TcpClient client);

        /// <summary>
        /// Are IModem interface available (connected)?
        /// </summary>
        bool IsActive { get; }

        /// <summary>
        /// Get controller id
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Timeout for waiting response on Invoke() call
        /// </summary>
        TimeSpan InvokeGuardtime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slaveId"></param>
        /// <param name="register"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        float[] ReadFloatValues(byte slaveId, ushort register, int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slaveId"></param>
        /// <param name="register"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        uint[] ReadUintValues(byte slaveId, ushort register, int count);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slaveId"></param>
        /// <param name="register"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        bool WriteMultipleRegisters(byte slaveId, ushort register, ushort[] data);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="slaveId"></param>
        /// <param name="register"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        ushort[] ReadMultipleRegisters(byte slaveId, ushort register, ushort count);
    }
}