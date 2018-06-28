using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    internal class Cord
    {
        private readonly ISignal mCord;

        public Cord(ISignal cord)
        {
            mCord = cord;
            mCord.OnChange += signal =>
            {
                if (OnChange != null)
                    OnChange(signal);
            };
        }

        public event SignalEvent OnChange;

        public bool IsNormal
        {
            get { return !mCord.IsSet; }
        }
    }
}