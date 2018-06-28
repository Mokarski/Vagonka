using System.Collections.Generic;
using Service.Model;

namespace Service.Repositories
{
    public interface ITimeTableRepository
    {
        List<TimeTable> GetList();
        TimeTable GetById(int id);
    }
}