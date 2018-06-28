using System;
using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory
{
    internal class ReadolnySignal : IReadonlySignal
    {
        public ReadolnySignal(SignalSpecification spec)
        {
            Specification = spec;
            QtSpecification = new QtSignalSpecification();
        }

        public ReadolnySignal(string id)
        {
            Specification = new SignalSpecification(id, "").SaveAsFloat(0);
            QtSpecification = new QtSignalSpecification();
        }

        public void UpdateSpecification(SignalSpecification spec)
        {
            if (Specification.Id == spec.Id)
                Specification = spec;
        }

        public void Update(SignalStatus status)
        {
            LastUpdate = status.LastUpdate;
            State = status.State;
            Value = status.Value;
        }

        private float mValue = float.NaN;

        public SignalSpecification Specification { get; private set; }
        public QtSignalSpecification QtSpecification { get; private set; }
        public DateTime LastUpdate { get; private set; }
        public SignalState State { get; private set; }

        public event SignalEvent OnUpdate;
        public event SignalEvent OnChange;

        public float Value
        {
            get { return mValue; }
            private set
            {
                if (OnUpdate != null)
                    OnUpdate(this);

                if (float.IsNaN(mValue) && float.IsNaN(value))
                    return;

                if (float.IsNaN(mValue))
                {
                    mValue = value;

                    if (OnChange != null)
                        OnChange(this);
                }
                else
                {
                    if (float.IsNaN(value))
                        mValue = value;
                    else
                    {
                        if (!(Math.Abs(mValue - value) > 0.000001f)) return;

                        mValue = value;                        
                    }

                    if (OnChange != null)
                        OnChange(this);
                }
            }
        }
        public bool IsSet { get { return Value >= 0.99f; } }
        public int ValueAsInt { get { return (int)Value; } }
    }
}