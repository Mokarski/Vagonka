using System;
using System.Globalization;
using System.Linq;
using Controller.DTO;
using Controller.DTO.Services;
using Nancy;
using Service.DTO;
using Service.Model;
using Service.Repositories;

namespace Service.Server
{
    public static class NancyQueryHelper
    {
        public static bool HasAnyQueryValues(this NancyContext context, params string[] values)
        {
            return values.Any(x => context.Request.Query[x].HasValue);
        }
    }

    public class TimeTableRestModule : NancyModule
    {
        private const string DayTimeShiftKey = "DayTimeShift";
        private const string NightOnKey = "NightOn";
        private const string NightOffKey = "NightOff";

        private readonly string[] _timeTableKeyValues = new[] { DayTimeShiftKey, NightOnKey, NightOffKey };

        private readonly ITimeTableRepository _timeTableRepository;
        private readonly IControllerRepository _controllerRepository;
        private readonly IUpdatesRepository _updatesRepository;
        private readonly ISunScheduleService _sunScheduleService;

        private bool mIsDebug = false;

        public TimeTableRestModule(ITimeTableRepository timeTableRepository, IControllerRepository controllerRepository, 
            IUpdatesRepository updatesRepository, ISunScheduleService sunScheduleService)
            : base("/rest/v1/timetables")
        {
            _timeTableRepository = timeTableRepository;
            _controllerRepository = controllerRepository;
            _updatesRepository = updatesRepository;
            _sunScheduleService = sunScheduleService;

            Get["/"] = parameters => GetTimeTables();
            Get["/{id}"] = parameters => GetTimeTable(parameters.id);

            Get["/{id}/Set", ctx => ctx.HasAnyQueryValues(_timeTableKeyValues)] = 
                parameters => ChangeTimeTable(parameters.id, Context.Request);
        }

        private Response ChangeTimeTable(int id, Request nancyRequest)
        {
            if(mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/timetables/{id}/Set");
                Console.WriteLine("Id={0}, Set={1}", id, ToValues(nancyRequest)); 
            }


            var timeTable = _timeTableRepository.GetById(id);
            if (timeTable == null)
                return HttpStatusCode.NotFound;
            
            foreach (var key in _timeTableKeyValues)
            {
                string value = nancyRequest.Query[key];
                if (!string.IsNullOrEmpty(value))
                    ChangeTimeTableValue(timeTable, key, value);
            }

            UpdateControllersTimeTable(timeTable.Id);

            return HttpStatusCode.OK;
        }

        private void UpdateControllersTimeTable(int id)
        {
            var controllers = _controllerRepository.GetControllersByTimeTableId(id);
            foreach (var controller in controllers.GetList())
                _updatesRepository.UpdateTimeTable(controller);
        }

        private static string ToValues(Request nancyRequest)
        {
            return nancyRequest.Url.Query.Aggregate("", (current, value) => current + (value.ToString(CultureInfo.InvariantCulture)));
        }

        private void ChangeTimeTableValue(TimeTable timeTable, string key, string value)
        {
            int intValue;
            switch (key)
            {
                case DayTimeShiftKey:
                    if (int.TryParse(value, out intValue))
                        timeTable.DayTimeShift = intValue;
                break;
                case NightOnKey:
                if (int.TryParse(value, out intValue))
                    timeTable.NightOn = intValue;
                break;
                case NightOffKey:
                if (int.TryParse(value, out intValue))
                    timeTable.NightOff = intValue;
                break;
            }
        }

        private Response GetTimeTables()
        {
            if (mIsDebug)
                Console.WriteLine("GET: /rest/v1/timetables");

            return Response.AsJson(TimeTableDTOConverter.ToDTO(_timeTableRepository.GetList(), FindCurrentSunSchedule()));
        }

        private SunSchedule FindCurrentSunSchedule()
        {
            return _sunScheduleService.FindCurrentSunSchedule();
        }

        private Response GetTimeTable(int id)
        {
            if (mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/timetables/{id}");
                Console.WriteLine("Id={0}", id);
            }

            var timeTable = _timeTableRepository.GetById(id);
            if (timeTable != null)
                return Response.AsJson(TimeTableDTOConverter.ToDTO(timeTable, FindCurrentSunSchedule()));

            return HttpStatusCode.NotFound;
        }
    }
}
