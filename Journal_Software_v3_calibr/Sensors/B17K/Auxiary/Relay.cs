using SDK.Common;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    internal class Relay
    {
        private readonly ISignal mOutput;
        private readonly ISignal mFeedback;

        private readonly DelayedTask mTask;
        private static ISignal mOnTimeout;
        private readonly IJournal mJournal;

        public event SignalEvent OnError;

        public Relay(IJournal journal, RelayName name, ISignalsFactory signals)
        {
            mJournal = journal;
            mOutput = signals.GetSignal(SensorName.Relay(name));

            // TODO: uncomment
            mFeedback = signals.GetSignal(SensorName.Relay(name, SignalName.Feedback));
            
            if (mFeedback != null)
                mFeedback.OnChange += FeedbackOnChange;

            if(mOnTimeout == null)
            {
                mOnTimeout = signals.GetSignal("relay.feedback.on.timeout");
            }

            if(mFeedback != null)
            {
                mOnTimeout.OnUpdate += signal =>
                {
                    var rv = signal.ValueAsInt < 1500 ? 1500 : signal.ValueAsInt > 6000 ? 6000 : signal.ValueAsInt;
                    mJournal.Debug(string.Format("������ ���� (��) ���������� � {0} �� ��� {1}", rv, mOutput.Specification.Id), MessageLevel.System);
                    mTask.SetTimeout(rv);
                }; 
            }

            // �������� �� �������� �������� ����� �� ���������� �� ���������
            mTask = new DelayedTask(mOnTimeout == null ? 3000 : mOnTimeout.ValueAsInt < 1500 ? 1500 : mOnTimeout.ValueAsInt > 6000 ? 6000 : mOnTimeout.ValueAsInt); 
            mTask.OnTimeout += Checkout;
        }

        private void FeedbackOnChange(IReadonlySignal signal)
        {
            //Checkout(this);
            mTask.Start();
        }

        private void Checkout(object sender)
        {
            mTask.Stop();

            if (mFeedback == null)
                return;

            if (mOutput.IsSet)
            {
                if (!IsSwitchOn)
                {
                    Off();

                    // ��� ��������� ���������
                    if (OnError != null)
                        OnError(mFeedback);
                }
            }
            else
            {
                if (IsSwitchOn)
                {
                    // ��� ��������� ����������

                    //Off();

                    // TODO: �������� ����� �� ���������� - ����������, �� ������ �������� ����� ��� ����
                    //if (OnError != null)
                    //    OnError(mFeedback, new SensorEventArgs { Code = (ushort)RelayErrorCode.NoRealOff });
                }
            }
        }

        public void On()
        {
            if (!mOutput.IsSet)
                mJournal.Debug(string.Format("���� (��) {0} ���.", mOutput.Specification.Id), MessageLevel.System);

            mTask.Start();
            mOutput.Update(true);
        }

        public void Off()
        {
            if (mOutput.IsSet)
                mJournal.Debug(string.Format("relay (��) {0} ����.", mOutput.Specification.Id), MessageLevel.System);

            mTask.Start();
            mOutput.Update(false);
        }

        public bool IsSwitchOn
        {
            get
            {
                return mFeedback == null ? mOutput.IsSet : mFeedback.IsSet;
            }
        }
    }
}