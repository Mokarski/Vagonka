using System.Threading;
using SDK.Interfaces;

namespace SDK.Common
{
    public class DelayedTask : ITask
    {
        private readonly Timer mTimer;
        private int mInterval;

        public DelayedTask(int interval)
        {
            mTimer = new Timer(ProcessTimerEvent, null, Timeout.Infinite, Timeout.Infinite);
            mInterval = interval;
        }

        public bool IsStart { get; private set; }

        private void ProcessTimerEvent(object state)
        {
            if (OnTimeout != null)
                OnTimeout(this);
        }

        public event TimeoutEvent OnTimeout; 

        public virtual void Start()
        {
            mTimer.Change(mInterval, Timeout.Infinite);
            IsStart = true;
        }

        public virtual void Stop()
        {
            mTimer.Change(Timeout.Infinite, Timeout.Infinite);
            IsStart = false;
        }

        public void SetTimeout(int interval)
        {
            mInterval = interval;
        }

        public int GetTimeout()
        {
            return mInterval;
        }
    }

    public delegate void TimeoutEvent(ITask sender);
}