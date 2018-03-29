using System;
using System.IO;
using System.Net.Sockets;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.Modbus;
using Sensors.B17K;


namespace Sensors.Invertors.ENEL
{
    /// <summary>
    /// Частотный пребразователь ENEL-PC FNTGZ60/1140/D
    /// </summary>
    internal class FNTGZ60 : IInvertor
    {
        private readonly IJournal mJournal;
        private static RS485Master mConnection;
        private readonly byte mModbusId;

        public FNTGZ60(IJournal journal, ISignalsFactory signals, RS485Master modbus, byte modbusId)
        {
            var id = SensorName.Invertor(modbusId);

            if (journal == null)
                throw new ArgumentNullException("journal");

            if (modbus == null)
                throw new ArgumentNullException("modbus");

            Id = id;
            mJournal = journal;
            mConnection = modbus;
            mModbusId = modbusId;

            Status = EngineStatus.Init;


            mState = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Mode));
            mError = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Error));
            var lastError = float.NaN;
            mError.OnUpdate += signal =>
            {
                if (float.IsNaN(mError.Value) && !float.IsNaN(lastError))
                    mJournal.Debug(string.Format("mError уст. в неизв. сост.: {0}", Id), MessageLevel.System);

                lastError = signal.Value;
            };

            mFrequency = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Frequency));
            mCurrent = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Current));
            mVoltage = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Voltage));
            mTemperature = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Temperature));
            mAngle = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.Angle));

            mLastStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.LastStop));            
            mHourStop  = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.HourStop));
            mMinuteStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.MinuteStop));
            mDayStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.DayStop));
            mMonthStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.MonthStop));
            mYearStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.YearStop));
            mFzadStop  = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.FzadStop));
            mFpracyStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.FpracyStop));
            mUdStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.UdStop));
            mIskutStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.IskutStop));
            mTermSensStop = signals.GetSignal(SensorName.Invertor(mModbusId, SignalName.TermSensStop));
             
        }

        public EngineStatus Status { get; private set; }
        public event SignalEvent OnError;

        public string Id { get; private set; }

        /// <summary>
        /// Установка параметров частотника для разных рамп (по рекомендации Дарека от 19.10.2015)
        // read before set new value 
        // 40325 - value = 5 for conveyor mode or value = 0 for motion mode
        /// </summary>
        internal void SetInvertorMode()
        {
            if(Status != EngineStatus.Stopped)
                return;

            try
            {
                mConnection.Open();
                if (!mConnection.IsOpen())
                    return;

                const ushort kConveyorModeSetting = 5;
                const ushort kMotionModeSetting = 0;

                #region read
                var rv = mConnection.ReadHoldings(mModbusId, 325, 1);
                if (rv == null) return;

                //if ((Engine.Mode == EngineMode.Conveyor && rv[0] != kConveyorModeSetting) ||
                if(Engine.Mode == EngineMode.Motion && rv[0] != kMotionModeSetting)//)
                {

                    var rampMode = kMotionModeSetting;
                    //var rampMode = Engine.Mode == EngineMode.Conveyor ? kConveyorModeSetting : kMotionModeSetting;
                    mJournal.Debug(string.Format("Установка {0} в {1} по {2}", mModbusId, Engine.Mode, rampMode), MessageLevel.System);

                    #region write

                    if (mConnection.Write(mModbusId, 325, new[] { rampMode }))
                    {
                        mJournal.Debug(":: успешно", MessageLevel.System);

                        //mJournal.Debug(string.Format("{0}: modbus success write", modbusId), MessageLevel.System);
                    }
                    else
                    {
                        mJournal.Debug(":: защита", MessageLevel.System);
                    }

                    #endregion

                }

                #endregion



            }
            catch (Exception e)
            {
                if (e is SocketException ||
                    e is TimeoutException ||
                    e is IOException)
                {
                    mConnection.Close();
                }
                else
                {
                    throw;
                }
            }
        }

        private bool ReadModbus()
        {
            try
            {
                mConnection.Open();
                if (!mConnection.IsOpen())
                    return false;

                #region read
                //var rv = mConnection.ReadHoldings(mModbusId, 0, 9); // 40000 - 40008 регистры
                //Расширяем число читаемых в журнал регистров по Дэрэку
                var rv = mConnection.ReadHoldings(mModbusId, 0, 20); // 40000 - 40020 регистры
                if (rv != null)
                {
                    mState.Update(rv[0]);
                    mError.Update(rv[1]);  // статус последнего выключения: 0 - нормально выключен, все что больше нуля - защита

                    //if (rv[1] != 0)
                    //    mJournal.Debug(string.Format("Error register: {0} for id: {1}", rv[1], Id), MessageLevel.System);

                    // 2 - Направление

                    mFrequency.Update(rv[3]); // 3 - Fработы в сотых Гц
                    // 4 - Uzad на выходе инвертора
                    mCurrent.Update(rv[5]); // ток инвертора
                    mVoltage.Update(rv[6]); // напряжение на входе инвертора
                    //mTemperature.Update(rv[7]); // температура воздуха вокруг инвертора
                    mAngle.Update(rv[8]); // угол компенсации поворота колес
                    
                    mLastStop.Update(rv[9]);
                    mHourStop.Update(rv[10]);
                    mMinuteStop.Update(rv[11]);
                    mDayStop.Update(rv[12]);
                    mMonthStop.Update(rv[13]);
                    mYearStop.Update(rv[14]);
                    mFzadStop.Update(rv[15]);
                    mFpracyStop.Update(rv[16]);
                    mUdStop.Update(rv[17]);
                    mIskutStop.Update(rv[18]);
                    mTermSensStop.Update(rv[19]);

                    //return true;
                }
                else
                {
                    return false;
                }

                rv = mConnection.ReadHoldings(mModbusId, 23, 1); // 40023
                if (rv != null)
                {
                    mTemperature.Update(rv[0]); // температура радиатора инвертора

                    return true;
                }


                return false;

                #endregion
            }
            catch (Exception e)
            {
                if (e is SocketException ||
                    e is TimeoutException ||
                    e is IOException)
                {
                    mConnection.Close();
                }
                else
                {
                    throw;
                }

                return false;
            }
        }

        /// <summary>
        /// Считываем состояние частотника
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            //Console.WriteLine("{0}: Get Update Id: {1}", DateTime.Now.ToString("HH:mm:ss.fff"), mModbusId);
            bool rv = ReadModbus(); // 256 (40256)                
            if (rv == false)
            {
                // TODO: только для тестов
                //mJournal.Debug(String.Format("Bad engine transfer from {0}", Id), MessageLevel.System);
                mError.Update(float.NaN);  // статус неизвестен
            }

            #region interpretate response
            if (float.IsNaN(mState.Value))
            {
                // TODO: не инициализирован - не было обмена с частотником 
            }
            else
            {
                switch (mState.ValueAsInt) //режим работы, 1 - стоп, 2 - работа, 3 - авария, 4 - запуск
                {
                    case 1: // stop
                        {
                            if (Status != EngineStatus.Stopped)
                                mJournal.Debug(string.Format("{0} остановлен", Id), MessageLevel.System);

                            Status = EngineStatus.Stopped;
                        }
                        break;

                    case 2: // active
                        {
                            if (Status != EngineStatus.Activated)
                                mJournal.Debug(string.Format("{0} активирован", Id), MessageLevel.System);

                            Status = EngineStatus.Activated;
                        }
                        break;

                    case 3: // fault
                        {
                            if (Status != EngineStatus.Failure)
                            {
                                // первый вход в режим
                                mJournal.Debug(string.Format("{0} уст. код защиты {1}", Id, mError.ValueAsInt), MessageLevel.System);

                                mJournal.Debug(string.Format("{0} уст. причина защиты {1}", Id, mLastStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Часы {1}", Id, mHourStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Минуты {1}", Id, mMinuteStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Дни {1}", Id, mDayStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Месяц {1}", Id, mMonthStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Год {1}", Id, mYearStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Fzad {1}", Id, mFzadStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Fpracy {1}", Id, mFpracyStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Ud {1}", Id, mUdStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. Iskut {1}", Id, mIskutStop.ValueAsInt), MessageLevel.System);
                                mJournal.Debug(string.Format("{0} уст. TermSens {1}", Id, mTermSensStop.ValueAsInt), MessageLevel.System);

                                if (OnError != null)
                                    OnError(mError);
                            }

                            Status = EngineStatus.Failure;
                        }
                        break;

                    case 4: // pre-active
                        {
                            if (Status != EngineStatus.Prelaunched)
                                mJournal.Debug(string.Format("{0} уст. презапуск", Id), MessageLevel.System);

                            Status = EngineStatus.Prelaunched;
                        }
                        break;

                    default:
                        {
                            mJournal.Error(string.Format("{0}: неверный режим {1}", Id, mState.Value), MessageLevel.System);
                        }
                        break;
                }
            }

            #endregion

            return rv;
        }

        private readonly ISignal mState;
        private readonly ISignal mError;
        private readonly ISignal mFrequency;
        private readonly ISignal mCurrent;
        private readonly ISignal mVoltage;
        private readonly ISignal mTemperature;
        private readonly ISignal mAngle;

                    private readonly ISignal mLastStop;        
                    private readonly ISignal mHourStop;
                    private readonly ISignal mMinuteStop;
                    private readonly ISignal mDayStop;
                    private readonly ISignal mMonthStop;
                    private readonly ISignal mYearStop;
                    private readonly ISignal mFzadStop;
                    private readonly ISignal mFpracyStop;
                    private readonly ISignal mUdStop;
                    private readonly ISignal mIskutStop;
                    private readonly ISignal mTermSensStop;

        //added signals
        //private readonly ISignal mError;

        //private readonly ushort[] mOutputData = new ushort[3];

        private ushort mFrequencySettings;

        public void Direction(bool forward)
        {
            // TODO: ОЧЕНЬ ВАЖНО!!!! Направление должно выставляться ВСЕГДА уникастово, а старт-стоп в режиме движения - бродкастово            
            if (Status == EngineStatus.Stopped)
            {
                //mOutputData[2] = (ushort)(forward ? 0 : 1);                
                //WriteUpdate(mModbusId, 2, new[] { (ushort)(forward ? 0 : 1) });
                UnicastData.UpdateData(2, (ushort)(forward ? 0 : 1));
            }
        }

        /// <summary>
        /// Частота в сотых Гц (0.01 Гц). Защита в диапазоне 100..9900 
        /// </summary>
        /// <param name="value"></param>
        public void Frequency(ushort value)
        {
            // TODO: ОЧЕНЬ ВАЖНО!!!! частота должна выставляться ВСЕГДА уникастово, а старт-стоп в режиме движения - бродкастово

            // [04.04.2014 17:33:48] Преймачук Юрий: Привет! Необходимо обеспечить 4 скорости движения вагона №10 (3 км/ч, 6 км/ч, 9 км/ч, 12 км/ч), что соответствует частотам ПЧН:
            //        3 км/ч - 25 Гц;
            //        6 км/ч - 50 Гц;
            //        9 км/ч - 75 Гц;
            //        12 км/ч - 100 Гц.

            value = CorrectFrequencyRange(value);

            if (mFrequencySettings != value)
            {
                mFrequencySettings = value;
                mJournal.Debug(string.Format("{0}: уст. частота: {1}", Id, mFrequencySettings), MessageLevel.System);

                //mOutputData[1] = mFrequencySettings;
                //WriteUpdate(isBroadcast ? (byte)0 : mModbusId, 1, new[] { mFrequencySettings });
                //if (isBroadcast)
                //    BroadcastData.UpdateData(1, mFrequencySettings);
                //else
                UnicastData.UpdateData(1, mFrequencySettings);
            }
        }

        public ushort GetFrequency()
        {
            return (ushort)mFrequency.ValueAsInt;
        }

        private static ushort CorrectFrequencyRange(ushort value)
        {
            // 99 Гц
            if (value > 9900)
                value = 9900;

            // 1 Гц
            if (value < 100)
                value = 100;
            return value;
        }

        public void SetFrequencySpeedup(ushort speed)
        {
            // TODO: внимание, адрес смещен - смотри код WriteUpdate
            //WriteUpdate(0, 0, new ushort[] { 1 });  
        }

        public void On(bool isBroadcast)
        {
            //if (Status == EngineStatus.Stopped)
            {
                //mOutputData[0] = 1;
                //WriteUpdate((byte)(isBroadcast ? 0 : mModbusId), 0, new ushort[] { 1 });

                if (isBroadcast)
                    BroadcastData.UpdateData(0, 1);
                else
                {
                    /*
                    if (Engine.Mode == EngineMode.Conveyor)
                    {
                        UnicastData.UpdateData(0, 1);
                    }
                    else
                        mJournal.Debug("Cann't switch-on single invertor at non-Conveyor mode", MessageLevel.System);
                     */
                    //UnicastData.UpdateData(0, 1);                    
                }

            }
        }

        public void Off(bool isBroadcast)
        {
            //if (Status == EngineStatus.Activated)
            {
                //mOutputData[0] = 0;
                //WriteUpdate((byte) (isBroadcast ? 0 : mModbusId), 0, new ushort[]{ 0 });
                if (isBroadcast)
                    BroadcastData.UpdateData(0, 0);
                else
                {
                    /*
                    if (Engine.Mode == EngineMode.Conveyor)
                    {
                        UnicastData.UpdateData(0, 0);
                    }
                    else
                        mJournal.Debug("Cann't switch-off single invertor at non-Conveyor mode", MessageLevel.System);
                    //UnicastData.UpdateData(0, 0);
                    */
                }
            }
        }

        public void ResetFault()
        {
            BroadcastData.UpdateData(0, 2);
            //WriteUpdate(0, 0, new ushort[] { 2 });
            //mOutputData[0] = 2;
            //Frequency(100);
        }

        public override string ToString()
        {
            return string.Format("{0} -  I: {1:F1}, V: {5:F1}, f: {2}/{6}, Сост.: {4}, Ошиб.: {3}", Id, mCurrent.Value, mFrequency.Value, mError.ValueAsInt, mState.ValueAsInt, mVoltage.ValueAsInt, mFrequencySettings);
        }

        /// <summary>
        /// Записываем параметры на modbus 
        /// </summary>
        /// <param name="modbusId">Modbus ID</param>
        /// <param name="address">256 + address</param>
        /// <param name="data">Data for write</param>
        /// <returns></returns>
        private static void WriteUpdate(byte modbusId, ushort address, ushort[] data)
        {
            /*
            if (modbusId == 0)
            {
                Console.WriteLine("\t{0}: Write broadcast update at addr {1} lenght {2}", DateTime.Now.ToString("HH:mm:ss.fff"), address, data.Length);                
            }
            else
            {
                Console.WriteLine("\t\t{0}: Write unicast update Id: {1} at addr {2} lenght {3}", DateTime.Now.ToString("HH:mm:ss.fff"), modbusId, address, data.Length);                
            }    
            */
            try
            {
                mConnection.Open();

                #region write

                // TODO: доделать выключение и включение на всех
                if (mConnection.Write(modbusId, (ushort)(256 + address), data))
                //if (mConnection.Write(mModbusId, 256, mOutputData))
                {
                    //mJournal.Debug(string.Format("{0}: modbus success write", modbusId), MessageLevel.System);
                }

                #endregion
            }
            catch (Exception e)
            {
                if (e is SocketException ||
                    e is TimeoutException ||
                    e is IOException)
                {
                    mConnection.Close();
                }
                else
                {
                    throw;
                }
            }
        }

        public void WriteState()
        {
            if (!UnicastData.HasUpdate) return;

            // TODO: данные на включение-выключение должна совпадать с броадкаст для режима движения
            var req = UnicastData.GetData();

            //WriteUpdate(mModbusId, 0, UnicastData.GetData());
            WriteUpdate(mModbusId, 1, new[] { req[1], req[2] });
        }

        public void WriteConveyorState()
        {
            if (!UnicastData.HasUpdate) return;

            // TODO: данные на включение-выключение должна совпадать с броадкаст для режима движения
            WriteUpdate(mModbusId, 0, UnicastData.GetData());
        }

        public class DataToWrite
        {
            /// <summary>
            /// 0 - on/off/reset
            /// 1 - freq
            /// 2 - direction
            /// </summary>
            private readonly ushort[] mOutputData;
            private readonly bool mIsUnicast = true;
            public bool HasUpdate { get; private set; }

            public DataToWrite(bool isUnicast)
            {
                //mOutputData = isUnicast ? new ushort[]{0, 100, 0} : new ushort[]{0};
                mOutputData = isUnicast ? new ushort[] { 0, 100, 0 } : new ushort[] { 0 };
                mIsUnicast = isUnicast;
            }

            public ushort[] GetData()
            {
                HasUpdate = false;
                return mOutputData;
            }

            public void UpdateData(byte address, ushort value)
            {
                if (mOutputData[address] == value && mIsUnicast) return;

                //Console.WriteLine("{0} update: {1} = {2}", mIsUnicast ? "Unicast" : "Broadcast", address, value);

                mOutputData[address] = value;
                HasUpdate = true;
            }
        }

        public static DataToWrite BroadcastData = new DataToWrite(false);
        public DataToWrite UnicastData = new DataToWrite(true);

        public static void WriteBroadcast()
        {
            if (!BroadcastData.HasUpdate) return;

            WriteUpdate(0, 0, BroadcastData.GetData());
        }
    }
}
