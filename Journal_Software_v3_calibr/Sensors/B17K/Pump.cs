using System;
using SDK.Common;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{    
    internal static class Pump
    {
        #region internal sensors

        internal class Sensor
        {
            public Sensor(string id, ISignalsFactory factory)
            {
                mSignal = factory.GetSignal(id);
                mChannel = factory.GetSignal(string.Format("{0}.channel", id));

                if (mChannel == null || mSignal == null)
                    throw new ArgumentNullException("");

                mSignal.OnUpdate += rv =>
                {
                    if (mChannel.IsSet && OnUpdate != null)
                        OnUpdate(mSignal.Value);
                };
            }

            public bool IsAvailable { get { return mChannel.IsSet; } }
            public float Value { get { return mSignal.Value; } }

            /// <summary>
            /// При каждом обновлении, если канал обработки подключен
            /// </summary>
            public Action<float> OnUpdate;

            private readonly ISignal mChannel;
            private readonly ISignal mSignal;
        }

        #endregion
        
        internal static class TankSensorHandler
        {
            private static float mLevelAlarmMin;
            private static float mLevelWarnMin;
            private static float mTempWarnMax;
            private static float mTempAlarmMax;

            public static void Init(IJournal journal, ISignalsFactory signals)
            {
                mLevelAlarmMin = signals.GetSignal("tank.level.alarm.min").Value;           // Уровень в баке, авария
                mLevelWarnMin = signals.GetSignal("tank.level.warning.min").Value;          // Уровень в баке, предупреждение
                mTempWarnMax = signals.GetSignal("tank.temperature.warning.max").Value;     // Т в баке, предупреждение
                mTempAlarmMax = signals.GetSignal("tank.temperature.alarm.max").Value;      // Т в баке, авария

                IsNormalState = true;

                mTankTemperature = new Sensor(SensorName.Tank(SignalName.Temperature), signals);
                mTankLevel = new Sensor(SensorName.Tank(SignalName.Level), signals)
                {
                    OnUpdate = value =>
                    {
                        if (value <= mLevelAlarmMin)
                        {
                            if (OnError != null)
                                OnError(SystemStateCodes.Alarm.TankLevelMin);

                            IsNormalState = false;
                            return;
                        }

                        if (value > mLevelWarnMin) return;
                        if (OnWarning != null)
                            OnWarning(SystemStateCodes.Warning.TankLevelMin);

                        // датчик температуры конструктивно выполнен в одном корпусе с датчиком уровня, но датчик уровня является приоритетным
                        if (mTankTemperature.IsAvailable)
                        {
                            if (mTankTemperature.Value > mTempAlarmMax)
                            {
                                if (OnError != null)
                                    OnError(SystemStateCodes.Alarm.TankTemperatureMin);

                                IsNormalState = false;
                                return;
                            }

                            if (mTankTemperature.Value < mTempWarnMax) return;
                            if (OnWarning != null)
                                OnWarning(SystemStateCodes.Warning.TankTemperatureMin);                            
                        }

                        IsNormalState = true;
                    }
                };
            }
            
            public static Action<SystemStateCodes.Warning> OnWarning;
            public static Action<SystemStateCodes.Alarm> OnError;

            public static bool IsNormalState { get; private set; }

        }

        private static Sensor mTankTemperature;
        private static Sensor mTankLevel;
        private static Sensor mBrakePressure;
        private static Sensor mCabelPressure;
        private static Sensor mFilterPressure;
        private static Sensor mSteeringPressure;


        internal static class BrakePressureHandler
        {
            public static void Init(IJournal journal, ISignalsFactory signals)
            {
                mPressureAlarmMin = signals.GetSignal(string.Format("{0}.alarm.min", SensorName.Brake(SignalName.Pressure))).Value;
                mPressureAlarmMax = signals.GetSignal(string.Format("{0}.alarm.max", SensorName.Brake(SignalName.Pressure))).Value;
                mPressureWarningMax = signals.GetSignal(string.Format("{0}.warning.min", SensorName.Brake(SignalName.Pressure))).Value;
                mStartTrackingTimeout = signals.GetSignal("pump.alarm.startup.timeout").Value;

                // датчик давления в системе рулевого и его обработка
                mBrakePressure = new Sensor(SensorName.Brake(SignalName.Pressure), signals)
                {
                    OnUpdate = value =>
                    {
                        if (mStartAt == DateTime.MaxValue) return;

                        if (DateTime.Now.Subtract(mStartAt).TotalSeconds < mStartTrackingTimeout) return;

                        if (value > mPressureAlarmMax)
                        {
                            if (OnError != null)
                                OnError(SystemStateCodes.Alarm.BrakePressureMax);

                            return;
                        }

                        if (value < mPressureAlarmMin)
                        {
                            if (OnError != null)
                                OnError(SystemStateCodes.Alarm.BrakePressureMin);

                            return;
                        }

                        if (value > mPressureWarningMax) return;

                        if (OnWarning != null)
                            OnWarning(SystemStateCodes.Warning.BrakePressureMax);
                    }
                };
            }

            private static float mPressureAlarmMin;
            private static float mPressureAlarmMax;
            private static float mPressureWarningMax;
            private static float mStartTrackingTimeout;

            public static Action<SystemStateCodes.Alarm> OnError;
            public static Action<SystemStateCodes.Warning> OnWarning;
        }

        internal static class CabelPressureHandler
        {
            public static void Init(IJournal journal, ISignalsFactory signals)
            {
                mPressureAlarmMin = signals.GetSignal(string.Format("{0}.alarm.min", SensorName.Cabel(SignalName.Pressure))).Value;
                mPressureAlarmMax = signals.GetSignal(string.Format("{0}.alarm.max", SensorName.Cabel(SignalName.Pressure))).Value;
                mPressureWarningMax = signals.GetSignal(string.Format("{0}.warning.max", SensorName.Cabel(SignalName.Pressure))).Value;
                mStartTrackingTimeout = signals.GetSignal("pump.alarm.startup.timeout").Value;

                // датчик давления в системе рулевого и его обработка
                mCabelPressure = new Sensor(SensorName.Cabel(SignalName.Pressure), signals)
                {
                    OnUpdate = value =>
                    {
                        if (mStartAt == DateTime.MaxValue) return;

                        if (DateTime.Now.Subtract(mStartAt).TotalSeconds < mStartTrackingTimeout) return;

                        if (value > mPressureAlarmMax)
                        {
                            if (OnError != null)
                                OnError(SystemStateCodes.Alarm.CabelPressureMax);

                            return;
                        }

                        if  (value < mPressureAlarmMin)
                        {
                            if (OnError != null)
                                OnError(SystemStateCodes.Alarm.CabelPressureMin);

                            return;
                        }

                        if (value > mPressureWarningMax) return;

                        if (OnWarning != null)
                            OnWarning(SystemStateCodes.Warning.CabelPressureMax);
                    }
                };
            }

            private static float mPressureAlarmMin;
            private static float mPressureAlarmMax;
            private static float mPressureWarningMax;
            private static float mStartTrackingTimeout;

            public static Action<SystemStateCodes.Alarm> OnError;
            public static Action<SystemStateCodes.Warning> OnWarning;
        }

        internal static class SteeringPressureHandler
        {
            public static void Init(IJournal journal, ISignalsFactory signals)
            {
                mPressureAlarmMin = signals.GetSignal("pump.alarm.pressure.min").Value;
                mPressureAlarmMax = signals.GetSignal("pump.alarm.pressure.max").Value;
                mStartTrackingTimeout = signals.GetSignal("pump.alarm.startup.timeout").Value;

                mFilterPressureDifferenceWarnMax = signals.GetSignal("filter.pressure.warning.max").Value;
                mFilterPressureDifferenceAlarmMax = signals.GetSignal("filter.pressure.alarm.max").Value;

                // разница по давлению актуальна только при наличии датчика в гидромагистрали кузова, т.е. в нашем случае - рулевого
                mFilterPressure = new Sensor(SensorName.Filter(SignalName.Pressure), signals); 

                // датчик давления в системе рулевого и его обработка
                mSteeringPressure = new Sensor(SensorName.Steering(SignalName.Pressure), signals)
                {
                    OnUpdate = value =>
                    {
                        if (mStartAt == DateTime.MaxValue) return;

                        if (DateTime.Now.Subtract(mStartAt).TotalSeconds < mStartTrackingTimeout) return;

                        if ((mPressureAlarmMax > value) && (value > mPressureAlarmMin)) return;

                        if (OnError != null)
                        {
                            OnError(SystemStateCodes.Alarm.SystemPressureOutOfRange);
                            return;
                        }

                        if (!mFilterPressure.IsAvailable) return;

                        // проверка на разницу давления на фильтре, если датчик давления перед фильтром доступен
                        var filterDifference = Math.Abs(value - mFilterPressure.Value);
                        if (filterDifference > mFilterPressureDifferenceAlarmMax)
                        {
                            if (OnError != null)
                            {
                                OnError(SystemStateCodes.Alarm.FilterPressureMax);
                                return;
                            }
                        }

                        if (!(filterDifference > mFilterPressureDifferenceWarnMax)) return;
                        if (OnWarning != null)
                        {
                            OnWarning(SystemStateCodes.Warning.FilterPressureMax);
                        }
                    }
                };
            }

            private static float mPressureAlarmMin;
            private static float mPressureAlarmMax;
            private static float mStartTrackingTimeout;

            private static float mFilterPressureDifferenceWarnMax;
            private static float mFilterPressureDifferenceAlarmMax;

            public static Action<SystemStateCodes.Alarm> OnError;
            public static Action<SystemStateCodes.Warning> OnWarning;
        }       

        private static Relay mRelay;
        private static Cord mCord;

        private static ISignal mState;
        private static IJournal mJournal;

        #region startup
        public static void Init(IJournal journal, ISignalsFactory signals)
        {
            mJournal = journal;

            TankSensorHandler.Init(journal, signals);
            //TankSensorHandler.OnError += OnErrorCaller;
            //TankSensorHandler.OnWarning += OnWarningCaller;

            BrakePressureHandler.Init(journal, signals);
            //BrakePressureHandler.OnError += OnErrorCaller;
            //BrakePressureHandler.OnWarning += OnWarningCaller;

            SteeringPressureHandler.Init(journal, signals);
            //SteeringPressureHandler.OnError += OnErrorCaller;
            //SteeringPressureHandler.OnWarning += OnWarningCaller;

            CabelPressureHandler.Init(journal, signals);
            //CabelPressureHandler.OnError += OnErrorCaller;
            //CabelPressureHandler.OnWarning += OnWarningCaller;
            
            AlarmStopTimeout = (ushort) (signals.GetSignal("pump.alarm.shutdown.timeout").Value*1000);

            // делаем отключение асинхронным  - команда на стоп не связана с реальной остановкой двигателя
            mTaskPumpStop = new DelayedTask(100);
            mTaskPumpStop.OnTimeout += sender =>
                                           {
                                               mTaskPumpStop.Stop();

                                               // TODO: тут может понадобится пауза между отключением частотников и насосной станцией
                                               mRelay.Off();
                                               mStartAt = DateTime.MaxValue; // выключаем 

                                               if (mState.ValueAsInt != (uint)EquipmentState.Failure)
                                                   mState.Update((uint)EquipmentState.Stop);
                                           };

            mRelay = new Relay(journal, RelayName.Kv11, signals);
            mRelay.OnError += sensor => OnErrorCaller(SystemStateCodes.Alarm.Kv11OutOfControl);

            mCord = new Cord(signals.GetSignal(SensorName.Cord(1)));
            mCord.OnChange += sensor =>
                                  {
                                      if (sensor.IsSet)
                                      {
                                          OnErrorCaller(SystemStateCodes.Alarm.Cord1OutOfControl);                                          
                                      }
                                  };

            mState = signals.GetSignal(SensorName.Derivative(SystemName.Pump, SignalName.Status));
            
        }
        #endregion

        #region start
        public static void Start()
        {
            if (!mCord.IsNormal)
                return;

            if (Pedals.IsPressed)
                return;

            if (SoundAlarm.IsUnlock)
            {
                OnComplete(null);
            }
            else
            {
                SoundAlarm.OnComplete += OnComplete;
                SoundAlarm.On();
            }
        }

        private static void OnComplete(IReadonlySignal signal)
        {
            // сделано для того, чтобы по обычному нажатию на сигнал не запускался насос :)
            SoundAlarm.OnComplete -= OnComplete;

            // Если не зажата педаль и не сработал корд - включаемся
            if (Pedals.IsPressed || !mCord.IsNormal) return;

            mRelay.On();
            mStartAt = DateTime.Now;

            mState.Update((uint)EquipmentState.Active);
        }
        #endregion

        #region stop
        private static DelayedTask mTaskPumpStop;        
        private static DateTime mStartAt = DateTime.MaxValue;

        /// <summary>
        /// Штатное время для остановки
        /// </summary>
        public static ushort AlarmStopTimeout { get; private set; }

        /// <summary>
        /// Останавливаем насос и частотники
        /// </summary>
        /// <param name="timeout">Задержка перед отключением насоса</param>
        public static void Stop(ushort timeout = 0)
        {
            SoundAlarm.Off();
            if (OnStop != null)
                OnStop(mState);
            
            mTaskPumpStop.SetTimeout(timeout);            
            mTaskPumpStop.Start();
        }

        public static event SignalEvent OnStop;

        #endregion 

        #region status handlers & methods
        private static void OnErrorCaller(SystemStateCodes.Alarm signal)
        {
            mJournal.Error(string.Format("{0}", signal), MessageLevel.System);

            if (OnError != null) OnError(signal);

            mState.Update((uint)EquipmentState.Failure);
        }

        private static void OnWarningCaller(SystemStateCodes.Warning signal)
        {
            mJournal.Warning(string.Format("{0}", signal), MessageLevel.System);

            if (OnWarning != null) OnWarning(signal);
        }

        //public static event SignalEvent OnError;
        public static Action<SystemStateCodes.Alarm> OnError;
        public static Action<SystemStateCodes.Warning> OnWarning;

        public static bool IsReady { get { return mCord.IsNormal; } }
        public static bool IsActive { get { return mRelay.IsSwitchOn; } }

        public static void ResetFault()
        {            
            if(IsReady)
                if (mState.ValueAsInt == (uint)EquipmentState.Failure)
                    mState.Update((uint)EquipmentState.Stop);
        }
        #endregion

    }
}