using System;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    public enum KeyboardCode
    {
        SpeedUp,
        MotionStart,
        SpeedDown,
        MotionStop,
        PumpStart,
        PumpStop,
        SoundAlarm,
        Reserved,
        UserLock,
        ConveyorStop,
        ConveyorDown,
        ConveyorStart,
        ConveyorUp
    }
    
    public static class Keyboard
    {
        private static ushort mState;
        public static void Init(ISignal signal)
        {
            signal.OnChange += sensor =>
                                   {
                                       for (ushort i = 0; i < 13; i++) // 13 buttons  
                                       {
                                           if (((sensor.ValueAsInt >> i) & 0x01) == 1)
                                           {
                                               if (((mState >> i) & 0x01) == 0)
                                               {
                                                   if (OnPress != null)
                                                       OnPress((KeyboardCode)i);
                                               }
                                           }
                                           else
                                           {
                                               if (((mState >> i) & 0x01) == 1)
                                               {
                                                   if (OnRelese != null)
                                                       OnRelese((KeyboardCode)i);
                                               }
                                           }
                                       }

                                       mState = (ushort)sensor.Value;
                                   };
        }

        public static Action<KeyboardCode> OnPress;
        public static Action<KeyboardCode> OnRelese;
    }
}