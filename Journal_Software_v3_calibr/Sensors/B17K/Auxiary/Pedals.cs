using System;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    static public class Pedals
    {
        private static ISignal mForwardDrive;
        private static ISignal mReverseDrive;

        static public void Init(ISignalsFactory signals)
        {
            mForwardDrive = signals.GetSignal(SensorName.Drive(SignalName.Forward));
            if(mForwardDrive == null)
                throw new NullReferenceException(SensorName.Drive(SignalName.Forward));

            mReverseDrive = signals.GetSignal(SensorName.Drive(SignalName.Reverse));
            if (mReverseDrive == null)
                throw new NullReferenceException(SensorName.Drive(SignalName.Reverse));

        }

        /// <summary>
        /// ���� ������� ������ (���� �� ��� ���)
        /// </summary>
        static public bool IsPressed { get { return Forward || Reverse; } }

        /// <summary>
        /// ������ ������ ������
        /// </summary>
        public static bool Forward { get { return mForwardDrive.IsSet; } }

        /// <summary>
        /// ������ ������ �����
        /// </summary>
        public static bool Reverse { get { return mReverseDrive.IsSet; } }

        
        /// <summary>
        /// ������ ���� �� ������� ������
        /// </summary>
        public static bool IsUnlock
        {
            get
            {
                return !(Forward && Reverse) && IsPressed;
            }
        }
    }
}