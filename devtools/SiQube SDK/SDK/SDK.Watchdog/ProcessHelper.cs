using System;
using System.Diagnostics;
using System.Threading;

namespace SDK.Watchdog
{
    public class ProcessHelper
    {
        private readonly string mProcessFileName;
        private readonly int mInterval;

        private readonly Thread mWorkThread;
        private volatile bool mShouldStop;
        private const int kMinThreadSleep = 10;
        private DateTime mLastUpdateTime = DateTime.Now;
        private int mProcessId;

        public ProcessHelper(string processFileName, int interval)
        {
            mProcessFileName = processFileName;
            mInterval = (int)TimeSpan.FromSeconds(interval).TotalMilliseconds;

            mWorkThread = new Thread(ProcessTimerEvent) { IsBackground = true };
        }

        private void ProcessTimerEvent()
        {
            while (!mShouldStop)
            {
                if (AbsMillisecondsBetweenNow() > Interval)
                {
                    CheckProcess();
                    mLastUpdateTime = DateTime.Now.AddMilliseconds(Interval);
                }

                Thread.Sleep(kMinThreadSleep);
            }
        }

        private void CheckProcess()
        {
            if (!IsProcessRun())
                RunProcess();
        }

        private void RunProcess()
        {
            var process = Process.Start(mProcessFileName);
            if (process != null) 
                mProcessId = process.Id;
        }

        private bool IsProcessRun()
        {
            var rv = false;
            if(mProcessId > 0)
            {
                try
                {
                    rv = !Process.GetProcessById(mProcessId).HasExited;
                }
                catch (ArgumentException)
                {
                    mProcessId = 0;
                }
            }

            return rv;
        }

        private int Interval
        {
            get { return mInterval; }
        }

        private double AbsMillisecondsBetweenNow()
        {
            return Math.Abs(DateTime.Now.Subtract(mLastUpdateTime).TotalMilliseconds);
        }

        public void Start()
        {
            CheckProcess();

            mLastUpdateTime = DateTime.Now;
            mWorkThread.Start();
        }

        public void Stop()
        {
            mShouldStop = true;
            mWorkThread.Join();
        }
    }
}