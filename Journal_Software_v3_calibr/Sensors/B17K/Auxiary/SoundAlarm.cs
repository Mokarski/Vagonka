using System;
using SDK.Common;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    internal static class SoundAlarm
    {
        private static Relay mRelay;

        public static event SignalEvent OnComplete;
        private static DateTime mStopAt;
        private static int mUnlockInterval;

        private static DelayedTask mTask;
        private static ISignal mOnTimeout;
        private static ISignal mOffTimeout;

        private static void ProcessTimerEvent(object caller)
        {
            Off();

            if (OnComplete != null)
                OnComplete(null);
        }

        public static void Init(IJournal journal, ISignalsFactory signals)
        {
            mRelay = new Relay(journal, RelayName.Kv4, signals);

            mOnTimeout =  signals.GetSignal("soundalarm.on.timeout");
            mOnTimeout.OnUpdate += signal =>
                                       {
                                           var rv = signal.ValueAsInt < 1500 ? 1500 : signal.ValueAsInt > 6000 ? 6000 : signal.ValueAsInt;
                                           journal.Debug(string.Format("Таймер вкл. сирены установлен в {0} мс", rv), MessageLevel.System);
                                           mTask.SetTimeout(rv);
                                       };
            
            mOffTimeout =  signals.GetSignal("soundalarm.off.timeout");
            mOffTimeout.OnUpdate += signal =>
                                        {
                                            var rv = signal.ValueAsInt < 2500 ? 2500 : signal.ValueAsInt > 10000 ? 10000 : signal.ValueAsInt;
                                            journal.Debug(string.Format("Таймер выкл. сирены установлен в {0} мс", rv), MessageLevel.System);
                                            mUnlockInterval = rv;
                                        };
                
            // values by default
            mTask = new DelayedTask(mOnTimeout.ValueAsInt); // 1500
            mUnlockInterval = mOffTimeout.ValueAsInt; // 5000

            mTask.OnTimeout += ProcessTimerEvent;
        }

        public static void On()
        {
            mTask.Start();
            mRelay.On();
        }

        public static void Off()
        {
            mRelay.Off();
            mTask.Stop();
            mStopAt = DateTime.Now;
        }

        public static bool IsUnlock
        {
            get
            {
                return DateTime.Now.Subtract(mStopAt).TotalMilliseconds < mUnlockInterval;
            }
        }
    }
}