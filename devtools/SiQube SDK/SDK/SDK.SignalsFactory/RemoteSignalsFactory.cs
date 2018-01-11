using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SDK.Interfaces;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.ProtoChannel.Client;
using SDK.SignalsFactory.ProtoChannel.Interface;

namespace SDK.SignalsFactory
{
    public class RemoteSignalsFactory : IRemoteSignalsFactory, ITask
    {
        private readonly int mUpdateTimeout;
        private readonly SignalsClient mRemoteClient;
        private readonly Thread mThread;
        private readonly List<string> mSubscribedSignals = new List<string>();
        private readonly Dictionary<string, ReadolnySignal> mVerifiedSignals = new Dictionary<string, ReadolnySignal>();
        private readonly Dictionary<string, ReadolnySignal> mUnchekedSignals = new Dictionary<string, ReadolnySignal>();

        private readonly object mProcessingLock = new object();
        private bool mIsSignalsLoad;

        public RemoteSignalsFactory(string url, int updateTimeout)
        {
            mUpdateTimeout = updateTimeout;
            mRemoteClient = new SignalsClient(url);
            mThread = new Thread(Processing);

            Console.WriteLine("RemoteSignalsFactory at {0}", url);
        }

        public IReadonlySignal GetSignal(string id)
        {
            lock (mProcessingLock)
            {
                Console.WriteLine("->> IReadonlySignal GetSignal");
                ReadolnySignal rv;
                mVerifiedSignals.TryGetValue(id, out rv);

                if (rv == null)
                {
                    if (mIsSignalsLoad)
                        Console.WriteLine("WARNING! Signal \"{0}\" not applicable", id);

                    // если мы еще не успели загрузить список сигналов - добавить mockup, позже загрузим реальную спецификацию  
                    // если уже загрузили и его нет в списке - ничего страшного, он просто не будет обновляться
                    mUnchekedSignals.TryGetValue(id, out rv);
                    if (rv != null)
                    {
                        Console.WriteLine("t<<< GetSignal rv != null");
                        return rv;
                    }

                    rv = new ReadolnySignal(id);
                    mUnchekedSignals.Add(id, rv);
                }
                else
                {
                    // добавляем в список для запроса состояния
                    if (!mSubscribedSignals.Contains(id))
                        mSubscribedSignals.Add(id);
                }

                //Console.WriteLine("\t<<- GetSignal");
                return rv;
            }
        }

        public bool Update(IReadonlySignal signal, float value)
        {
            lock (mProcessingLock)
            {
                Console.WriteLine("++ Update SpecificationID Value");
                return mRemoteClient.Update(signal.Specification.Id, value);
            }
        }

        public bool Update(string signalId, float value)
        {
            lock (mProcessingLock)
            {
                Console.WriteLine("-- Update SignalID Value");
                return mRemoteClient.Update(signalId, value);
            }
        }

        public MenuConfigSection GetMenuConfig(string sectionId)
        {
            if (!mIsSignalsLoad)
                return null;
            
            var rv = new MenuConfigSection
            {
                Signals = (from signal in mVerifiedSignals where signal.Value.Specification.IsStorage select signal.Value.Specification.Id).ToArray()
            };


            return rv;
        }

        private void Processing()
        {
            //mJournal.Info("RemoteSignalsFactory started");
            Console.WriteLine("RemoteSignalsFactory started");
            try
            {
                var lastUpdate = DateTime.MinValue;
                while (true)
                {
                    try
                    {
                        
                        if (DateTime.Now.Subtract(lastUpdate).TotalMilliseconds < mUpdateTimeout)
                        {
                            Thread.Sleep(200);
                            continue;
                        }
                        

                        // пробуем получить список сигналов
                        if (!mIsSignalsLoad)
                        {
                            lock (mProcessingLock)
                            {
                                var specs = mRemoteClient.GetSignals();
                                if (specs != null)
                                {
                                    mIsSignalsLoad = true;
                                    foreach (var spec in specs.Specs)
                                    {
                                        ReadolnySignal rv;
                                        if (mUnchekedSignals.ContainsKey(spec.Id))
                                        {
                                            mUnchekedSignals.TryGetValue(spec.Id, out rv);
                                            if (rv == null) continue;

                                            rv.UpdateSpecification(spec);       // обновляем спецификацию
                                            mVerifiedSignals.Add(spec.Id, rv);  // добавляем в список верифицированных сигналов
                                            mSubscribedSignals.Add(spec.Id);    // поскольку его уже запрашивали и он верифицирован, то добавляем в подписку на обновление
                                        }
                                        else
                                        {
                                            rv = new ReadolnySignal(spec);
                                            mVerifiedSignals.Add(spec.Id, rv); // чистый сигнал, который никто не спрашивал
                                        }

                                        rv.Update(new SignalStatus {LastUpdate = spec.SaveAt, Value = spec.Value});
                                    }

                                    if (OnLoad != null)
                                        OnLoad();
                                }
                            }
                        }
                        else
                        {
                            if (mSubscribedSignals.Count == 0)
                            {
                                lastUpdate = DateTime.Now;
                                continue;                                
                            }

                            // если есть списки, то пробуем обновляться по подписанным сигналам
                            lock (mProcessingLock)
                            {
                                var rv = mRemoteClient.GetStatus(new SignalsRequest(mSubscribedSignals));

                                if (rv != null)
                                {
                                    for (var i = 0; i < mSubscribedSignals.Count; i++)
                                    {
                                        ReadolnySignal signal;
                                        mVerifiedSignals.TryGetValue(mSubscribedSignals[i], out signal);

                                        if (signal != null)
                                        {
                                            signal.Update(rv.Signals[i]);
                                            if(signal.Specification.Id == "local.tank.level")
                                                Console.WriteLine("RemoteSignalsFactory TEST SIGNAL");
                                                Console.WriteLine("{0}: local.tank.level: {1}", DateTime.Now.ToString("HH:mm:ss.fff"), signal.Value);
                                               
                                        }
                                    }

                                    if (OnUpdate != null)
                                        OnUpdate();
                                }
                            }
                        }

                        lastUpdate = DateTime.Now;
                    }
                    catch (Exception ex)
                    {
                        //mJournal.Fatal(ex);
                        Console.WriteLine(ex);
                    }
                }
            }
            catch (ThreadAbortException)
            {
                mRemoteClient.Dispose();
                Console.WriteLine("RemoteSignalsFactory stopped thread abort exception");
                //mJournal.Info("RemoteSignalsFactory stopped");
            }
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

        /// <summary>
        /// Событие по обновлению какого-либо количества сигналов
        /// </summary>
        public event Action OnUpdate;
        
        /// <summary>
        /// Событие по загрузке списка сигналов
        /// </summary>
        public event Action OnLoad;

        public void PrintInfo()
        {
            //throw new NotImplementedException();
            return;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Signals map:");
            ReadolnySignal signal;
            var specs = mRemoteClient.GetSignals();
                                if (specs != null)
                                {
                                    
                                    foreach (var spec in specs.Specs)
                                    {
                                        //ReadolnySignal rv;                                                               
                                        //if (rv == null) continue;
                                        //rv.Value;
                                        //Console.WriteLine("\t\t\tvalue: {0}", specs.Specs);
                                        
                                        Console.WriteLine("----\n"+"Description:" + spec.Description + "\n"+spec.Id+" Type:" + spec.Type + "Value:" + spec.Value + "\n"+"---\n");
                                    }
                                }
            
            
            //foreach (var description in mSignals.Values.OrderBy(s => s.Specification.Id))
            //{
              //  Console.ForegroundColor = ConsoleColor.White;
              //  Console.Write("\t{0}", description.Specification.Id);
              //  Console.ForegroundColor = ConsoleColor.Gray;

                //                if (description. == SignalType.Bool)
                //                {
                //                    var bit = 0;
                //                    while ((1 << bit) != description.Mask) { bit++; }
                //                    Console.WriteLine("\n\t\tmap: {1}:{2}\tvalue: {0}", description.Signal.Value, description.Index, bit);
                //                }
                //                else
                //Console.WriteLine("\t\t\tvalue: {0}", description.Value);
           // }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}