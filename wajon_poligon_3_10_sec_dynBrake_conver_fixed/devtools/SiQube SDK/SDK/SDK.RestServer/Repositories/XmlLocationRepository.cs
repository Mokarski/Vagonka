using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Service.Configuration;
using Service.Model;

namespace Service.Repositories
{
    public class XmlLocationRepository : LocationRepository
    {
        private readonly IControllerRepository _repository;
        private readonly IConfiguration _configuration;

        public XmlLocationRepository(IControllerRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;

            Load();
        }

        private void Load()
        {
            var doc = XDocument.Load(_configuration.LocationXmlFileName);
            var locations = from loc in doc.Descendants("Location") select CreateLocation(loc);
            foreach (var location in locations)
		        Add(location);
        }

        private Location CreateLocation(XElement element)
        {
            return new Location(ParseId(element), ParseName(element), 
                _repository.GetControllers(ParseControllers(element)));
        }

        private int ParseId(XElement element)
        {
            return (int)element.Attribute("Id");
        }

        private string ParseName(XElement element)
        {
            return (string)element.Attribute("Name");
        }

        private IEnumerable<long> ParseControllers(XElement element)
        {
            var values = (string)element.Attribute("Controllers");
            var array = values.Split(' '); 
            return array.Select(long.Parse).ToList();
        }
    }
}