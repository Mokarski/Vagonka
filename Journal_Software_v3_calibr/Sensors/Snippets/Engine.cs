using System;
using System.Collections.Generic;
using System.Linq;
using SDK.Common;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Interface;

namespace Sensors.B17K
{
    internal static class Engine
    {
        const int kSpeedCount = 4;

        private static ISignal mEngineSpeed;
        private static ISignal mConveyerSpeed;

        private static ushort mCurrentSpeed = 1;

        private static readonly DelayedTask AcceptCheckout = new DelayedTask(5000);
        
        private static InvertorsService mInvertors;
        private static readonly List<Cord> Cords = new List<Cord>();
        
        // активное включение выпрямителя - заряд включается по включению насоса
        private static Relay mKv1;
        
        // включение в режим хода
        private static Relay mKv8;
        
        // включение в режим конвейера
        private static Relay mKv9;


        
        private static readonly Dictionary<string, ISignal> State = new Dictionary<string, ISignal>();


        private static ISignal mKv1Feedback;
        private static ISignal mKv2Feedback;

        public static void Init(SignalsFactory signals, InvertorsService powers)
        {
            mTaskEngineStop = new DelayedTask(100);
            mTaskEngineStop.OnTimeout += sender => InternalStop();
            
            // active
            mKv1Feedback = signals.GetSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback));

            mKv1Feedback.OnChange += sensor =>
            {
                //Console.WriteLine("mKv1Feedback: {0}", sensor.Value);

                // выключился активный режим выпрямителя
                //if(sensor.Value == 0)
                //   SetState(SystemState.Failure, sensor, args);
            };

            // charge
            mKv2Feedback = signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback));

            mKv2Feedback.OnChange += sensor =>
            {
                //Console.WriteLine("mKv2Feedback: {0}", sensor.Value);

                // включился режим заряда выпрямителя
                /*
                if (sensor.Value > 0)
                {
                    if (mState != SystemState.Init)
                        SetState(SystemState.Failure, sensor, args);
                }
                 */
            };
            
            
            /*
            mEngineSpeed = signals.GetSignal(SensorName.Derivative(SystemName.System, SignalName.Speed)) as LocalOutput;
            if (mEngineSpeed == null)
                throw new Exception("bad signal");

            mEngineSpeed.Set(mCurrentSpeed);
            //mEngineSpeed.OnChange += sensor => Console.WriteLine("Engine speed: {0}", args.Code);
            AcceptCheckout.OnTimeout += sender => mEngineSpeed.Set(mCurrentSpeed);

            mInvertors = powers;

            foreach (var invertor in mInvertors.Invertors)
            {
                invertor.OnError += (sender, args) =>
                                        {
                                            OnErrorCaller(sender, args);

                                            SetInvertorState(sender.Id, 2);
                                        };
            }

            for (var i = 0; i < 4; i++)
            {
                var rv = new Cord(signals.GetSignal(SensorName.Cord((byte)(i + 2))));
                rv.OnChange += sensor =>
                                   {
                                       if (sensor.Value <= 0) return;

                                       Console.WriteLine(sensor.Id);
                                       OnErrorCaller(null, new EngineEventArgs { Sensor = sensor });
                                   };
                Cords.Add(rv);
            }

            mKv8 = new Relay(RelayName.Kv8, signals);
            mKv8.OnError += sensor => OnErrorCaller(null, new EngineEventArgs { Sensor = sensor });

            State.Add(SensorName.Invertor(1), signals.GetSignal(SensorName.Derivative(SystemName.Uz, 2, SignalName.Status)));
            State.Add(SensorName.Invertor(2), signals.GetSignal(SensorName.Derivative(SystemName.Uz, 3, SignalName.Status)));
            State.Add(SensorName.Invertor(3), signals.GetSignal(SensorName.Derivative(SystemName.Uz, 4, SignalName.Status)));
            State.Add(SensorName.Invertor(4), signals.GetSignal(SensorName.Derivative(SystemName.Uz, 5, SignalName.Status)));
             */
        }

        private static void SetInvertorState(string id, int code, bool force = false)
        {
            ISignal state;
            State.TryGetValue(id, out state);
            if (state != null)
                state.Update(code);
        }

        public static void SpeedUp()
        {
            /*
            if (mEngineSpeed.Value < kSpeedCount)
                mEngineSpeed.Set(mEngineSpeed.Value + 1);

            AcceptCheckout.Start();
             */
        }

        public static void SpeedDown()
        {
            /*
            if (mEngineSpeed.Value > 1)
                mEngineSpeed.Set(mEngineSpeed.Value - 1);

            AcceptCheckout.Start();
             */
        }

        public static void SpeedAccept()
        {
            /*
            AcceptCheckout.Stop();
            mCurrentSpeed = (ushort)mEngineSpeed.Value;
            // TODO: uncomment
            foreach (var invertor in mInvertors.Invertors)//.Where(invertor => invertor.Status == EngineStatus.Activated))
            {
                invertor.SetPower(GetSpeed(mCurrentSpeed));
            }
             */
        }

        public static void Forward()
        {
            /*
            if (!IsActive) return;

            foreach (var invertor in mInvertors.Invertors.Where(invertor => !invertor.On(GetSpeed(mCurrentSpeed), true)))
            {
                //OnErrorCaller(invertor, new EngineEventArgs { Code = EngineErrorCode.NoStart });
            }

            //Console.WriteLine("Engine forward");
             */
        }

        public static void Reverse()
        {
            /*
            if (!IsActive) return;

            foreach (var invertor in mInvertors.Invertors.Where(invertor => !invertor.On(GetSpeed(mCurrentSpeed), false)))
            {
                //OnErrorCaller(invertor, new EngineEventArgs { Code = EngineErrorCode.NoStart });
            }

            //Console.WriteLine("Engine reverse");
             */
        }

        private static byte GetSpeed(int value)
        {
            switch (value)
            {
                case 1:
                    return 25;

                case 2:
                    return 50;

                case 3:
                    return 75;

                case 4:
                    return 85;
            }

            return 25;
        }


        private static DelayedTask mTaskEngineStop;
        public static void Stop(ushort timeout = 0)
        {            
            mTaskEngineStop.SetTimeout(timeout);            
            mTaskEngineStop.Start();
        }

        private static void InternalStop()
        {
            /*
            foreach (var invertor in mInvertors.Invertors.Where(invertor => !invertor.Off()))
            {
                //OnErrorCaller(invertor, new EngineEventArgs { Code = EngineErrorCode.NoStop });
            }

            //Console.WriteLine("Engine stop");
             */
        }

        public static void Conveyer(byte speed)
        {
            /*
            if (Cords.Count(s => !s.IsNormal) != 0)
                return;

            foreach (var invertor in mInvertors.Invertors.Where(s => s.Id != SensorName.Invertor(4)))
            {
                invertor.Off();
            }

            var rv = mInvertors.Invertors.FirstOrDefault(s => s.Id == SensorName.Invertor(4));
            if (rv == null)
                return;

            Console.WriteLine("try to start uz5");
            switch (rv.Status)
            {
                case EngineStatus.Stopped:

                    if (!rv.On(GetSpeed(speed), false))
                    {
                        // TODO: uncomment
                        OnErrorCaller(rv, new EngineEventArgs { Code = EngineErrorCode.NoStart });

                        SetInvertorState(rv.Id, 2);
                    }
                    break;
            }
             */
        }

        public static void Activate()
        {
            /*
            if (State.Values.Any(s => s.ValueAsInt == 2))
            {
                //Console.WriteLine("Have fault lock invertors");
                return;                
            }
            
            mKv8.On();

            foreach (var rv in mInvertors.Invertors)
            {
                SetInvertorState(rv.Id, 1);
            }
            */
        }

        public static void Deactivate()
        {
            /*
            Stop();
            mKv8.Off();

            foreach (var rv in mInvertors.Invertors)
            {
                SetInvertorState(rv.Id, 0);
            }
             */
        }

        public static bool IsReady
        {
            get
            {
                /*
                var isCordsOk = Cords.Count(s => !s.IsNormal) == 0;
                var isTransferOk = mInvertors.Invertors.Count(s => s.Status != EngineStatus.Stopped);

                return isCordsOk && isTransferOk == 0;
                 */
                return false;
            }
        }


        public static bool IsActive
        {
            get
            {
                return IsReady && mKv8.IsSwitchOn;
            }
        }

        /*
        private static void OnErrorCaller(IEngine sensor, EngineEventArgs args)
        {
            var handler = OnError;
            if (handler != null) handlersensor;
        }
        */

        public static void ResetFault()
        {
            /*
            foreach (var invertor in mInvertors.Invertors)
            {
                invertor.ResetFault();
                SetInvertorState(invertor.Id, 0, true);

            }
             */
        }
    }
}