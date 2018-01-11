using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using SDK.Common;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.Modbus;
using Sensors.Invertors;
using Sensors.Invertors.ENEL;

namespace Sensors.B17K
{
    
    internal static class Engine
    {
        private static ISignalsFactory mSignals;
        private static IJournal mJournal;

        private static IInvertor mUz2, mUz3, mUz4, mUz5;
        /// <summary>
        /// Значение поворта влево для компенсации тяги
        /// </summary>
        //private static ISignal mLeft;
        //private static ISignal mRight;

        private static IInvertor mConveyor;

        private static readonly DelayedTask ResetMotionSpeedToMin = new DelayedTask(3000); // опускаем скорость до минимальной, если нет нажатия на педаль    

        private static readonly List<IInvertor> Invertors = new List<IInvertor>();

        private static readonly List<Cord> Cords = new List<Cord>();

        // активное включение выпрямителя - заряд включается по включению насоса
        private static Relay mKv1;

        // включение в режим хода
        //private static Relay mKv8;

        // включение в режим конвейера
        //private static Relay mKv9;
        
        // вторая скорость конвейера
        private static Relay mKv9;
        // первая скорость конвейера
        private static Relay mKv10;

        // сброс сетевого инвертора
        private static Relay mRectifierReset;

        /// <summary>
        /// Обертка над вызовом OnError
        /// </summary>
        /// <param name="code"></param>
        private static void OnErrorWrapper(SystemStateCodes.Alarm code)
        {
            if (OnError != null)
                OnError(code);
        }

        /// <summary>
        /// Устанавливем состояние через метод для логгирования
        /// </summary>
        /// <param name="state"></param>
        private static void SetState(SystemState state)
        {
            if (State == state)
                return;

            mJournal.Debug(string.Format("Статус обработчика инверторов: {0}", state), MessageLevel.System);

            State = state;
        }

        #region Init & modbus update

        private static string mPortName;
        private static RS485Master mConnection;
        private static Thread mThread;

        private static readonly List<ISignal> Voltages = new List<ISignal>();
        private static ISignal mKv2Feedback;


        // TODO: в правильном варианте - все эти возвраты должны устанавливать
        // состояние в неком регистре для последующего вывода сообщения на экран о причине защиты

        /// <summary>
        /// Корды в норме
        /// Насос включен
        /// Есть сигнал обратной связи от контактора заряда выпрямителя
        /// Инверторы в нормально-остановленном режиме, напряжение больше 1200 В
        /// </summary>
        /// <returns></returns>
        private static bool IsCharged()
        {
            if (Cords.Count(s => !s.IsNormal) > 0)
                return false;

            if (!Pump.IsActive)
                return false;

            // TODO: uncomment all code below before real start 
            //if (!mKv2Feedback.IsSet) // контактор отключается после зарядки
            //    return false;

            //if (Invertors.Count(s => s.Status != EngineStatus.Stopped) > 0)
            //    return false;

            // TODO: насколько низким может быть напряжение на входе инвертора?
            return Voltages.Count(s => s.ValueAsInt < 1200) <= 0;
        }

        /// <summary>
        /// Нет блокировок
        /// Выпрямитель включен в активном режиме
        /// </summary>
        /// <returns></returns>
        private static bool IsActive()
        {
            return IsCharged() && mKv1.IsSwitchOn;
        }

        /// <summary>
        /// Нет блокировок
        /// Активен режим хода или конвейера
        /// </summary>
        /// <returns></returns>
        private static bool IsMotionReady()
        {
            /*
            if (!IsActive())
                return false;

            if (Mode == EngineMode.Motion)
                return mKv8.IsSwitchOn;
            if (Mode == EngineMode.Conveyor)
                return mKv9.IsSwitchOn;

            // EngineMode.Deactivated
            return false;
            */

            return IsActive();
        }

        public static void Init(IJournal journal, ISignalsFactory signals, string port, int baudrate)
        {
            mJournal = journal;
            mPortName = port;
            mSignals = signals;

            mConnection = new RS485Master(journal, mPortName, baudrate, false);
            SetState(SystemState.Init);
            SpeedSettings();

            mUz2 = InitInvertor(1);
            mUz3 = InitInvertor(2);
            mUz4 = InitInvertor(3);
            mUz5 = InitInvertor(4);

            mConveyor = mUz4;

            //mLeft = mSignals.GetSignal(SensorName.Invertor(4, SignalName.Angle)); // uz5
            //mRight = mSignals.GetSignal(SensorName.Invertor(1, SignalName.Angle)); // uz2

            mUz2State = mSignals.GetSignal(SensorName.Derivative(SystemName.Uz, 2, SignalName.Status));
            mUz3State = mSignals.GetSignal(SensorName.Derivative(SystemName.Uz, 3, SignalName.Status));
            mUz4State = mSignals.GetSignal(SensorName.Derivative(SystemName.Uz, 4, SignalName.Status));
            mUz5State = mSignals.GetSignal(SensorName.Derivative(SystemName.Uz, 5, SignalName.Status));
            mConveyorState = mSignals.GetSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Status));

            mState = new List<ISignal>
                         {
                             mUz2State,
                             mUz3State,
                             mUz4State,
                             mUz5State,
                             mConveyorState
                         };

            for (var i = 0; i < 5; i++)
            {
                var rv = new Cord(signals.GetSignal(SensorName.Cord((byte)(i + 2))));
                rv.OnChange += sensor =>
                {
                    if (!sensor.IsSet) return;

                    OnErrorWrapper(GetCordCode(sensor.Specification.Id));

                    // last action
                    for (var j = 0; j < Cords.Count; j++)
                    {
                        if (Cords[j] != rv) continue;
                        mState[j].Update((float)EquipmentState.Failure);
                        return;
                    }
                };
                Cords.Add(rv);
            }

            mRectifierReset = new Relay(journal, RelayName.RectifierReset, signals);

            mKv1 = new Relay(journal, RelayName.Kv1, signals);
            mKv1.OnError += signal => OnErrorWrapper(SystemStateCodes.Alarm.Kv1OutOfControl);                       

            /*
            mKv8 = new Relay(journal, RelayName.Kv8, signals);
            mKv8.OnError += signal =>
            {
                // TODO: конвейерный частотник
                mUz4State.Update((uint)EquipmentState.Failure);
                OnErrorWrapper(SystemStateCodes.Alarm.Kv8OutOfControl);
            };
            */
            mKv9 = new Relay(journal, RelayName.Kv9, signals);
            mKv9.OnError += signal =>
                                {
                                    mConveyorState.Update((uint)EquipmentState.Failure);
                                    OnErrorWrapper(SystemStateCodes.Alarm.Kv9OutOfControl);
                                };

            mKv10 = new Relay(journal, RelayName.Kv10, signals);
            mKv10.OnError += signal =>
            {
                mConveyorState.Update((uint)EquipmentState.Failure);
                OnErrorWrapper(SystemStateCodes.Alarm.Kv10OutOfControl);
            };

            // Автоматическое выключение конвейера по ошибке
            mConveyorState.OnChange += signal =>
            {
                if (signal.ValueAsInt == (int) EquipmentState.Failure) ConveyorOff();
            };


            for (byte i = 1; i < 5; i++)
            {
                var voltage = signals.GetSignal(SensorName.Invertor(i, SignalName.Voltage));
                if (voltage != null)
                    Voltages.Add(voltage);
                else
                {
                    throw new NullReferenceException();
                }
            }

            mConveyorState.Update((uint)EquipmentState.Stop);

            // charge
            mKv2Feedback = signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback));

            // включился режим заряда выпрямителя
            mKv2Feedback.OnChange += sensor =>
                                         {
                                             //if(sensor.IsSet)
                                             //   mJournal.Debug(string.Format("{0}: {1}", sensor.Id, sensor.IsSet), MessageLevel.System)
                                         };

            mTangage = mSignals.GetSignal("tangage"); // 
            mEncoder = signals.GetSignal("encoder.point");

            mThread = new Thread(Update);
            mThread.Start();        
        }

        private static SystemStateCodes.Alarm GetCordCode(string id)
        {
            switch (id)
            {        
                case "cord.f2":
                    return SystemStateCodes.Alarm.Cord2OutOfControl;

                case "cord.f3":
                    return SystemStateCodes.Alarm.Cord3OutOfControl;

                case "cord.f4":
                    return SystemStateCodes.Alarm.Cord4OutOfControl;

                case "cord.f5":
                    return SystemStateCodes.Alarm.Cord5OutOfControl;

                case "cord.f6":
                    return SystemStateCodes.Alarm.Cord6OutOfControl;

                case "cord.f7":
                    return SystemStateCodes.Alarm.Cord7OutOfControl;

                 default:
                    return SystemStateCodes.Alarm.UnknownCordOutOfControl;

            }
        }

        private static EquipmentState GetState(EngineStatus status)
        {
            switch (status)
            {
                case EngineStatus.Init:
                case EngineStatus.Stopped:
                    return EquipmentState.Stop;

                case EngineStatus.Prelaunched:
                case EngineStatus.Activated:
                    return EquipmentState.Active;
            }

            return EquipmentState.Failure;
        }

        /// <summary>
        /// Обновляем информацию по частотникам (modbus)
        /// </summary>
        private static void Update()
        {
            mJournal.Info("Обработчик инверторов запущен", MessageLevel.System);
            int RS485TimeOutms = 5;

            //var elapsed = new Stopwatch();
            try
            {
                while (true)
                {
                    try
                    {
                        //Console.WriteLine("lap: {0} ms", elapsed.ElapsedMilliseconds);
                        //const int kPeriod = 100;
                        //Thread.Sleep((int)(elapsed.ElapsedMilliseconds > kPeriod ? 0 : kPeriod - elapsed.ElapsedMilliseconds));
                        //elapsed.Restart();

                        // внутренняя логика работы - в том числе и запись в регистры
                        InternalLogic();

                        #region cчитываем текущее состояние частотников
                        
                        // чтение параметров
                        foreach (var invertor in Invertors)
                        {
                            ((FNTGZ60)(invertor)).Update();
                            Thread.Sleep(RS485TimeOutms); // pause for RS485 channel
                        }

                        // запись параметров управления
                        /*
                        if (Mode == EngineMode.Conveyor)
                        {
                            // TODO: записывает все три управляющих байта !!!
                            ((FNTGZ60)(mConveyor)).WriteConveyorState();
                        }
                        else
                        */
                        {
                            foreach (var invertor in Invertors)
                            {
                                // TODO: записывает ТОЛЬКО ДВА управляющих байта частоты и направления - запуск и остановка по броадкасту !!!
                                ((FNTGZ60) (invertor)).WriteState();
                                Thread.Sleep(RS485TimeOutms); // pause for RS485 channel
                            }

                            FNTGZ60.WriteBroadcast();
                        }

                        Thread.Sleep(10);

                        mUz2State.Update((uint)GetState(mUz2.Status));
                        mUz3State.Update((uint)GetState(mUz3.Status));
                        mUz4State.Update((uint)GetState(mUz4.Status));
                        mUz5State.Update((uint)GetState(mUz5.Status));
                        
                        if(mConveyorState.ValueAsInt != (uint)EquipmentState.Failure)
                            mConveyorState.Update(mIsConveyorActive ? (uint)EquipmentState.Active : (uint)EquipmentState.Stop);

                        /*
                        if (Mode == EngineMode.Conveyor)
                            mConveyorState.Update((uint)GetState(mUz4.Status));
                        else
                            mConveyorState.Update((uint)EquipmentState.Stop);
                        

                        // установка правильной рампы по рекомендации Дарека
                        ((FNTGZ60)mConveyor).SetInvertorMode();
                        */
                      
                        #endregion
                    }
                    catch (Exception e)
                    {
                        if (e is TimeoutException ||
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
            }
            catch (ThreadAbortException)
            {
                mConnection.Close();
                mJournal.Info("Обработчик инверторов остановлен (защита)", MessageLevel.System);
            }
            catch (Exception e)
            {
                mConnection.Close();
                mJournal.Fatal(e.ToString(), MessageLevel.System);

                throw;
            }
        }

        private static IInvertor InitInvertor(byte channel)
        {
            var rv = new FNTGZ60(mJournal, mSignals, mConnection, channel);

            Invertors.Add(rv);
            mJournal.Info(string.Format("Инвертор #{0} запускается", channel), MessageLevel.System);

            rv.OnError += signal =>
            {
                SetState(SystemState.Failure);

                foreach (var invertor in Invertors)
                    invertor.Off(true);

                OnErrorWrapper(GetInvertorCode(channel));
            };

            return rv;
        }

        private static SystemStateCodes.Alarm GetInvertorCode(byte channel)
        {
            switch (channel)
            {
                case 1:
                    return SystemStateCodes.Alarm.Uz2Error;

                case 2:
                    return SystemStateCodes.Alarm.Uz3Error;

                case 3:
                    return SystemStateCodes.Alarm.Uz4Error;

                case 4:
                    return SystemStateCodes.Alarm.Uz5Error;


                default:
                    return SystemStateCodes.Alarm.UnknownNameUzError;
            }
        
        }

        #endregion

        #region установка скоростей и частот

        private static ISignal mMotionSpeed;
        private static ISignal mConveyorSpeed;
        const int kMotionSpeedCount = 4;
        //const int kConveyorSpeedCount = 3;
        const int kConveyorSpeedCount = 2;

        private static readonly List<ISignal> MotionFrequencies = new List<ISignal>();
        private static readonly List<ISignal> ConveyorFrequencies = new List<ISignal>();

        private static void SpeedSettings()
        {
            mMotionSpeed = mSignals.GetSignal(SensorName.Derivative(SystemName.System, SignalName.Speed));
            mMotionSpeed.Update(0);

            for (var i = 0; i < kMotionSpeedCount; i++)
            {
                var rv = mSignals.GetSignal(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.System, SignalName.Speed), i + 1));
                MotionFrequencies.Add(rv);
            }

            mConveyorSpeed = mSignals.GetSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Speed));
            mConveyorSpeed.Update(0);

            for (var i = 0; i < kConveyorSpeedCount; i++)
            {
                var rv = mSignals.GetSignal(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.Conveyor, SignalName.Speed), i + 1));
                ConveyorFrequencies.Add(rv);
            }

            // Понижаем частоту, если долго не давили на педали
            ResetMotionSpeedToMin.OnTimeout += sender =>
                                                   {
                                                       mJournal.Debug("Сброс скорости по таймеру", MessageLevel.System);
                                                       mMotionSpeed.Update(0);
                                                   };
        }

        private static ushort[] mUphillLimits;
        /// <summary>
        /// Добавляем условие ограничения максимальной частоты при уклоне (спуск-подъем)
        /// </summary>
        /// <returns> Максимальная частота для данного угла наклона, в Гц </returns>
        private static ushort GetUphillLimit()
        {
            const ushort kMaxFreq = 100;

            if (!mSignals.GetSignal("tangage.uphill.limit.enable").IsSet)
                return kMaxFreq;
                        
            // первичная инициализация
            if (mUphillLimits == null)
            {
                mUphillLimits = new ushort[16];
                for (var i = 0; i < mUphillLimits.Length; i++)
                {
                    mUphillLimits[i] = (ushort)mSignals.GetSignal("tangage.uphill.limit." + i).ValueAsInt;
                    if (mUphillLimits[i] != 0) continue;
                    
                    // некоректные уставки - не применяем ограниение по частоте - отдаем без ограничений в 100 Hz
                    mUphillLimits = null;
                    return kMaxFreq;
                }
            }
            else
            {
                var rv =  Math.Abs(mTangage.ValueAsInt) > mUphillLimits.Length ? mUphillLimits[mUphillLimits.Length - 1] : mUphillLimits[Math.Abs(mTangage.ValueAsInt)];
                
                return rv;
            }

            return kMaxFreq; // 100 Hz
        }
        #endregion

        #region внутренние методы

        /// <summary>
        /// Состояние частотника Uz2. Параметр для визуализации
        /// </summary>
        private static ISignal mUz2State;
        
        /// <summary>
        /// Состояние частотника Uz3. Параметр для визуализации
        /// </summary>
        private static ISignal mUz3State;
        
        /// <summary>
        /// Состояние частотника Uz4. Параметр для визуализации
        /// </summary>
        private static ISignal mUz4State;
        
        /// <summary>
        /// Состояние частотника Uz5. Параметр для визуализации
        /// </summary>
        private static ISignal mUz5State;        
        
        /// <summary>
        /// Состояние конвейера. Параметр для визуализации
        /// </summary>
        private static ISignal mConveyorState;        
        private static List<ISignal> mState;
        private static bool mIsNeedResetFault;
        /// <summary>
        /// Последняя защита дата и время
        /// </summary>
        private static DateTime lastFailDateTime = DateTime.Now;
        private static bool fisrtstart = true;


        private static void InternalLogic()
        {
            try
            {
                #region рабочее тело
                
                switch (State)
                {
                    case SystemState.Init:
                        {
                            Stop();

                            // TODO: проверяем, все ли готово для перехода в рабочий режим (SystemState.Ready)
                            if (IsCharged())
                            {
                                mKv1.On();

                                if (IsActive())
                                    SetState(SystemState.Ready);
                            }
                            else
                            {
                                // по сути это режим выключенной насосной станции - поэтому корректное выключение двигателей под вопросом

                                // сбрасываем уставку скорости до начальной и указываем режим ожидание
                                SetMode(EngineMode.Deactivate);

                                // все частотники остановлены (защита или штатный останов)
                                if (Invertors.Count(s => (s.Status == EngineStatus.Stopped) || (s.Status == EngineStatus.Failure)) == Invertors.Count)
                                {
                                    // mJournal.Warning(string.Format("|| {0}", Invertors.Count(s => (s.Status == EngineStatus.Stopped) || (s.Status == EngineStatus.Failure))));                                        
                                    // защита
                                    mKv1.Off();
                                    //mKv8.Off();                                    
                                    //mKv9.Off();

                                }
                            }
                        }
                        break;

                    // 
                    case SystemState.Ready:
                        {
                            Stop();
                            
                            if (!IsActive())
                            {
                                SetState(SystemState.Init); // упс, что то пошло не так
                                break;
                            }

                            switch (Mode)
                            {
                                case EngineMode.Deactivate:
                                    {
                                        // Это или режим ожидания или режим, после выключения одного из рабочих состояний                                            
                                        // все частотники остановлены (защита или штатный останов)
                                        if (Invertors.Count(s => (s.Status == EngineStatus.Stopped) || (s.Status == EngineStatus.Failure)) == Invertors.Count)
                                        {
                                            // защита
                                            //mKv8.Off(); // EngineMode.Motion
                                            //mKv9.Off(); // EngineMode.Conveyor
                                        }
                                    }
                                    break;
                                    
                                /*
                                case EngineMode.Motion:
                                    {
                                        mKv8.On();
                                    }
                                    break;

                                case EngineMode.Conveyor:
                                    {
                                        mKv9.On();
                                    }
                                    break;
                                */ 
                            }

                            if (IsMotionReady() && !Pedals.IsPressed)
                                SetState(SystemState.Active);
                        }
                        break;

                    // можем быть тут и в режиме хода и в режиме конвейера
                    case SystemState.Active:
                        {
                            //mJournal.Debug("\tinternal logic: 2", MessageLevel.System);
                            if (!IsMotionReady())
                            {
                                SetState(SystemState.Ready); // упс, что то пошло не так
                                break;
                            }

                            switch (Mode)
                            {
                                case EngineMode.Motion:
                                    {
                                        if (Pedals.IsUnlock)
                                        {
                                            Start(Pedals.Forward);
                                        }
                                        else
                                        {
                                            // педали отпущены - останавливаемся 
                                            Stop();
                                        }
                                    }
                                    break;

                                /*
                                case EngineMode.Conveyor:
                                    {
                                        // педалями фактически можно притормаживать работу конвейера - Стебнев "не надо"
                                        if (Pedals.IsPressed)
                                        {
                                            // педали нажата - плавно понижаем частоту инвертора uz5
                                            //Stop();
                                            if (mConveyor.Status != EngineStatus.Activated)
                                            {
                                                // TODO: Если мы до этого еще не включались - надо заблокировать дальнейщее включение или нет?
                                            }
                                        }
                                        else
                                        {
                                            Start(true);
                                        }
                                    }
                                    break;
                                 */
                            }
                            //mJournal.Debug("\tinternal logic: 3", MessageLevel.System);
                        }
                        break;

                    case SystemState.Failure:
                        {
                            string fn = "";
                            if ((DateTime.Now.AddMinutes(-5) > lastFailDateTime) || fisrtstart)
                              {
                                 fn = mSignals.WriteInfo("");
                                 lastFailDateTime = DateTime.Now;
                                 fisrtstart = false;
                              }
                            mJournal.Error("Режим защиты. Сброс и запуск системы.", MessageLevel.System);
                            if (fn.Length > 0) mJournal.Info("Снимок сигналов лежит в файле " + fn, MessageLevel.System); else
                                mJournal.Error("Снимок сигналов не удалось записать (защита или множественные защиты)", MessageLevel.System);
                            if (mIsNeedResetFault)
                            {
                                // аппаратный сброс сетевого выпрямителя 
                                mRectifierReset.On();
                                Thread.Sleep(500);
                                mRectifierReset.Off();
                                Thread.Sleep(500);

                                foreach (var invertor in Invertors)
                                {
                                    // записываем команду на сброс
                                    invertor.ResetFault(); 
                                    Thread.Sleep(50);
                                    
                                    // обновляем значения с частотника
                                    ((FNTGZ60) invertor).Update();
                                }

                                // заходим в этот блок единожды на каждое нажатие кнопки
                                mIsNeedResetFault = false;
                            }

                            // блокировка по кордам снята
                            if (Cords.Count(s => !s.IsNormal) > 0)
                                break;

                            // все двигателя сброшены из состояния ошибки
                            if (Invertors.Count(s => s.Status == EngineStatus.Stopped) != Invertors.Count)
                                break;

                            // переходим в стартовый режим и пробуем запустится штатно
                            SetState(SystemState.Init);
                            fisrtstart = true;
                            mJournal.Info("Запуск после ухода в защиту произведен", MessageLevel.System);
                        }
                        break;
                }
                #endregion
            }
            catch (Exception ex)
            {
                // что то очень не штатное - так быть не должно
                mJournal.Error(ex.ToString(), MessageLevel.System);
            }

        }

        /// Выставляем рабочие частоты для двигателей в режиме хода
        private static void UpdateMotionFrequencies()
        {
            // берем значение частоты по таблице соответсвия скоростей
            var rv = (ushort)MotionFrequencies[mMotionSpeed.ValueAsInt].ValueAsInt;

            #region применяем ограничение на максимальную частоту при спуске-подъеме
            var limit = (ushort)(GetUphillLimit() * 100); // домножаем на 100
            if (rv > limit)
                rv = limit;
            
            // Set Motion frequency. Minimum by default (1 Hz)
            rv = (ushort)(rv < 100 ? 100 : rv);
            #endregion

            #region вычисляем компенацию для угла поворота и выставляем значения частот

            // попарно (uz2 + uz3 | uz5 + uz4)
            // в максимуме давим на 0.2f (20%)

            mUz2.Frequency(rv);
            mUz3.Frequency(rv);
            mUz4.Frequency(rv);
            mUz5.Frequency(rv);

            /*
            if (mEncoder.ValueAsInt == 0 || float.IsNaN(mEncoder.Value))
            {
                mUz2.Frequency(rv, true);
            }
            else
            {
                var compensation = (ushort) ((Math.Abs(mEncoder.Value)*rv > 100) ? (Math.Abs(mEncoder.Value)*rv) : 100);

                // компенсация в нашем случае не может быть больше значения частоты
                if (compensation > rv)
                    compensation = rv;

                if (mEncoder.ValueAsInt > 0)
                {
                    mUz2.Frequency(rv, false);
                    mUz3.Frequency(rv, false);

                    mUz4.Frequency(compensation, false);
                    mUz5.Frequency(compensation, false); 
                }
                else
                {
                    mUz2.Frequency(compensation, false);
                    mUz3.Frequency(compensation, false);

                    mUz4.Frequency(rv, false);
                    mUz5.Frequency(rv, false);
                }
            }
            */
         
            #endregion
        }

        #endregion


        // хранит последнее удачное направление запуска для режима хода
        private static bool? mLastDirection;
        private static ISignal mTangage;

        /// <summary>
        /// Все частотники выключены
        /// </summary>
        /// <returns></returns>
        private static bool IsAllStopped()
        {
            return ((Invertors.Count(s => s.Status == EngineStatus.Stopped) == Invertors.Count));
        }

        /// <summary>
        /// Все частотники работают и направление совпадает с выбранным
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        private static bool IsMotionContinue(bool direction)
        {
            // TODO: корректно проверять по реальному значению с частотника о направлении движения
            return ((Invertors.Count(s => s.Status == EngineStatus.Activated) == Invertors.Count) && mLastDirection == direction);
        }

        /// <summary>
        /// Поехали
        /// </summary>
        /// <param name="direction"></param>
        private static void Start(bool direction)
        {
            mConnection.Open();
            if (!mConnection.IsOpen()) return;

            // включать можем только в активном режиме
            if (State != SystemState.Active) return;

            switch (Mode)
            {
                case EngineMode.Motion:
                {
                    // при обновлении движения по педали - удерживаем выставленную уставку на скорость
                    ResetMotionSpeedToMin.Stop();
                                     
                    // запускаемся только если все двигателя до этого были нормально остановлены
                    if (IsAllStopped())
                    {
                        foreach (var invertor in Invertors)
                        {
                            invertor.Direction(direction);
                        }

                        UpdateMotionFrequencies();       

                        mLastDirection = direction;
                        mUz2.On(true);
                    }
                    else
                    {
                        if (IsMotionContinue(direction))
                        {
                            UpdateMotionFrequencies();       

                            mUz2.On(true);                            
                        }
                        else
                        {
                            // нажата другая педаль, но мы еще не остановились по предыдущему направлению
                            // поэтому останавливаем и как только все остановится - то начнется движение в другую сторону
                            Stop();
                        }
                    }
                }
                break;


                /*
                case EngineMode.Conveyor:
                {
                    var freq = ((ushort)ConveyorFrequencies[mConveyorSpeed.ValueAsInt].ValueAsInt);
                    freq = (ushort)(freq < 100 ? 100 : freq);      
                    mConveyor.Frequency(freq);
                    
                    // всегда в одну сторону - только вперед :)
                    // запускаемся только если все до этого были нормально остановлены
                    if (!IsAllStopped()) return;                 
                    
                    mConveyor.Direction(true);
                    mConveyor.On(false);
                }
                break;
                */
            }
        }

        /// <summary>
        /// Остановливаем частотники
        /// </summary>
        private static void Stop()
        {            
            // выставляем скорость в 2 Гц перед тем, как полностью остановить - для преотвращения выбега
            mUz2.Frequency(200);
            mUz3.Frequency(200);
            mUz4.Frequency(200);
            mUz5.Frequency(200);

            // защита от выбега
            if (Invertors.Count(s => s.Status == EngineStatus.Failure) > 0)
            {
                mUz2.Off(true);
                mLastDirection = null; // выставляем неопределенное состояние, обозначающее, что у нас была остановка
            }
            else
            {
                if (Mode == EngineMode.Motion)
                {
                    if (Invertors.Count(s => s.GetFrequency() <= 200) == Invertors.Count)
                    {
                        mUz2.Off(true);
                        mLastDirection = null; // выставляем неопределенное состояние, обозначающее, что у нас была остановка                    
                    }                    
                }
                /*
                else if(Mode == EngineMode.Conveyor)
                {
                    //Console.WriteLine("conveyor try stop");
                    if (mConveyor.GetFrequency() <= 200)
                    {
                        mConveyor.Off(false);
                        //Console.WriteLine("conveyor STOP");
                        // TODO: это не должно быть тут, но поставил для напоминания - не помню, как по коду сделана проверка направления вращения
                        mLastDirection = null; // выставляем неопределенное состояние, обозначающее, что у нас была остановка                    
                    }
                }
                */
                else
                {
                    mUz2.Off(true);
                }
            }

            // если мы в режиме хода - то начинем процедуру сброса скорости на минимальную                
            if (Mode != EngineMode.Motion) return;
            if (!ResetMotionSpeedToMin.IsStart)
                ResetMotionSpeedToMin.Start();
        }

        /// <summary>
        /// Событие по аварии
        /// </summary>
        public static Action<SystemStateCodes.Alarm> OnError;

        private static ISignal mEncoder;

        /// <summary>
        /// Режим работы двигателей (остановлены, ход или конвейер)
        /// </summary>
        public static EngineMode Mode { get; private set; }

        /// <summary>
        /// Текущее состояние
        /// </summary>
        public static SystemState State { get; private set; }

        /// <summary>
        /// Выставляем режим работы частотников
        /// </summary>
        /// <param name="mode"></param>
        public static bool SetMode(EngineMode mode)
        {
            switch (mode)
            {
                case EngineMode.Deactivate:
                    {
                        Mode = mode;

                        // сбрасывааем скорость для режима ХОД
                        mMotionSpeed.Update(0);
                    }
                    break;

                case EngineMode.Motion:
                //case EngineMode.Conveyor:
                    {
                        if (Mode == EngineMode.Deactivate)
                        {
                            Mode = mode;
                        }
                    }
                    break;
            }

            return mode == Mode;
        }

        /// <summary>
        /// Сбрасываем ошибку на частотниках
        /// </summary>
        public static void ResetFault()
        {
            mIsNeedResetFault = true;
            mConveyorState.Update((uint)EquipmentState.Stop);
        }

        /// <summary>
        /// Поднимаем скорость на одну ступеньку
        /// </summary>
        /// <param name="mode"></param>
        public static void SpeedUp(EngineMode mode)
        {
            switch (mode)
            {
                case EngineMode.Motion:
                    {
                        if (mMotionSpeed.Value < kMotionSpeedCount - 1)
                            mMotionSpeed.Update(mMotionSpeed.Value + 1);
                    }
                    break;

                    /*
                case EngineMode.Conveyor:
                    {
                        if (mConveyorSpeed.Value < kConveyorSpeedCount - 1)
                            mConveyorSpeed.Update(mConveyorSpeed.Value + 1);
                    }
                    break;
                     */
            }

            mJournal.Debug(string.Format("Установлена скорость: {0}:{1}", mode, mode == EngineMode.Motion ? mMotionSpeed.ValueAsInt : mConveyorSpeed.ValueAsInt), MessageLevel.System);
        }

        /// <summary>
        /// Опускаем скорость на одну ступеньку
        /// </summary>
        /// <param name="mode"></param>
        public static void SpeedDown(EngineMode mode)
        {
            switch (mode)
            {
                case EngineMode.Motion:
                    {
                        if (mMotionSpeed.Value > 0)
                            mMotionSpeed.Update(mMotionSpeed.Value - 1);
                    }
                    break;

                /*
                case EngineMode.Conveyor:
                    {
                        if (mConveyorSpeed.Value > 0)
                            mConveyorSpeed.Update(mConveyorSpeed.Value - 1);
                    }
                    break;
                 */
            }

            mJournal.Debug(string.Format("Снижена скорость: {0}:{1}", mode, mode == EngineMode.Motion ? mMotionSpeed.ValueAsInt : mConveyorSpeed.ValueAsInt), MessageLevel.System);
        }

        /// <summary>
        /// Поднимаем скорость на одну ступеньку
        /// </summary>
        public static void ConveyorSpeedUp()
        {         
            if (mConveyorSpeed.Value < kConveyorSpeedCount - 1)            
                mConveyorSpeed.Update(mConveyorSpeed.Value + 1);

            if(mIsConveyorActive)
                ConveyorOn();

            //mJournal.Debug(string.Format("speed up: {0}:{1}", mode, mode == EngineMode.Motion ? mMotionSpeed.ValueAsInt : mConveyorSpeed.ValueAsInt), MessageLevel.System);
        }

        /// <summary>
        /// Опускаем скорость на одну ступеньку
        /// </summary>
        public static void ConveyorSpeedDown()
        {
            if (mConveyorSpeed.Value > 0)            
                mConveyorSpeed.Update(mConveyorSpeed.Value - 1);

            if(mIsConveyorActive)
                ConveyorOn();

            //mJournal.Debug(string.Format("speed down: {0}:{1}", mode, mode == EngineMode.Motion ? mMotionSpeed.ValueAsInt : mConveyorSpeed.ValueAsInt), MessageLevel.System);
        }


        private static bool mIsConveyorActive;
        public static void ConveyorOn()
        {
            switch (mConveyorSpeed.ValueAsInt)
            {
                case 0:
                {
                    mKv10.Off();
                    mKv9.On();
                }
                break;
                    
                case 1:
                {
                    mKv9.Off();
                    mKv10.On();
                }
                break;
            }

            mIsConveyorActive = true;             

            //mKv10.On();
        }

        public static int GetConveyorCurrentSpeed()
        {
            return mConveyorSpeed.ValueAsInt;
        }

        public static void ConveyorOn(int speed)
        {

            mConveyorSpeed.Update(speed);
            switch (mConveyorSpeed.ValueAsInt)
            {
                case 0:
                    {
                        mKv10.Off();
                        mKv9.On();
                    }
                    break;

                case 1:
                    {
                        mKv9.Off();
                        mKv10.On();
                    }
                    break;
            }

            mIsConveyorActive = true;

            //mKv10.On();
        }

        public static void ConveyorOff()
        {
            mIsConveyorActive = false;

            mKv9.Off();
            mKv10.Off();
        }
    }




    public enum EngineMode
    {
        /// <summary>
        /// Режим ожидания
        /// </summary>
        Deactivate,

        /// <summary>
        /// Режим хода
        /// </summary>
        Motion,

        /// <summary>
        /// Режим конвейера
        /// </summary>
        //Conveyor,
    }
}
