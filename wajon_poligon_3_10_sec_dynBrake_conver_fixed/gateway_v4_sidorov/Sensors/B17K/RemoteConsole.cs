using System;
using System.Collections.Generic;
using System.Linq;
using Modbus.Data;
using SDK.Interfaces;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.Modbus;

namespace Sensors.B17K
{
    public class RemoteConsole : ITask
    {
        internal class Encoder
        {
            private readonly ISignal mEncoderPoint;
            
            private readonly bool mIsEnabled;
            private readonly ushort[] mCompensationTable;

            private readonly int mZeroPoint;

            public Encoder(ISignalsFactory signals)
            {
                mEncoderPoint = signals.GetSignal("encoder.point");
                
                // TODO: debug only
                /*
                mEncoderPoint.OnChange +=
                    signal =>
                    {
                        if (Math.Abs(signal.ValueAsInt) != 1)
                        {
                            Console.WriteLine("compensation: {0}",
                                signal.ValueAsInt > 0
                                    ? string.Format("right at {0}", signal.Value)
                                    : string.Format("left at {0}", signal.Value));
                        }
                        else
                            Console.WriteLine("compensation set to none");
                    };
                */
                mEncoderPoint.Update(1.0f);
                
                mZeroPoint = signals.GetSignal("encoder.settings.zero").ValueAsInt;                                
                mIsEnabled = signals.GetSignal("encoder.settings.enable").IsSet;

                // load compensation table
                mCompensationTable = new ushort[30];
                mCompensationTable[0] = 0;
                for (var i = 1; i < mCompensationTable.Length; i++)
                    mCompensationTable[i] = (ushort) signals.GetSignal("encoder.settings.limit." + i).ValueAsInt;
            }

            public void UpdateAngle(ushort data)
            {

                int rv;
                if (data >= mZeroPoint)
                    rv = (data - mZeroPoint);
                else
                    rv = (1024 + data - mZeroPoint);

                if (rv > 512)
                    rv = ~(1023 - rv);

                mEncoderPoint.Update(UpdateCompensation((short)((rv * 360.0) / 1023)));
                
            }

            private float UpdateCompensation(short data)
            {
                const float kNoneCompensation = 1.0f;

                //Console.WriteLine("{0}", data);

                if (mIsEnabled)
                    return kNoneCompensation;

                float rv = Math.Abs(data) >= mCompensationTable.Length ?
                    mCompensationTable[mCompensationTable.Length - 1] :
                    mCompensationTable[Math.Abs(data)];

                rv = rv/100.0f;

                if (data > 0)
                    return rv;
                
                return -rv;
            }
        }


        internal class Sensor
        {
            private readonly ISignal mChannel;
            private readonly ISignal mSignal;

            /// <summary>
            /// Прописываем датчик в общую регистровую карту 
            /// </summary>
            /// <param name="id"></param>
            /// <param name="factory"></param>
            public Sensor(string id, ISignalsFactory factory)
            {
                mSignal = factory.GetSignal(id);
                mChannel = factory.GetSignal(string.Format("{0}.channel", id));
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
                get
                {
                    return mChannel.IsSet;
                }
            }

            /// <summary>
            /// Получить сигнал для последующей работы с ним
            /// </summary>
            /// <returns></returns>
            public ISignal GetSignal()
            {
                return mSignal;
            }
        }


        private readonly IJournal mJournal;
        private readonly SignalsFactory mSignals;
        private readonly int mPort;
        private TcpDatastore mService;
        private static DataStore mDataStore;
        private List<Sensor> mSensors;

        private ISignal mKeyboard;
        private readonly Encoder mEncoder;

        public RemoteConsole(IJournal journal, SignalsFactory signals, int port)
        {
            mJournal = journal;
            mSignals = signals;
            mPort = port;
            mDataStore = new DataStore();

            mEncoder = new Encoder(signals);

            ConfigureSensors();
            ConfigureDataStore();            
        }

        private void ConfigureSensors()
        {
            mDataStore = DataStoreFactory.CreateDefaultDataStore(0, 0, 1200, 1200);

            mSensors = new List<Sensor>
                           {
                               new Sensor(SensorName.Filter(SignalName.Pressure), mSignals),
                               new Sensor(SensorName.Steering(SignalName.Pressure), mSignals),
                               new Sensor(SensorName.Cabel(SignalName.Pressure), mSignals),
                               new Sensor(SensorName.Brake(SignalName.Pressure), mSignals),
                               new Sensor(SensorName.Tank(SignalName.Level), mSignals),
                               new Sensor(SensorName.Tank(SignalName.Temperature), mSignals)
                           };


            mKeyboard = mSignals.GetSignal(SensorName.Keyboard());
            //mSignals.GetSignal(SensorName.Tank(SignalName.Level)).OnUpdate += signal => Console.WriteLine("Level: {0}", signal.Value);
            Keyboard.Init(mKeyboard);



        }

        private void ConfigureDataStore()
        {
            mService = new TcpDatastore(mJournal, mDataStore, 1, mPort);

            mDataStore.DataStoreWrittenTo += (sender, args) =>
                                                 {
                                                     switch (args.ModbusDataType)
                                                     {
                                                         case ModbusDataType.HoldingRegister:
                                                             {
                                                                 //local sensors
                                                                 if (args.StartAddress == 1000)
                                                                 {
                                                                     mKeyboard.Update(args.Data.B[6]);

                                                                     // если отчет содержит данные об угле поворота, то вычисляем его
                                                                     if (args.Data.B.Count > 7)
                                                                     {
                                                                         mEncoder.UpdateAngle(args.Data.B[7]);
                                                                         //mJournal.Warning(string.Format("Update angle sensor: {0}", args.Data.B[7]), MessageLevel.User);
                                                                     }

                                                                     foreach (var sensor in mSensors.Where(sensor => sensor.IsEnable))
                                                                     {
                                                                         sensor.GetSignal().Update(args.Data.B[sensor.GetChannel()]);
                                                                     }
                                                                 }
                                                             }
                                                             break;
                                                     }
                                                 };
        }

        public void Start()
        {
            mService.Start();
        }

        public void Stop()
        {
            mService.Stop();
        }
    }
}
