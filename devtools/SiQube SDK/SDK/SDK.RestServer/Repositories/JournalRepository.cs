using System.Collections.Generic;
using System.IO;
using Service.Model;

namespace Service.Repositories
{
    public class JournalRepository : IJournalRepository
    {
        private readonly List<JournalReport> mReports = new List<JournalReport>();
        private readonly object mSyncJournal = new object();

        public JournalRepository()
        {
            PostReport(new JournalReport(JournalReportType.Info, 0, "Service", "Sevice running"));
        }

        public void PostReport(JournalReport report)
        {
            lock(mSyncJournal)
            {
                mReports.Add(report);
                File.AppendAllText("journal.csv", report.ToCsv());
            }
        }


        public List<JournalReport> GetLastReports(int count)
        {
            var requestCount = (count > mReports.Count) ? mReports.Count : count;
            var data = new JournalReport[requestCount];
            
            lock (mSyncJournal)
            {
                
                mReports.CopyTo(mReports.Count - requestCount, data, 0, requestCount);
            }


            var rv = new List<JournalReport>(data);
            rv.Reverse();

            return rv;
        }
    }
}