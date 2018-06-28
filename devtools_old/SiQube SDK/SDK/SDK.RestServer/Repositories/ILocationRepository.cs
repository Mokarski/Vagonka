using System.Collections.Generic;
using Service.Model;

namespace Service.Repositories
{
    public interface ILocationRepository
    {
        List<Location> GetList();
        Location GetById(int id);
        List<Model.Controller> GetControllers(int id);
    }
}