using System;
using SDK.Common;

namespace SDK.Prospero.Hardware
{
    internal class LinuxEventParser
    {

        // see http://lxr.linux.no/#linux+v2.6.36/include/linux/input.h

        /// <summary>
        /// Linux input_event types
        /// </summary>
        public enum EventTypes : ushort
        {
            EV_SYN = 0x00,
            EV_KEY = 0x01,
            EV_REL = 0x02,
            EV_ABS = 0x03,
            EV_MSC = 0x04,
            EV_SW = 0x05,
            EV_LED = 0x11,
            EV_SND = 0x12,
            EV_REP = 0x14,
            EV_FF = 0x15,
            EV_PWR = 0x16,
            EV_FF_STATUS = 0x17,
            EV_MAX = 0x1f
        } ;


        /// <summary>
        /// Linux input_event Absolute axes code
        /// </summary>
        public enum CodeTypes : ushort
        {
            ABS_X = 0x00,
            ABS_Y = 0x01,
            ABS_Z = 0x02,
            PRESSURE = 0x18 // 24
        } ;

        public struct Timeval
        {
            public UInt32 seconds;
            public UInt32 microseconds;

            public override string ToString()
            {
                return String.Format("Seconds: {0}, Microseconds: {1}", seconds, microseconds);
            }
        };

        /// The event structure itself  
        public class InputEvent
        {
            public Timeval time;
            public EventTypes type = EventTypes.EV_MAX;
            public CodeTypes code;
            public Int32 value;

            public override string ToString()
            {
                switch (type)
                {
                    case EventTypes.EV_SYN:
                        return String.Format("Time: {0}, EV_SYN\n", time);

                    case EventTypes.EV_ABS:
                        {
                            switch (code)
                            {
                                case CodeTypes.ABS_X:
                                case CodeTypes.ABS_Y:
                                    return String.Format("Time: {0}: {1}, Value: {2}", time,
                                                         Enum.GetName(typeof(CodeTypes), code), value);

                                case CodeTypes.PRESSURE:
                                    return String.Format(value == 1 ? "Time: {0}, PRESS" : "Time: {0}, RELEASE", time);
                            }
                        }
                        break;
                }
                return "Unparse message";
                //return string.Format("Time: {0}, Type: {1}, Code: {2}, Value: {3}", time, Enum.GetName(typeof(EventTypes), type), Enum.GetName(typeof(CodeTypes), code), ((float)value / 64));
            }
        };

        static public InputEvent ParseEvent(byte[] aData)
        {

            if (aData.Length != 16)
                return null;

            return new InputEvent
                       {
                           time =
                               {
                                   seconds = XpBitConverter.ToUint32(aData, 0),
                                   microseconds = XpBitConverter.ToUint32(aData, 4)
                               },
                           type = (EventTypes)XpBitConverter.ToUint16(aData, 8),
                           code = (CodeTypes)XpBitConverter.ToUint16(aData, 10),
                           value = XpBitConverter.ToInt32(aData, 12)
                       };
        }
    }
}