using System;
using Nancy;
using Service.DTO;
using Service.Model;
using Service.Repositories;

namespace Service.Server
{
    public class PhaseRestModule : NancyModule
    {
        private readonly IControllerRepository _controllerRepository;
        private readonly ITimeTableRepository _timeTableRepository;
        private readonly IUpdatesRepository _updatesRepository;

        private bool mIsDebug = false;

        public PhaseRestModule(IControllerRepository controllerRepository, ITimeTableRepository timeTableRepository, IUpdatesRepository updatesRepository)
            : base("/rest/v1/phases")
        {
            _controllerRepository = controllerRepository;
            _timeTableRepository = timeTableRepository;
            _updatesRepository = updatesRepository;

            Get["/"] = parameters => GetAllPhases();
            Get["/{phase_id}"] = parameters => GetPhase(parameters.phase_id);
            Get["/{phase_id}/timetable/{timetable_id}"] = parameters => ChangePhaseTimeTable(parameters.phase_id, parameters.timetable_id);
            Get["/{phase_id}/timeshift/{timeshift}"] = parameters => ChangePhaseTimeShift(parameters.phase_id, parameters.timeshift);
        }

        private Response GetPhase(int phaseId)
        {
            if(mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/phases/{phase_id}");
                Console.WriteLine("phase_id={0}", phaseId);
            }


            var phase = _controllerRepository.FindPhase(phaseId);
            if (phase != null)
                return Response.AsJson(PhaseDTOConverter.ToDTO(phase));

            return HttpStatusCode.NotFound;
        }

        private Response GetAllPhases()
        {
            if (mIsDebug)
                Console.WriteLine("GET: /rest/v1/phases");

            return Response.AsJson(PhaseDTOConverter.ToDTO(_controllerRepository.GetAllPhases()));
        }

        private Response ChangePhaseTimeTable(int phaseId, int timeTableId)
        {
            if (mIsDebug)
            {
                Console.WriteLine("PUT: /rest/v1/phases/{phase_id}/timetable/{timetable_id}");
                Console.WriteLine("phase_id={0}, timetable_id={1}", phaseId, timeTableId);     
            }


            if (!ValidTimeTable(timeTableId))
                return HttpStatusCode.NotAcceptable;

            var phase = _controllerRepository.FindPhase(phaseId);
            if (phase != null)
            {
                phase.TimeTable = timeTableId;
                UpdateControllerTimeTable(phase);
                return HttpStatusCode.OK;
            }

            return HttpStatusCode.NotFound;
        }

        private void UpdateControllerTimeTable(Phase phase)
        {
            var controller = _controllerRepository.FindController(phase.Id);
            _updatesRepository.UpdateTimeTable(controller);
        }

        private bool ValidTimeTable(int timeTableId)
        {
            return _timeTableRepository.GetById(timeTableId) != null;
        }

        private Response ChangePhaseTimeShift(int phaseId, int timeshift)
        {
            if(mIsDebug)
            {
                Console.WriteLine("PUT: /rest/v1/phases/{phase_id}/timeshift/{timeshift}");
                Console.WriteLine("phase_id={0}, timeshift={1}", phaseId, timeshift);  
            }

            var phase = _controllerRepository.FindPhase(phaseId);
            if (phase != null)
            {
                phase.TimeShift = timeshift;
                UpdateControllerTimeTable(phase);
                return HttpStatusCode.OK;
            }

            return HttpStatusCode.NotFound;
        }
    }
}