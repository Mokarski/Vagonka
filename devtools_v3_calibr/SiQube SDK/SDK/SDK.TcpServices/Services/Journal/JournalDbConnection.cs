using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SDK.Common;
using SDK.NetworksServices.Interfaces;

namespace SDK.NetworksServices.Services.Journal
{
    public class JournalDbConnection : SQLiteConnection
    {
        private static JournalDbConnection mInstance;
        private static readonly object SingletonLock = new object();
        private static string DataBaseFile = "journals.db";
        private static string DataBasePathLinux = "/mnt/sdcard";

        private static readonly object RecordsLock = new object();        
        private readonly List<JournalDbRecord> mRecords = new List<JournalDbRecord>();
        private static Thread mThread;

        JournalDbConnection(string databasePath) 
            : base(databasePath, false)
        {
            CreateTable<JournalDbRecord>(CreateFlags.AllImplicit | CreateFlags.AutoIncPK);

            mThread = new Thread(Processing);
            mThread.Start();
        }

        private void Processing()
        {
            while (true)
            {
                try
                {
                    
                    JournalDbRecord[] rv;
                    lock (RecordsLock)
                    {
                        rv = mRecords.ToArray();
                        mRecords.Clear();
                    }

                    if(rv.Length > 0)
                    {
                        InsertAll(rv);
                        //Console.WriteLine("insert {0} records", rv.Length);
                    }

                    
                    Thread.Sleep(500);
                }
                catch (ThreadAbortException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    Insert(new JournalDbRecord
                               {
                                   Level = (int) MessageLevel.System,
                                   Message = ex.ToString(),
                                   Type = (int) MessageType.Fatal,
                                   Time = DateTime.Now
                               });

                    return;
                }
            }
        }

        public void Save(MessageType type, string message)
        {
            lock (RecordsLock)
            {
                mRecords.Add(new JournalDbRecord { Type = (int)type, Time = DateTime.Now, Message = message });
                //Console.WriteLine("save");
            }            
        }

        public JournalMessages GetRecords(JournalCondition condition)
        {            
            var messages = new JournalMessages
                               {
                                   Messages = condition.Reverse
                                           ? GetBeforeTimeRecords(condition)
                                           : GetAfterTimeRecords(condition)
                               };

            return messages;
        }

        public List<JournalMessage> GetBeforeTimeRecords(JournalCondition condition)
        {
            return Convert(Query<JournalDbRecord>("SELECT * FROM JournalDbRecord WHERE Time <= ? ORDER BY Time DESC LIMIT ? ", condition.Time, condition.Limit));
        }

        public List<JournalMessage> GetAfterTimeRecords(JournalCondition condition)
        {
            return Convert(Query<JournalDbRecord>("SELECT * FROM JournalDbRecord WHERE Time >= ? ORDER BY Time ASC LIMIT ?", condition.Time, condition.Limit));
        }

        private List<JournalMessage> Convert(IEnumerable<JournalDbRecord> messages)
        {
            return messages.Where(s => s.Level == (int) MessageLevel.User).Select(message => new JournalMessage
                                                  {
                                                      Type = (MessageType) message.Type, Time = message.Time, Message = message.Message, Level = (MessageType) message.Level
                                                  }).ToList();
        }

        public static JournalDbConnection Instance
        {
            get
            {
                string DataBasePath = DataBaseFile;
                switch (Environment.OSVersion.Platform)
                {
                    case PlatformID.Unix:
                        if (System.IO.File.Exists(DataBasePathLinux + "/" + DataBasePath))
                        {
                            DataBasePath = DataBasePathLinux + "/" + DataBaseFile;
                        } else
                            if (!System.IO.File.Exists(DataBaseFile) && System.IO.Directory.Exists(DataBasePathLinux))
                                {
                                    DataBasePath = DataBasePathLinux + "/" + DataBaseFile;
                                }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Open journal on " + DataBasePath);
                lock (SingletonLock)
                {
                    return mInstance ?? (mInstance = new JournalDbConnection(DataBasePath));
                }
            }
        }

        public override void Dispose()
        {
            mThread.Abort();            
            base.Dispose();
        }
    }
}