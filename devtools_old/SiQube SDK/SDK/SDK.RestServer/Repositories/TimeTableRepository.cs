using System.Collections.Generic;
using Service.Model;

namespace Service.Repositories
{
    public class TimeTableRepository : ITimeTableRepository
    {
        private readonly TimeTables _timeTables = new TimeTables();

        public void Add(TimeTable timeTable)
        {
            _timeTables.Add(timeTable);
        }

        public List<TimeTable> GetList()
        {
            return _timeTables.GetList();
        }

        public TimeTable GetById(int id)
        {
            return _timeTables.Find(id);
        }
    }
}