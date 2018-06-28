using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SDK.Rpc.Server;
using Service.Configuration;
using Service.Model;

namespace Service.Repositories
{
    public class XmlControllerRepository : ControllerRepository
    {
        private readonly IConfiguration _configuration;
        private readonly IRemoteTcpServer _remoteTcpServer;
        private readonly IJournalRepository _journal;
        private readonly IUpdatesRepository _updatesRepository;

        public XmlControllerRepository(IConfiguration configuration, IRemoteTcpServer remoteTcpServer, IJournalRepository journal, IUpdatesRepository updatesRepository)
        {
            _configuration = configuration;
            _remoteTcpServer = remoteTcpServer;
            _journal = journal;
            _updatesRepository = updatesRepository;

            Load();
            UpdateTimeTables();
        }

        private void UpdateTimeTables()
        {
            foreach (var controller in GetControllers())
                _updatesRepository.UpdateTimeTable(controller);
        }

        private void Load()
        {
            var doc = XDocument.Load(_configuration.ControllerXmlFileName);
            var controllers = from con in doc.Descendants("Controller") select CreateController(con);
            foreach (var controller in controllers)
                Add(controller);
        }

        private Model.Controller CreateController(XElement element)
        {
            var imei = ParseImei(element);
            return new Model.Controller(imei, ParsePhases(element, imei), _remoteTcpServer, _journal)
            {
                Latitude = ParseLatitude(element),
                Longitude = ParseLongitude(element),
                Name = ParseName(element)
            };
        }

        private double ParseLongitude(XElement element)
        {
            return (double)element.Attribute("Longitude");
        }

        private double ParseLatitude(XElement element)
        {
            return (double)element.Attribute("Latitude");
        }

        private List<Phase> ParsePhases(XElement element, long imei)
        {
            var phases = from phase in element.Elements("Phases").Elements("Phase")
                         select CreatePhase(phase, imei);

            return phases.ToList();
        }

        private Phase CreatePhase(XElement element, long imei)
        {
            return new Phase(ParseId(element), ParseName(element), ParseModbusId(element), _remoteTcpServer, imei)
            {
                TimeTable = ParseInt(element, "TimeTable"),
                TimeShift = ParseInt(element, "TimeShift")
            };
        }

        private int ParseInt(XElement element, string paramName)
        {
            return (int)element.Attribute(paramName);
        }

        private int ParseId(XElement element)
        {
            return ParseInt(element, "Id");
        }

        private string ParseName(XElement element)
        {
            return (string)element.Attribute("Name");
        }

        private long ParseImei(XElement element)
        {
            return (long)element.Attribute("Imei");
        }

        private ushort ParseModbusId(XElement element)
        {
            return (ushort)ParseInt(element, "ModbusId");
        }
    }
}