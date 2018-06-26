using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using SDK.Interfaces;
using SDK.NetworksServices.Interfaces;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.Modbus;

namespace SDK.SignalsFactory.Equipment.Wago
{
    public class Coupler : ITask
    {
        private readonly IJournal mJournal;
        private readonly TcpMaster mConnection;

        private readonly Thread mThread;

        public int d493 = 1; // По дифолту модуль 493 считаем есть
        public int d494 = 0;
        public int Read_Cfg_Coupler = 0; // По дифолту модуль 493 считаем есть
        public bool debug = false;

        public Coupler(IJournal journal, string url)
        {
            mJournal = journal;

            mConnection = new TcpMaster(journal, url, 502);

            mThread = new Thread(Update);
        }

        public void Start()
        {
            if (mThread.IsAlive)
                return;

            mThread.Start();
        }

        public void Stop()
        {
            mThread.Abort();
        }

        #region private methods
        private void Update()
        {
            mJournal.Info("Wago coupler started", MessageLevel.System);

            var elapsed = new Stopwatch();
            try
            {
                while (true)
                {
                    const int kPeriod = 250;
                    if (kPeriod > elapsed.ElapsedMilliseconds)
                        Thread.Sleep((int) (kPeriod - elapsed.ElapsedMilliseconds));

                    elapsed.Restart();

                    ModbusTransfer();
                }
            }
            catch (ThreadAbortException)
            {
                mConnection.Close();
                mJournal.Info("Wago coupler stopped", MessageLevel.System);
            }
            catch (Exception e)
            {
                mConnection.Close();
                mJournal.Fatal(e.ToString(), MessageLevel.System);
            }
        }

        
        private void ModbusTransfer()
        {
            try
            {               
                mConnection.Open();

                var rv = mConnection.ReadWriteMultipleRegisters(1, 0, 120, 512, mOutputData); // 120 inputs registers max
                ushort[] mModulesCfg = new ushort[16];
                
                if (Read_Cfg_Coupler == 0) // Проверка что до этого не считывали конфигу каплера
                {   
                    if (rv != null) //проверка открытия сокета модбас к ваго, если открыт то далее
                    {
                        mModulesCfg = mConnection.ReadHoldings(1, 8240, 7);
                        Console.WriteLine("==>>>ModulesCfg[2]=" + mModulesCfg[2]);             

                        for (int i = 0; i < mModulesCfg.Length; i++)
                        {
                            if (debug) Console.WriteLine("ModulesCfg[" + i + "]=" + mModulesCfg[i]);
                            if (mModulesCfg[i] == 493)
                            {
                                Console.WriteLine("Wago 493 module detected:" + mModulesCfg[i]);
                                d493 = 1;
                            }

                            if (mModulesCfg[i] == 494)
                            {
                                Console.WriteLine("Wago 494 module detected:" + mModulesCfg[i]);
                                d494 = 1;
                            }
                        }
                    }
                    
                    Read_Cfg_Coupler = 1; //установить флаг что уже считали конфиг каплера и больше не читать
                   
                }
               /*
                if (mModulesCfg[2] > 0)
                {
                    mModulesCfg = mConnection.ReadHoldings(1, 8240, 7);
                    for (int i = 0; i < mModulesCfg.Length; i++)
                    {
                        Console.WriteLine("ModulesCfg[" + i + "]=" + mModulesCfg[i]);
                    }
                }
                
                */
                #region parse read inputs

                if (rv == null)
                {
                    mConnection.Close();
                    return;
                }

                foreach (var signal in mSignals.Values.Where(s => s.IsReadOnly))
                {
                    signal.UpdateAsModbus(new[]{rv[signal.Index]});
                }

                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} ModbasTransfer Exception caught.", e);
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

        #region ISignalsService

        private readonly Dictionary<string, ModbusDescription> mSignals = new Dictionary<string, ModbusDescription>();

        private const ushort kRegistersLenght = 1024;
        private const ushort kWagoOutputsStart = 512;
        private readonly ushort[] mOutputData = new ushort[120]; // numbers of outputs registers
        private readonly ushort[] mModulesCfg = new ushort[16]; // numbers of outputs registers
        private bool IsValidAddress(SignalType type, ushort address, byte bit)
        {
            var signals = mSignals.Values.Where(s => s.Index == address).ToArray();
            if (signals.Length == 0)
            {
                signals = mSignals.Values.Where(s => s.Index == address - 1).ToArray();
                if (signals.Count(signal => signal.Type == SignalType.Float) > 0)// || signal.Type == SignalType.Uint) > 0)
                    return false;

                // если у нас не однорегистровый сигнал, надо проверить, что нет сигналов ближе, чем через один регистр от стартового
                if (type != SignalType.Ushort || type != SignalType.Bool)
                    if (mSignals.Values.Where(s => s.Index == address + 1).ToArray().Length > 0)
                        return false;

                return true;
            }

            // discreet check
            if (type == SignalType.Bool && signals[0].Type == SignalType.Bool)
                return signals.All(signal => signal.Mask != (1 << bit));

            return false;
        }

        #region backup
        /*
        public void AddFloat(ISignal signal, ushort address, bool isReadOnly = true)
        {
            if (signal == null)
                throw new ArgumentNullException("signal");

            if (!IsValidAddress(SignalType.Float, address, byte.MaxValue))
                throw new ArgumentException();

            var rv = new ModbusDescription(signal, SignalType.Float, mOutputData, address, byte.MaxValue, isReadOnly);
            mSignals.Add(rv.Signal.Id, rv);
        }

        public void AddUint(ISignal signal, ushort address, bool isReadOnly = true)
        {
            if (signal == null)
                throw new ArgumentNullException("signal");

            if (!IsValidAddress(SignalType.Uint, address, byte.MaxValue))
                throw new ArgumentException();

            var rv = new ModbusDescription(signal, SignalType.Uint, mOutputData, address, byte.MaxValue, isReadOnly);
            mSignals.Add(rv.Signal.Id, rv);
        }
        */
        #endregion

        internal void AddInternalUshort(ISignal signal, ushort address, bool isReadOnly = true)
        {
            if (signal == null)
                throw new ArgumentNullException("signal");

            if (address > kRegistersLenght)
                throw new ArgumentOutOfRangeException("address", string.Format("address cann't be more than {0}", kRegistersLenght));

            if (!IsValidAddress(SignalType.Ushort, address, byte.MaxValue))
                throw new ArgumentException();

            var rv = new ModbusDescription(signal, SignalType.Ushort, address, byte.MaxValue, isReadOnly);

            mSignals.Add(rv.Signal.Specification.Id, rv);

            // add action for output signals
            if (isReadOnly)
            {
                if (rv.Index > 120)
                    throw new NotImplementedException("index cann't be more than 120");

                return;
            }

            if (rv.Index > kWagoOutputsStart + 120)
                throw new NotImplementedException("index cann't be more than 120");

            if (rv.Index >= kWagoOutputsStart)
                rv.Signal.OnUpdate += SignalUpdated;

        }

        internal void AddUshort(ISignal signal, ushort address, bool isReadOnly = true)
        {
            if (signal == null)
                throw new ArgumentNullException("signal");

            if (address > kRegistersLenght)
                throw new ArgumentOutOfRangeException("address", string.Format("address cann't be more than {0}", kRegistersLenght));

            if (!IsValidAddress(SignalType.Ushort, address, byte.MaxValue))
                throw new ArgumentException();

            var rv = new ModbusDescription(signal, SignalType.Ushort, address, byte.MaxValue, isReadOnly);
            Add(isReadOnly, rv);
        }

        internal void AddDiscreet(ISignal signal, ushort address, byte bit, bool isReadOnly = true)
        {
            if (signal == null)
                throw new ArgumentNullException("signal");

            if (address > kRegistersLenght)
                throw new ArgumentOutOfRangeException("address", string.Format("address cann't be more than {0}", kRegistersLenght));

            if (!IsValidAddress(SignalType.Bool, address, bit))
                throw new ArgumentException();

            var rv = new ModbusDescription(signal, SignalType.Bool, address, bit, isReadOnly);
            Add(isReadOnly, rv);
        }

        private void Add(bool isReadOnly, ModbusDescription rv)
        {
            mSignals.Add(rv.Signal.Specification.Id, rv);

            // add action for output signals
            if (isReadOnly)
            {
                if(rv.Index > 120)
                    throw new NotImplementedException("index cann't be more than 120");

                return;
            }

            if (rv.Index > kWagoOutputsStart + 120)
                throw new NotImplementedException("index cann't be more than 120");

            if(rv.Index >= kWagoOutputsStart)
                rv.Signal.OnUpdate += SignalUpdated;   
        }

        private void SignalUpdated(IReadonlySignal signal)
        {
            ModbusDescription rv;
            mSignals.TryGetValue(signal.Specification.Id, out rv);

            if(rv == null)
                return;

            var data = rv.GetAsModbus();
            for (var i = 0; i < data.Length; i++)
            {
                if (rv.Type == SignalType.Bool)
                {
                    if(data[i] > 0)
                        mOutputData[rv.Index - 512 + i] |= rv.Mask;
                    else
                        mOutputData[rv.Index - 512 + i] &= (ushort)(~rv.Mask); 
                }
                else
                {
                    mOutputData[rv.Index - 512 + i] = data[i];
                }
            }
        }

        #endregion
        #endregion // private
    }
}
