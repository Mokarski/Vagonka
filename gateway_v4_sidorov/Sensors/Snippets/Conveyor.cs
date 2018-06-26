using System;
using SDK.Common;
using SDK.JournalService;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    internal static class Conveyor
    {
        const int kSpeedCount = 3;

        private static ISignal mSpeed;
        private static ushort mCurrentSpeed = 1;
        private static readonly DelayedTask AcceptCheckout = new DelayedTask(5000);

        private static Cord mCord;
        private static Relay mKv9;
        private static Relay mKv10;
        private static ISignal mState;

        public static event SignalEvent OnError;

        /// <summary>
        /// Готов к запуску, нет ошибок
        /// </summary>
        public static bool IsReady { get { return mCord.IsNormal; } }

        /// <summary>
        /// Активен
        /// </summary>
        /// <returns></returns>
        public static bool IsActive
        {
            get { return mKv10.IsSwitchOn || mKv9.IsSwitchOn; }
        }

        public static bool IsMixMode
        {
            get { return (mCurrentSpeed == kSpeedCount); }
        }

        private static void OnErrorCaller(ISignal sensor)
        {
            var handler = OnError;
            if (handler != null) handler(sensor);

            mState.Update(2);
        }

        public static void Init(IJournal journal, SignalsFactory signals, InvertorsService powers)
        {
            mSpeed = signals.GetSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Speed));
            if (mSpeed == null)
                throw new Exception("bad signal");

            mSpeed.Update(mCurrentSpeed);
            //mSpeed.OnChange += sensor => Console.WriteLine("Conveyor speed: {0}");
            AcceptCheckout.OnTimeout += sender => mSpeed.Update(mCurrentSpeed);

            mCord = new Cord(signals.GetSignal(SensorName.Cord(6)));
            mCord.OnChange += sensor =>
                                  {
                                      if (sensor.Value > 0)
                                      {
                                          //Console.WriteLine("Conveyor: cord F6");
                                          OnErrorCaller(sensor);
                                      }
                                  };

            mKv9 = new Relay(journal, RelayName.Kv9, signals);
            mKv9.OnError += OnErrorCaller;

            mKv10 = new Relay(journal, RelayName.Kv10, signals);
            mKv10.OnError += OnErrorCaller;

            mState = signals.GetSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Status));
        }

        public static void SpeedUp()
        {
            if (mSpeed.Value < kSpeedCount)
                mSpeed.Update(mSpeed.Value + 1);

            AcceptCheckout.Start();
        }

        public static void SpeedDown()
        {
            if (mSpeed.Value > 1)
                mSpeed.Update(mSpeed.Value - 1);

            AcceptCheckout.Start();
        }

        public static void SpeedAccept()
        {
            AcceptCheckout.Stop();
            mCurrentSpeed = (ushort)mSpeed.Value;
        }

        public static void Activate()
        {
            if (IsMixMode)
            {
                mKv9.Off();

                if (!mKv9.IsSwitchOn)
                {
                    mKv10.On();
                    mState.Update(1);
                }
            }
            else
            {
                mKv10.Off();

                if (!mKv10.IsSwitchOn)
                    mKv9.On();

                if (mKv9.IsSwitchOn)
                {
                    Engine.Conveyer(GetSpeed((int) mSpeed.Value));
                    mState.Update(1);
                }
            }
        }

        private static byte GetSpeed(int value)
        {
            switch (value)
            {
                case 1:
                    return 1;

                case 2:
                    return 2;
            }

            return 0;
        }

        public static void Deactivate()
        {
            mKv9.Off();
            mKv10.Off();

            if(mState.ValueAsInt != 2)
                mState.Update(0);
        }

        public static void ResetFault()
        {
            mState.Update(0);
        }
    }
}