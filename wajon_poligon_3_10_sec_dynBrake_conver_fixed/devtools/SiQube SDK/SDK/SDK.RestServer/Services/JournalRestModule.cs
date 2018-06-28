using System;
using Nancy;
using Service.Model;
using Service.Repositories;

namespace Service.Server
{
    public class JournalRestModule : NancyModule
    {
        private readonly IJournalRepository mJournalRepository;
        static private long mReportId;

        private bool mIsDebug = false;

        public JournalRestModule(IJournalRepository journalRepository)
            : base("/rest/v1/journal")
        {
            mJournalRepository = journalRepository;

            Get["/"] = parameters => GetShortlistReports();
        }

        private Response GetShortlistReports()
        {
            if(mIsDebug)
                Console.WriteLine("GET: /rest/v1/journal");

            //GenerateMessageForTest();


            return Response.AsJson(mJournalRepository.GetLastReports(50));
        }

        private void GenerateMessageForTest()
        {
            mJournalRepository.PostReport(new JournalReport(JournalReportType.Info, 355094042883037, "SK261A", "Info type message"));
            mJournalRepository.PostReport(new JournalReport(JournalReportType.Warning, 1, "SK1", "Warning type message"));
            mJournalRepository.PostReport(new JournalReport(JournalReportType.Error, mReportId, "SK" + mReportId++, "Error type message"));
        }
    }
}