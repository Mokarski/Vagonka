using System;
using Modbus.Utility;
using SDK.Common;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.ProtoChannel.Interface;

namespace SDK.SignalsFactory
{
    internal class ModbusDescription
    {
        public ModbusDescription(ISignal signal, SignalType type, ushort index, byte bit, bool isReadOnly)
        {
            Signal = signal;
            Type = type;
            Index = index;
            IsReadOnly = isReadOnly;

            Mask = (ushort)(1 << bit);
        }

        public ISignal Signal { get; private set; }
        public ushort Index { get; private set; }
        public ushort Mask { get; private set; }

        public SignalType Type { get; private set; }
        public bool IsReadOnly { get; private set; }

        public ushort[] GetAsModbus()
        {
            switch (Type)
            {
                case SignalType.Bool:
                    return new[] { (ushort)(Signal.IsSet ? Mask : 0) };

                case SignalType.Ushort:
                    return new[] { (ushort)Signal.Value };

                //case SignalType.Uint:
                //    return XpBitConverter.GetUint16(BitConverter.GetBytes((uint)Signal.Value));

                case SignalType.Float:
                    return XpBitConverter.GetUint16(BitConverter.GetBytes(Signal.Value));
            }

            return null;
        }

        public void UpdateAsModbus(ushort[] value)
        {
            switch (Type)
            {
                case SignalType.Bool:
                    Signal.Update((value[0] & Mask) > 0);
                    break;

                case SignalType.Ushort:
                    Signal.Update(value[0]);
                    break;

                //case SignalType.Uint:
                //    Signal.Update(ModbusUtility.GetUInt32(value[0], value[1]));
                //    break;

                case SignalType.Float:
                    Signal.Update(ModbusUtility.GetSingle(value[0], value[1]));
                    break;
            }
        }
    }
}