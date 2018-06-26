using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ProtoBuf;
using SDK.Common;
using SDK.Interfaces;
using SDK.NetworksServices;
using SDK.NetworksServices.Interfaces;
using SDK.NetworksServices.ProtoBufRemote;
using SDK.SignalsFactory.Interface;
using SDK.SignalsFactory.ProtoChannel;
using SDK.SignalsFactory.ProtoChannel.Interface;

namespace SDK.SignalsFactory
{
    [ProtoContract]
    public class ConfigRecord : SignalSpecification
    {
        public ConfigRecord(SignalSpecification specification)
        {
            Init(specification);
        }

        private void Init(SignalSpecification specification)
        {
            Type = specification.Type;
            Id = specification.Id;
            Depth = specification.Depth;
            Description = specification.Description;
            Range = specification.Range;
            Level = specification.Level;
            IsStorage = specification.IsStorage;
            //DefaultValue = specification.DefaultValue;
        }

        public ConfigRecord()
        {

        }

        /// <summary>
        /// Тип данных
        /// </summary>
        [ProtoMember(1)]
        override public SignalType Type { get; internal set; }

        /// <summary>
        /// Внутреннее название, например hydraulic.brake.pressure
        /// </summary>
        [PrimaryKey, NotNull]
        [ProtoMember(2)]
        override public string Id { get; internal set; }

        /// <summary>
        /// Глубина вложения идентификатора
        /// </summary>
        [ProtoMember(3)]
        override public byte Depth { get; internal set; }

        /// <summary>
        /// Человеческое описание
        /// </summary>
        [ProtoMember(4)]
        override public string Description { get; internal set; }

        /// <summary>
        /// Для строк - все возможные варианты, для числовых значений - три значения, старт, шаг и конец диапазона
        /// </summary>
        [ProtoMember(5)]
        override public string Range { get; internal set; }

        /// <summary>
        /// Уровень доступа
        /// </summary>
        [ProtoMember(6)]
        override public byte Level { get; internal set; }

        /// <summary>
        /// Рантаймовый параметр или конфигурационный?
        /// </summary>
        [ProtoMember(7)]
        override public bool IsStorage { get; internal set; }

        [ProtoMember(8)]
        public float Value { get; set; }
                
        [ProtoMember(9)]
        public DateTime SaveAt { get; set; }
    }

    public class CalibrationRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Index { get; set; }
        [Indexed]
        public string Id { get; set; }
        public float Value { get; set; }
        public float Physical { get; set; }
    }
    public class SignalsFactory : ISignalsFactory, ITask, ISignalsClient
    {
        private readonly IJournal mJournal;
        private static string DataBaseFile = "signals.db";
        private static string DataBasePathLinux = "/mnt/sdcard";
        System.Globalization.CultureInfo en = new System.Globalization.CultureInfo("en-US");

        public bool IsDebug { get; set; }

        #region ISignalsFactory methods
        public ISignal GetSignal(string id)
        {
            Signal rv;
            mSignals.TryGetValue(id, out rv);

            if (IsDebug && rv == null)
                mJournal.Fatal(string.Format("Сигнал не найден: {0}", id), MessageLevel.System);

            return rv;
        }

        public List<ISignal> GetSignalsLocal()
        {
            //mSignals.
            List<ISignal> lst = new List<ISignal>();
            foreach (var description in mSignals)
            {
                lst.Add(description.Value);
            }

            return lst;
        }


        private readonly object mAddSignalLocker = new object();

        public ISignal AddSignal(string id, string description)
        {
            lock (mAddSignalLocker)
            {
                // добавить сигнал в словарь, если его там еще нет - если есть, вернуть существующий при совпадении типа сигнала или нуль
                if (mSignals.ContainsKey(id))
                {
                    Signal signal;
                    mSignals.TryGetValue(id, out signal);
                    return signal;
                }

                var rv = new Signal(id, description);

                // TODO: uncomment for use mDatabase
                
                // выбрать все калибрационные точки из БД и проинициализировать сигнал
                foreach (var point in mDatabase.Table<CalibrationRecord>().Where(s => s.Id == id))
                {
                    rv.AddCalibrationPoint(point.Value, point.Physical);
                }
                

                // по умолчанию самый широкий диапазон значений у float - его и ставим
                rv.Specification.SaveAsFloat(0, false);
                mSignals.Add(id, rv);
                return rv;
            }
        }

        public ISignal AddStored(SignalSpecification specification)
        {
            lock (mAddSignalLocker)
            {
                // добавить сигнал в словарь, если его там еще нет - если есть, вернуть существующий при совпадении типа сигнала или нуль
                if (mSignals.ContainsKey(specification.Id))
                {
                    // сигнал уже когда-то был создан - возможно даже в другой сессии
                    Signal signal;
                    mSignals.TryGetValue(specification.Id, out signal);

                    // TODO: for test purpose only 
                    //if (signal != null)
                    //    DatabaseSignalUpdate(signal);

                    return signal;
                }

                // TODO: uncomment for use mDatabase                
                // У нас еще нет этого сигнала в БД - добавляем
                // добавляем описание и значение в БД
                mDatabase.Insert(new ConfigRecord(specification) { SaveAt = DateTime.Now, Value = specification.DefaultValue, DefaultValue = specification.DefaultValue});
                
                
                var rv = new Signal(specification);
                // по изменению значения обновляем записть в БД
                rv.OnChange += DatabaseSignalUpdate;

                // добавляем в рантаймовую карту
                mSignals.Add(specification.Id, rv);
                return rv;
            }
        }

        private void DatabaseSignalUpdate(IReadonlySignal signal)
        {
            // TODO: uncomment for use mDatabase
            //Console.WriteLine("DBUPDATE: [" + signal.Specification.Range + "] DF [" + signal.Specification.DefaultValue.ToString() + "] V [" + signal.ValueAsInt.ToString() + "]");
            mDatabase.Update(new ConfigRecord(signal.Specification) { Value = signal.Value, SaveAt = DateTime.Now });
        }


        public bool IsCheckCalibrationPointExist(string signalId, string Idpref)
        {
            string dbIdPref = signalId + "." + Idpref;
            // выбрать все калибрационные точки из БД для сигнала и если такая точка есть, то не добавлять
            if (mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref) != null)
                return true;

            return false;
        }

        public bool IsCheckOrLoadCalibrationPointExist(string signalId)
        {
            return this.LoadAllCalibrationPoints(signalId, true);
        }

        public bool GetCalibrationPoint(string signalId, out int min, out int max)
        {
            int rawmin = 0;
            int rawmax = 0;

            Signal rv;
            mSignals.TryGetValue(signalId, out rv);
           // Console.WriteLine("GetCalibr for " + signalId);
            if (rv != null)
            {
                float phy;
                rawmin = (int)rv.GetMinCalibrationPointKeyValue(out phy);
                rawmax = (int)rv.GetMaxCalibrationPointKeyValue(out phy);
                min = rawmin;
                max = rawmax;
                return true;
            }

            min = rawmin;
            max = rawmax;
            return false;
        }

        public bool AddCalibrationPoint(string signalId, string Idpref, int raw, float physical)
        {
            // ATTENTION! На самом деле Raw хранится как float, но специфика получения всех сигналов (измерение) всегда достаточна как int
            // TODO: uncomment for use mDatabase
            string dbIdPref = signalId + "." + Idpref;
            // выбрать все калибрационные точки из БД для сигнала и если такая точка есть, то не добавлять
            if (mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref).Any(point => Math.Abs(point.Value - raw) < 0.0001f))
                return false;

            // добавить калибровочную точку в БД
            mDatabase.Insert(new CalibrationRecord { Id = dbIdPref, Physical = physical, Value = raw });
             
            Signal rv;
            mSignals.TryGetValue(signalId, out rv);
            
            return rv != null && rv.AddCalibrationPoint(raw, physical);
        }

        public bool UpdateCalibrationPointWithoutPhysical(string signalId, string Idpref, int raw)
        {
            return UpdateCalibrationPoint(signalId, Idpref, raw, -1.0f);
        }

        public bool UpdateCalibrationPoint(string signalId, string Idpref, int raw, float physical)
        {
            // ATTENTION! На самом деле Raw хранится как float, но специфика получения всех сигналов (измерение) всегда достаточна как int
            // TODO: uncomment for use mDatabase
            Signal rv = null;
            mSignals.TryGetValue(signalId, out rv);
            if (rv == null) return false;
            string dbIdPref = signalId + "." + Idpref;
            int oldraw = 0;
            float oldphysical = 0.0f;
            

            switch(Idpref)
            {
                case "min":
                    oldraw = (int)rv.GetMinCalibrationPointKeyValue(out oldphysical);
                    break;
                case "max":
                    oldraw = (int)rv.GetMaxCalibrationPointKeyValue(out oldphysical);
                    break;
                default:
                    return false;
            }

            if (oldraw < 0) return false;
            if (physical < 0.0f) physical = oldphysical;

            foreach (var point in mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref))
            {
//                mDatabase.Delete(point);
                point.Physical = physical;
                point.Value = raw;
                mDatabase.InsertOrReplace(point);
                break;
            }


//            mDatabase.Delete(mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref));
            //mDatabase.Update(new CalibrationRecord { Id = dbIdPref, Physical = physical, Value = raw });
            // добавить калибровочную точку в БД
            //mDatabase.Insert(new CalibrationRecord { Id = dbIdPref, Physical = physical, Value = raw });
            bool r = rv.UpdateCalibrationPoint(oldraw, raw, physical);
            if (Environment.OSVersion.Platform != PlatformID.Unix) rv.PrintCalibarationPoints(Idpref);
            return r;
        }


        public bool LoadAllCalibrationPoints(string signalId, bool checkmode = false)
        {

            Signal rv;
            mSignals.TryGetValue(signalId, out rv);
            if (rv == null) return false;
            string dbIdPref = signalId + ".min" ;
            rv.ClearCalibration();
            int c = 0;

            foreach (var point in mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref))
            {
                rv.AddCalibrationPoint(point.Value, point.Physical);
                //Console.WriteLine(dbIdPref + " raw = " + point.Value);
                ++c;
                break;
            }

            if ((c == 0) && checkmode) return false;

            dbIdPref = signalId + ".max";

            foreach (var point in mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref))
            {
                rv.AddCalibrationPoint(point.Value, point.Physical);
                //Console.WriteLine(dbIdPref + " raw = " + point.Value);
                ++c;
                break;
            }

            if (c == 2)
            {
                if (Environment.OSVersion.Platform != PlatformID.Unix) rv.PrintCalibarationPoints();
                return true;
            }

            rv.ClearCalibration();

            return false;
        }

        public bool ClearCalibration(string signalId)
        {
            // очистить все записи калибровки для конкретного сигнала из рантайма и БД        
            // TODO: uncomment for use mDatabase

            string dbIdPref = signalId + ".min";

            foreach (var point in mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref))
            {
                mDatabase.Delete(point);
                break;
            }

            dbIdPref = signalId + ".max";

            foreach (var point in mDatabase.Table<CalibrationRecord>().Where(s => s.Id == dbIdPref))
            {
                mDatabase.Delete(point);
                break;
            }

            Signal rv;
            mSignals.TryGetValue(signalId, out rv);
            if(rv != null)
                rv.ClearCalibration();

            return true;
        }

        public void Add(ISignal signal)
        {
            //throw new NotImplementedException();
        }

        #endregion


        #region debug info
        public void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Signals map:");

            foreach (var description in mSignals.Values.OrderBy(s => s.Specification.Id))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t{0}", description.Specification.Id);
                Console.ForegroundColor = ConsoleColor.Gray;

                //                if (description. == SignalType.Bool)
                //                {
                //                    var bit = 0;
                //                    while ((1 << bit) != description.Mask) { bit++; }
                //                    Console.WriteLine("\n\t\tmap: {1}:{2}\tvalue: {0}", description.Signal.Value, description.Index, bit);
                //                }
                //                else
                Console.WriteLine("\t\t\tvalue: {0}", description.Value);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }

        private String formatFloat(float f, Int16 accuracy = 1)
        {

            if (float.IsNaN(f)) return "0";
            if (f == 0.0f) return "0";
            switch (accuracy)
            {
                case 100:
                    return ((Int32)(f * 100.0f)).ToString();
                case 10:
                    return
                        ((Int32)f).ToString();
                case -1:
                    if (f > 0) return "1";
                    return "0";
                case 0:
                    f /= 10.0f;
                    return ((Int32)f).ToString();
                case 1:
                    f /= 10.0f;
                    return String.Format("{0:0.0}", f, en);
                case 2:
                    f /= 100.0f;
                    return String.Format("{0:0.00}", f, en);
                case 3:
                    f /= 100.0f;
                    return String.Format("{0:0.000}", f, en);
                case 30:
                    return String.Format("{0:0.000}", f / 1000.0f, en);
                default:
                    break;
            }

            return String.Format("{0:0.0}", f, en);

        }


        public string WriteInfo(string FileName )
        {
            string shortfilename = FileName;
            if (FileName.Length < 5)
            {
                shortfilename = "sigfaildump_" + DateTime.Now.ToString("dd_MM_yy_HH_mm") + ".txt";
            }

            string path = DataBasePathLinux + "/" + shortfilename;
            if (File.Exists(path)) File.Delete(path); //удалить если файл есть
            if (!File.Exists(path))  //если его нет, создаем и пишем
            
            
            try
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("local.timestamp.start:" );

                    sw.WriteLine("\t\t\t{0}", System.DateTime.Now);

                    foreach (var description in mSignals.Values.OrderBy(s => s.Specification.Id))
                    {

                        //Console.Write("\t{0}", description.Specification.Id);

                        //Console.WriteLine("\t\t\tvalue: {0}", description.Value);

                        // преобразуем строку в байты
                        //byte[] array = System.Text.Encoding.Default.GetBytes(description.Specification.Id." ".description.Value);
                        // запись массива байтов в файл
                        //fstream.Write(array, 0, array.Length);

                        // Create a file to write to.

                        sw.Write("{0}:", description.Specification.Id);
                        bool s = true;
                        try {
                            sw.WriteLine("\t\t\t{0}", formatFloat(description.Value, description.QtSpecification.accuracy));
                        }
                        catch { s = false; }

                        if (s == false) sw.WriteLine("\t\t\t{0}", description.Value);


                        // преобразуем строку в байты
                        //byte[] array2 = System.Text.Encoding.Default.GetBytes(description.Value);
                        // запись массива байтов в файл
                        //fstream.Write(array2, 0, array.Length);

                    }

                    sw.Write("local.timestamp.end:");

                    sw.WriteLine("\t\t\t{0}", System.DateTime.Now);

                }
            }

            catch (Exception ex)
            {
                return "";
            }

            finally
            {
                
            }
            return shortfilename;
        }
        #endregion

        public SignalsFactory(IJournal journal)
        {
            mJournal = journal;
            mServer = new MultiThreadServer();

            Init();
        }

        private readonly Dictionary<string, Signal> mSignals = new Dictionary<string, Signal>();
        private SQLiteConnection mDatabase;

        public class MyTest
        {
            public int Id { get; set; }
            public string Text { get; set; }
        }

        private void Init()
        {

            string DataBasePath = DataBaseFile;
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                    if (System.IO.File.Exists(DataBasePathLinux + "/" + DataBasePath))
                    {
                        DataBasePath = DataBasePathLinux + "/" + DataBaseFile;
                    }
                    else
                        if (!System.IO.File.Exists(DataBaseFile) && System.IO.Directory.Exists(DataBasePathLinux))
                        {
                            DataBasePath = DataBasePathLinux + "/" + DataBaseFile;
                        }
                    break;
                default:
                    break;
            }

            Console.WriteLine("SQLite3 v{0}", SQLite3.LibVersionNumber());
            mDatabase = new SQLiteConnection(DataBasePath);
            Console.WriteLine("SQLite db " + DataBasePath);
            mDatabase.CreateTable<ConfigRecord>();
            mDatabase.CreateTable<CalibrationRecord>();

            // preload our config
            foreach (var spec in mDatabase.Table<ConfigRecord>())
            {
                var rv = new Signal(spec);
                mSignals.Add(rv.Specification.Id, rv);
                rv.Update(spec.Value);

                // подписываемся на изменения и занесение данных в БД
                rv.OnChange += DatabaseSignalUpdate;
            }
            
        }

        private readonly MultiThreadServer mServer;
        public void Start()
        {
            if (mServer.IsRunning)
                return;

            IsDebug = true;

            mServer.Start(Settings.Port, Settings.NumberOfConnections);

            mServer.SocketProcessing = client =>
            {
                var controller = new RpcController();
                var server = new RpcServer(controller);
                server.RegisterService((ISignalsClient)this);
                
                using (var channel = new TcpClientRpcChannel(controller, client, 5000))
                {
                    channel.Start();
                    channel.OnError = () => Console.WriteLine("-- server droped");

                    while (channel.IsReady) { Thread.Sleep(50); }
                }
            };

            mJournal.Info("Фабрика сигналов запущена", MessageLevel.System);
        }

        public void Stop()
        {
            if (mServer.IsRunning)
                mServer.Stop();

            mJournal.Info("Фабрика сигналов остановлена", MessageLevel.System);
        }

        public SignalsResponse GetStatus(SignalsRequest ids)
        {
            //Console.WriteLine("GetStatus");

            var rv = new SignalsResponse { Signals = new List<SignalStatus>() };

            foreach (var id in ids.Ids)
            {
                var signal = GetSignal(id);
                rv.Signals.Add(signal != null
                    ? new SignalStatus { Value = signal.Value, LastUpdate = signal.LastUpdate, State = signal.State }
                    : new SignalStatus { Value = float.NaN, LastUpdate = DateTime.MinValue, State = SignalState.Failure });
            }

            return rv;
        }

        public SignalSpecificationResponse GetSignals()
        {
            //Console.WriteLine("GetSignals ConfigRecords");

            var rv = new SignalSpecificationResponse { Specs = new List<ConfigRecord>() };
            foreach (var signal in mSignals.Values)
            {
                rv.Specs.Add(new ConfigRecord(signal.Specification) { Value = signal.Value, SaveAt = signal.LastUpdate });
            }

            return rv;
        }

        public bool Update(string id, float value)
        {
            //Console.WriteLine("Update");

            var rv = GetSignal(id);
            if (rv == null) return false;

            rv.Update(value);
            return true;
        }

        public ConfigSectionsResponse GetConfig()
        {
            //Console.WriteLine("GetConfig");

            throw new NotImplementedException();
        }
    }
}