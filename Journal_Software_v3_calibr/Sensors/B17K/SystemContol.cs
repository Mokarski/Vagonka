using System;
using System.Diagnostics;
using System.Threading;
using SDK.Common;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    // TODO: добавить в карту состояние двигателей, конвейера и насоса (обобщенные)
    public class SystemContol : IDisposable
    {
        private readonly IJournal mJournal;

        private SystemState mState;
        //private SystemState mPreviousState;

        private readonly Thread mThread;

        private bool mIsActionBlock;

        public bool debug = false;

        private bool IsInit()
        {
            if (!Pump.IsReady)
                return false;

            return true;
        }

        private bool IsReady()
        {
            if (mBlockedByPassword.ValueAsInt > 0)
                return false;
            
            if (!Pump.IsActive)
                return false;

            return true;
        }
       
        public SystemContol(IJournal journal, ISignalsFactory signals, bool isdebug = false)
        {
            debug = isdebug;
            mJournal = journal;

            mSystemCode = signals.GetSignal("derivative.system.code");
            mBlockedByPassword = signals.GetSignal("derivative.system.authorize");
            if (debug)
            {
               mBlockedByPassword.OnChange += signal => Console.WriteLine("derivative.system.authorize: {0}", signal.ValueAsInt);
               mSystemCode.OnChange += signal => Console.WriteLine("system.code: {0}", signal.ValueAsInt);
            }


            SetState(SystemState.Init, SystemStateCodes.State.Initialization);

            Pedals.Init(signals);
            SoundAlarm.Init(mJournal, signals);
            
            Pump.Init(mJournal, signals);
            Pump.OnError += code =>
            {
                // TODO: отверить процедуру отключения по ошибке насоса (в теории, выключается все сразу)
                mJournal.Error(string.Format("Защита по маслостанции: {0}", mState), MessageLevel.System);
                SetState(SystemState.Failure, code);
                
                Engine.SetMode(EngineMode.Deactivate);
                Pump.Stop();
            };

            Pump.OnWarning += code => SetState(mState, code);

            switch(Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                    Engine.Init(journal, signals, "/dev/ttySP0", 19200);
                    break;
                default:
                    Engine.Init(journal, signals, "COM1", 19200);
                    break;

            }

            //Engine.Init(journal, signals, "/dev/ttySP1", 38400); // last worked
            //Engine.Init(journal, signals, "/dev/ttySP1", 57600);
            //Engine.Init(journal, signals, "COM38", 38400);
            
            // ошибки частотников, ошибки кордов, ошибки реле kv1, kv8, kv8
            Engine.OnError += code =>
            {
                mJournal.Error(string.Format("Защита по частотникам, кордам, реле: {0}", mState), MessageLevel.System);
                SetState(SystemState.Failure, code);
                Engine.SetMode(EngineMode.Deactivate);

            };

            Pump.OnStop += signal => Engine.SetMode(EngineMode.Deactivate);

            KeyboardInit();

            mThread = new Thread(Update);
            mThread.Start();
        }

        
        private void KeyboardInit()
        {
            var pressLockTime = DateTime.MaxValue;
            
            Keyboard.OnPress += code =>
                                     {
                                         switch (code)
                                         {
                                             #region lock & fault reset
                                             case KeyboardCode.Reserved:
                                                 {

                                                     switch (mState)
                                                     {
                                                         case SystemState.Init:
                                                         case SystemState.Ready:
                                                         case SystemState.Failure:
                                                             {
                                                                 mJournal.Debug(string.Format("Сброс системы: {0}", mState), MessageLevel.System);
                                                                 Pump.ResetFault();
                                                                 Engine.ResetFault();
                                                                 SetState(SystemState.Init, SystemStateCodes.State.Initialization);
                                                             }
                                                             break;
                                                     }
                                                 }
                                                 break;
                                             //now this button is reset
                                             case KeyboardCode.UserLock:
                                                 {
                                                     //pressLockTime = DateTime.Now;
                                                     switch (mState)
                                                     {
                                                         case SystemState.Init:
                                                         case SystemState.Ready:
                                                         case SystemState.Failure:
                                                             {
                                                                 mJournal.Debug(string.Format("Сброс системы: {0}", mState), MessageLevel.System);
                                                                 Pump.ResetFault();
                                                                 Engine.ResetFault();
                                                                 SetState(SystemState.Init, SystemStateCodes.State.Initialization);
                                                             }
                                                             break;
                                                     }
                                                 }
                                                 break;
                                             #endregion

                                             #region engine
                                            // now is speed 4 button
                                             case KeyboardCode.SpeedUp:
                                                 {
                                                     /*switch (mState)
                                                     {
                                                         //case SystemState.Init:
                                                         case SystemState.Ready:
                                                         case SystemState.Active:
                                                             Engine.SpeedUp(EngineMode.Motion);
                                                             break;
                                                     }
                                                      */
                                                     switch (mState)
                                                     {
                                                         // можем запускать только из состояния, когда включен только насос
                                                         case SystemState.Ready:
                                                             {
                                                                 Engine.SetMode(EngineMode.Motion);

                                                                 // если нет блокировок на запуск, то mIsActionBlock == false                                                              
                                                                 if (!mIsActionBlock)
                                                                     SetState(SystemState.Active, SystemStateCodes.State.MotionMode);

                                                                 Engine.Speed4(EngineMode.Motion);
                                                             }

                                                             break;
                                                     }
                                                 }
                                                 break;

                                            // now this is speed 2 button
                                             case KeyboardCode.SpeedDown:
                                                 { 
                                                     /*
                                                     switch (mState)
                                                     {
                                                         
                                                         //case SystemState.Init:
                                                         case SystemState.Ready:
                                                         case SystemState.Active:
                                                             Engine.SpeedDown(EngineMode.Motion);
                                                             break;
                                                       
                                                     }
                                                     */
                                                     switch (mState)
                                                     {
                                                         // можем запускать только из состояния, когда включен только насос
                                                         case SystemState.Ready:
                                                             {
                                                                 Engine.SetMode(EngineMode.Motion);

                                                                 // если нет блокировок на запуск, то mIsActionBlock == false                                                              
                                                                 if (!mIsActionBlock)
                                                                     SetState(SystemState.Active, SystemStateCodes.State.MotionMode);

                                                                 Engine.Speed2(EngineMode.Motion);
                                                             }

                                                             break;
                                                     }
                                                 }
                                                 break;

                                            //now is speed 3 button
                                             case KeyboardCode.MotionStart:
                                                 {
                                                     switch (mState)
                                                     {
                                                         // можем запускать только из состояния, когда включен только насос
                                                         case SystemState.Ready:
                                                             {
                                                                 Engine.SetMode(EngineMode.Motion);

                                                                 // если нет блокировок на запуск, то mIsActionBlock == false                                                              
                                                                 if (!mIsActionBlock)
                                                                     SetState(SystemState.Active, SystemStateCodes.State.MotionMode);
                                                                 
                                                                     Engine.Speed3(EngineMode.Motion);
                                                             }

                                                             break;
                                                     }
                                                 }
                                                 break;

                                             // now is speed1 button
                                             case KeyboardCode.MotionStop: 
                                                 {
                                                     switch (mState)
                                                     {
                                                         // можем запускать только из состояния, когда включен только насос
                                                         case SystemState.Ready:
                                                             {
                                                                 Engine.SetMode(EngineMode.Motion);

                                                                 // если нет блокировок на запуск, то mIsActionBlock == false                                                              
                                                                 if (!mIsActionBlock)
                                                                     SetState(SystemState.Active, SystemStateCodes.State.MotionMode);

                                                                 Engine.Speed1(EngineMode.Motion);
                                                             }

                                                             break;
                                                     }
                                                 }
                                                 break;
                                             #endregion

                                             #region conveyor

                                             case KeyboardCode.ConveyorUp:
                                                 {
                                                     switch (mState)
                                                     {
                                                         case SystemState.Init:
                                                         case SystemState.Ready:
                                                         case SystemState.Active:
                                                             Engine.ConveyorSpeed2();
                                                             Engine.ConveyorOn(1);
                                                             //Engine.SpeedUp(EngineMode.Conveyor);
                                                             break;
                                                     }
                                                 }
                                                 break;

                                             case KeyboardCode.ConveyorDown:
                                                 {
                                                     switch (mState)
                                                     {
                                                         case SystemState.Init:
                                                         case SystemState.Ready:
                                                         case SystemState.Active:
                                                             Engine.ConveyorOn(0);
                                                             Engine.ConveyorSpeed1();
                                                             //Engine.SpeedDown(EngineMode.Conveyor);
                                                             break;
                                                     }
                                                 }
                                                 break;

                                             case KeyboardCode.ConveyorStart:
                                                 {
                                                     if (mState != SystemState.Failure)
                                                     {
                                                         Engine.ConveyorOn(0);
                                                     }
                                                     
                                                     /*
                                                     switch (mState)
                                                     {
                                                         // можем запускать только из состояния, когда включен только насос
                                                         case SystemState.Ready:
                                                             {
                                                                 Engine.SetMode(EngineMode.Conveyor);

                                                                 // если нет блокировок на запуск, то mIsActionBlock == false                                                              
                                                                 if (!mIsActionBlock)
                                                                     SetState(SystemState.Active, SystemStateCodes.State.ConveyorMode);
                                                             }

                                                             break;
                                                     }
                                                     */
                                                 }
                                                 break;

                                             case KeyboardCode.ConveyorStop:
                                             {
                                                 Engine.ConveyorOff();
                                                 /*
                                                     if(Engine.Mode == EngineMode.Conveyor)
                                                     switch (mState)
                                                     {
                                                         case SystemState.Active:
                                                             Engine.SetMode(EngineMode.Deactivate);
                                                             SetState(SystemState.Ready, SystemStateCodes.State.ReadyToUse);
                                                             break;
                                                     }
                                                     */
                                             }
                                                 break;

                                             #endregion

                                             #region pump

                                             case KeyboardCode.PumpStart:
                                                 {
                                                     switch (mState)
                                                     {
                                                         case SystemState.Ready:
                                                             Pump.Start();
                                                             break;
                                                     }
                                                 }
                                                 break;

                                             case KeyboardCode.PumpStop:
                                                 {
                                                     Pump.Stop();
                                                     SetState(SystemState.Init, SystemStateCodes.State.Initialization);
                                                 }
                                                 break;

                                             #endregion

                                             #region alarm

                                             case KeyboardCode.SoundAlarm:
                                                 {
                                                     SoundAlarm.On();
                                                 }
                                                 break;

                                             #endregion
                                         }
                                     };

            Keyboard.OnRelese += code =>
                                      {
                                          switch (code)
                                          {
                                              #region alarm

                                              case KeyboardCode.SoundAlarm:
                                                  {
                                                      SoundAlarm.Off();
                                                  }
                                                  break;

                                              #endregion

                                              #region conveyor
                                                  
                                              case KeyboardCode.ConveyorStart:
                                                  {
                                                      Engine.ConveyorOff();
                                                  }
                                                  break;
                                                   
                                              #endregion
                                            //not used
                                              case KeyboardCode.UserLock:
                                                  {
                                                      /*
                                                      if (DateTime.Now.Subtract(pressLockTime).TotalMilliseconds > 3000)
                                                      {
                                                          mJournal.Debug("Станция заблокирована оператором", MessageLevel.System);
                                                          //SetState(SystemState.UserLock);
                                                      }
                                                       */
                                                  }
                                                  break;
                                          }
                                      };
        }

        private void Update()
        {
            mJournal.Info("Обработчик системы запущен", MessageLevel.System);

            var elapsed = new Stopwatch();
            while (true)
            {
                try
                {
                    const int kPeriod = 50;
                    if (kPeriod > elapsed.ElapsedMilliseconds)
                        Thread.Sleep((int)(kPeriod - elapsed.ElapsedMilliseconds));

                    switch (mState)
                    {
                        case SystemState.Init:
                            {
                                if (IsInit())
                                    SetState(SystemState.Ready, SystemStateCodes.State.ReadyToUse);
                            }
                            break;

                        case SystemState.Ready:
                            {                               
                                mIsActionBlock = !IsReady();
                            }
                            break;

                        case SystemState.Active:
                            {

                            }
                            break;

                        case SystemState.UserLock:
                            {

                            }
                            break;

                        case SystemState.Failure:
                            {
                                Engine.SetMode(EngineMode.Deactivate);
                            }
                            break;
                    }                                        
                }
                catch (ThreadAbortException)
                {
                    mJournal.Info("Обработчик системы остановлен (защита)", MessageLevel.System);
                    return;
                }
                catch (Exception e)
                {
                    mJournal.Fatal(e.ToString(), MessageLevel.System);
                }
            }
        }
        
        private void SetState(SystemState state, SystemStateCodes.State code)
        {
            // либо повторное включение уже установленного режима, либо обновление кода работы, например при предупреждении
            if (mState == state)
            {                
                UpdateSystemCode(code);
                return;
            }

            // блокировка включения активного режима до проверки, что все готово к запуску
            mIsActionBlock = true;

            //mPreviousState = mState;
            mState = state;
            UpdateSystemCode(code);
        }

        private void SetState(SystemState state, SystemStateCodes.Warning code)
        {
            // либо повторное включение уже установленного режима, либо обновление кода работы, например при предупреждении
            if (mState == state)
            {
                UpdateSystemCode(code);
                return;
            }

            // блокировка включения активного режима до проверки, что все готово к запуску
            mIsActionBlock = true;

            //mPreviousState = mState;
            mState = state;
            UpdateSystemCode(code);
        }

        private void SetState(SystemState state, SystemStateCodes.Alarm code)
        {
            // либо повторное включение уже установленного режима, либо обновление кода работы, например при предупреждении
            if (mState == state)
            {
                UpdateSystemCode(code);
                return;
            }

            // блокировка включения активного режима до проверки полной готовности к запуску
            mIsActionBlock = true;

            //mPreviousState = mState;
            mState = state;
            UpdateSystemCode(code);
        }

        private void UpdateSystemCode(SystemStateCodes.State code)
        {                       
            
            if (mState == SystemState.Failure)
                mJournal.Error(string.Format("Состояние (защита) {0} уст. в {1}", mState, code), MessageLevel.System);
            else
                mJournal.Info(string.Format("Состояние {0} уст. в {1}", mState, code), MessageLevel.System);
            

            mSystemCode.Update((uint)code);
        }

        private void UpdateSystemCode(SystemStateCodes.Warning code)
        {
            
            if (mState == SystemState.Failure)
                mJournal.Error(string.Format("Состояние (защита) {0} уст. в {1}", mState, code), MessageLevel.System);
            else
                mJournal.Info(string.Format("Состояние {0} уст. в {1}", mState, code), MessageLevel.System);
            

            mSystemCode.Update((uint)code);
        }

        private void UpdateSystemCode(SystemStateCodes.Alarm code)
        {
            
            if (mState == SystemState.Failure)
                mJournal.Error(string.Format("Состояние (защита) {0} уст. в {1}", mState, code), MessageLevel.System);
            else
                mJournal.Info(string.Format("Состояние {0} уст. в {1}", mState, code), MessageLevel.System);
            

            mSystemCode.Update((uint) code);
        }

        private ISignal mSystemCode;
        private ISignal mBlockedByPassword
;

        public void Dispose()
        {
            mThread.Abort();
        }
    }
}