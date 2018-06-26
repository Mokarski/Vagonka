using System.Collections.Generic;
using System.Linq;
using Service.Model;

namespace Service.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly List<Location> _locations = new List<Location>();

        public void Add(Location location)
        {
            _locations.Add(location);
        }

        public List<Location> GetList()
        {
            return _locations;
        }

        public Location GetById(int id)
        {
            return _locations.FirstOrDefault(location => location.Id == id);
        }

        public List<Model.Controller> GetControllers(int id)
        {
            var location = GetById(id);
            if (location != null)
                return location.GetControllersList();

            return new List<Model.Controller>();
        }
    }
}