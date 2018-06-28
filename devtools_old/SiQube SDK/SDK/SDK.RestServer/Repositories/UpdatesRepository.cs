using System.Collections.Generic;
using System.IO;
using Controller.DTO;
using Controller.DTO.Repositories;
using Service.Configuration;
using Service.DTO;

namespace Service.Repositories
{
    public class UpdatesRepository : IUpdatesRepository
    {
        private readonly ITimeTableRepository _timeTableRepository;
        private readonly IConfiguration _configuration;

        public UpdatesRepository(ITimeTableRepository timeTableRepository, IConfiguration configuration)
        {
            _timeTableRepository = timeTableRepository;
            _configuration = configuration;

            CreateUpdateDirectory();
        }

        private void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
        }

        private void CreateUpdateDirectory()
        {
            CreateDirectory(_configuration.UpdateDirectory);
        }

        public void UpdateTimeTable(Model.Controller controller)
        {
            var repository = CreateXmlTimetableDataRepository(controller);
            repository.Save(ToTimeTableData(controller));
        }

        public string GetRelativeTimeTableFileName(long imei)
        {
            return Path.Combine(_configuration.UpdateDirectory, CreateTimeTableFileName(imei));
        }

        private List<TimetableData> ToTimeTableData(Model.Controller controller)
        {
            return TimeTableDataConverter.ToDTO(controller, _timeTableRepository);
        }

        private XmlTimetableDataRepository CreateXmlTimetableDataRepository(Model.Controller controller)
        {
            return new XmlTimetableDataRepository(CreateFullTimeTableFileName(controller));
        }

        private string CreateFullTimeTableFileName(Model.Controller controller)
        {
            return Path.Combine(_configuration.UpdateDirectory, CreateTimeTableFileName(controller.Imei));
        }

        private static string CreateTimeTableFileName(long imei)
        {
            return string.Format("TimeTable_{0}.xml", imei);
        }
    }
}