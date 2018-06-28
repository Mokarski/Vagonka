using System.Collections.Generic;

namespace Service.Repositories
{
    public interface IJournalRepository
    {
        void PostReport(Model.JournalReport report);
        List<Model.JournalReport> GetLastReports(int count);
    }
}