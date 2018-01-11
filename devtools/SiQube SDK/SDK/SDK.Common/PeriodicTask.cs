using System;
using System.Threading;
using SDK.Interfaces;

namespace SDK.Common
{
    public class PeriodicTask : ITask
    {
        private readonly Timer mTimer;
        private readonly int mInterval;

        public PeriodicTask(int interval)
        {
            mTimer = new Timer(ProcessTimerEvent, null, Timeout.Infinite, Timeout.Infinite);
            mInterval = interval;
        }

        private void ProcessTimerEvent(object state)
        {
            if (OnPeriod != null)
                OnPeriod();
        }

        public Action OnPeriod;
        private bool mIsStarted;

        public virtual void Start()
        {
            if(!mIsStarted)
                mTimer.Change(0, mInterval);
            
            mIsStarted = true;
        }

        public virtual void Stop()
        {
            mTimer.Change(Timeout.Infinite, Timeout.Infinite);

            mIsStarted = false;
        }
    }
}