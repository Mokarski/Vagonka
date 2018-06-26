using SDK.SignalsFactory.Interface;

namespace SDK.SignalsFactory
{
    public class Sensor
    {
        private readonly Signal mWarningMin;
        private readonly Signal mWarningMax;
        private readonly Signal mAlarmMin;
        private readonly Signal mAlarmMax;

        private readonly Signal mChannel;
        private readonly Signal mSignal;

        /// <summary>
        /// Прописываем датчик в общую регистровую карту 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="factory"></param>
        public Sensor(string id, SignalsFactory factory)
        {
            mSignal = new Signal(id);

            mWarningMin = new Signal(string.Format("{0}.warning.min", id));
            mWarningMax = new Signal(string.Format("{0}.warning.max", id));
            mAlarmMin = new Signal(string.Format("{0}.alarm.min", id));
            mAlarmMax = new Signal(string.Format("{0}.alarm.max", id));
            mChannel = new Signal(string.Format("{0}.channel", id));

            mWarningMin.OnChange += UpdateLimit;
            mWarningMax.OnChange += UpdateLimit;
            mAlarmMin.OnChange += UpdateLimit;
            mAlarmMax.OnChange += UpdateLimit;

            factory.AddSignal(mSignal, SignalType.Float);
            factory.AddConfig(mWarningMin, SignalType.Float);
            factory.AddConfig(mWarningMax, SignalType.Float);
            factory.AddConfig(mAlarmMin, SignalType.Float);
            factory.AddConfig(mAlarmMax, SignalType.Float);
            factory.AddConfig(mChannel, SignalType.Ushort);
        }

        private void UpdateLimit(ISignal signal)
        {
            mSignal.SetRange(mAlarmMin.Value, mWarningMin.Value, mWarningMax.Value, mAlarmMax.Value);
        }

        public int GetChannel()
        {
            return mChannel.ValueAsInt - 1;
        }

        /// <summary>
        /// Датчик подключен
        /// </summary>
        public bool IsEnable
        {
            get { return mChannel.IsSet; }
        }

        /// <summary>
        /// Получить сигнал для последующей работы с ним
        /// </summary>
        /// <returns></returns>
        public Signal GetSignal()
        {
            return mSignal;
        }
    }
}