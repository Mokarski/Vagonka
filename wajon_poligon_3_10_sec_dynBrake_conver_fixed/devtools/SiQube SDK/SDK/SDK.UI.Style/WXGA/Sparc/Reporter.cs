using System;
using System.Collections;
using System.Linq;
using SDK.Common;

namespace SDK.UI.Style.WXGA.Sparc
{   
    public class Reporter : SQLiteConnection
    {
        private readonly Report mReport = new Report();
        private readonly PeriodicTask mDumpInterval = new PeriodicTask(60*1000);
        private readonly DateTime mStartAt;

        #region test
        public void TestReports()
        {
            /*
            var data = new ushort[177];

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (ushort)i;
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (ushort)(data.Length - i - 1);
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (ushort)i;
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (ushort)(i * 2);
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = 150;
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = (ushort)(data.Length - i - 1);
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = ushort.MaxValue;
            }
            Add(data);

            for (var i = 0; i < data.Length; i++)
            {
                data[i] = 150;
            }
            Add(data);
            */
        }
        #endregion

        public Reporter(string path)
            : base(path, true)
        {
            Console.WriteLine("open database at {0}", path);
            
            var data = new ushort[177];
            for (var i = 0; i < data.Length; i++)
            {
                data[i] = ushort.MaxValue;
            }           

            mReport.Update(data);
            mStartAt = DateTime.Now;

            CreateTable<Report>(CreateFlags.AllImplicit | CreateFlags.AutoIncPK);

            mDumpInterval.Start();
            mDumpInterval.OnPeriod = () =>
                                         {
                                             if(DateTime.Now.Subtract(mStartAt).TotalSeconds < 30)
                                                 return;

                                             mReport.Time = DateTime.Now;

                                             Add(GetCache(), true);
                                         };

        }

        public Report GetCache()
        {
            lock (mReport)
                return mReport;
        }

        public byte SensorType { get; set; }
        public byte CalculationType { get; set; }

        public void UpdateCache(ushort id, ushort[] pressure)
        {
            lock (mReport)
            {
                var rv = ushort.MaxValue;
                switch (SensorType)
                {
                    case 0:
                        rv = pressure[0];
                        break;
                    case 1:
                        rv = pressure[1];
                        break;
                    case 2:
                        {
                            if (pressure[0] == ushort.MaxValue)
                                rv = pressure[1];
                            else
                            {
                                if (pressure[1] != ushort.MaxValue)
                                    rv = (ushort)((pressure[0] + pressure[1]) / 2);
                                else
                                    rv = pressure[0];                                                                
                            }
                        }
                        break;
                }
                
                if(CalculationType == 0)
                {
                    var last = mReport.GetById(id);
                    if(last == ushort.MaxValue)
                        mReport.UpdateById(id, rv);
                    else
                    {
                        mReport.UpdateById(id, (ushort)((rv + last) / 2));
                    }
                }
                else
                {
                    var last = mReport.GetById(id);
                    if (last == ushort.MaxValue)
                        mReport.UpdateById(id, rv);
                    else
                    {
                        mReport.UpdateById(id, last > rv ? last : rv);
                    }  
                }

            }
        }

        public Report[] QueryReport(DateTime date, byte count, bool downSearch = false)
        {
            if(downSearch)
            {
                return (from s in Table<Report>().OrderByDescending(x => x.Time).Reverse()
                         where s.Time >= date
                         select s).Take(count).Reverse().ToArray();
            }

            return (from s in Table<Report>().OrderByDescending(x => x.Time)
                    where s.Time <= date
                    select s).Take(count).ToArray();
        }

        public void Add(ushort[] data)
        {
            Add(DateTime.Now, data);
        }

        public void Add(DateTime time, ushort[] data)
        {
            var rv = new Report(time, data);
            rv.Save();

            Insert(rv);
        }

        public void Add(Report report, bool skipEmpty)
        {
            report.Save();
            
            if(skipEmpty)
                if(report.Restore().SkipWhile(s => s == ushort.MaxValue).ToArray().Length == 0)
                {
                    Console.WriteLine("skip report");
                    return;                    
                }
    
            Console.WriteLine("add report");
            Insert(report);
        }
    }

    public class Report : IEnumerable
    {
        public string Data { get; set; }
        public DateTime Time { get; set; }

        public ushort[] Restore()
        {
            return mData ?? XpBitConverter.GetUint16(Convert.FromBase64String(Data));
        }

        public void Save()
        {
            if (mData == null)
                return;

            if (mData.Length == 0)
                return;

            var bytes = XpBitConverter.GetBytes(mData);
            Data = Convert.ToBase64String(bytes, 0, bytes.Length);
        }

        public void Update(ushort[] data)
        {
            if (data == null)
                return;

            if (data.Length == 0)
                return;

            mData = new ushort[data.Length];
            data.CopyTo(mData, 0);
        }

        public void UpdateById(ushort id, ushort pressure)
        {
            mData[id] = pressure;
        }

        public ushort GetById(ushort id)
        {
            return mData[id];
        }

        private ushort[] mData;

        public Report(DateTime time, ushort[] data)
        {
            Time = time;
            Update(data);
        }

        public Report() { }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}