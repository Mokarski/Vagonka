using System.Linq;
using System.Xml.Linq;
using Service.Configuration;
using Service.Model;

namespace Service.Repositories
{
    public class XmlTimeTableRepository : TimeTableRepository
    {
        private readonly IConfiguration _configuration;

        public XmlTimeTableRepository(IConfiguration configuration)
        {
            _configuration = configuration;

            Load();
        }

        private void Load()
        {
            var doc = XDocument.Load(_configuration.TimeTableXmlFileName);
            var timeTables = from time in doc.Descendants("TimeTable") select CreateTimeTable(time);
            foreach (var timeTable in timeTables)
                Add(timeTable);
        }

        private TimeTable CreateTimeTable(XElement element)
        {
            return new TimeTable(ParseId(element), ParseName(element))
            {
                DayTimeShift = ParseTime(element, "DayTimeShift"),
                NightOn = ParseTime(element, "NightOn"),
                NightOff = ParseTime(element, "NightOff")
            };
        }

        private int ParseId(XElement element)
        {
            return (int)element.Attribute("Id");
        }

        private string ParseName(XElement element)
        {
            return (string)element.Attribute("Name");
        }

        private int ParseTime(XElement element, string paramName)
        {
            return (int)element.Attribute(paramName);
        }
    }
}