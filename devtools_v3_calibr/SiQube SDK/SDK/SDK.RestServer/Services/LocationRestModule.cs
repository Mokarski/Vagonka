using System;
using Nancy;
using Service.DTO;
using Service.Model;
using Service.Repositories;

namespace Service.Server
{
    public class LocationRestModule : NancyModule
    {
        private readonly ILocationRepository _locationRepository;

        private bool mIsDebug = false;

        public LocationRestModule(ILocationRepository locationRepository)
            : base("/rest/v1/locations")
        {
            _locationRepository = locationRepository;

            Get["/"] = parameters => GetAllLocations();
            Get["/{locationid}"] = parameters => GetLocation(parameters.locationid);
            Get["/{locationid}/controllers"] = parameters => GetControllers(parameters.locationid);
            Get["/{locationid}/controllers/{imei}"] = parameters => GetController(parameters.locationid, parameters.imei);

            Get["/{locationid}/controllers/{imei}/phase/{phase_id}/power/{state}"] =
                parameters => ChangePhaseState(parameters.locationid, parameters.imei, parameters.phase_id, parameters.state);

            Get["/{locationid}/controllers/{imei}/phases/power/{state}"] =
                parameters => ChangeAllPhaseState(parameters.locationid, parameters.imei, parameters.state);
        }

        private Response ChangePhaseState(int locationId, long imei, int phaseId, string state)
        {
            //if(mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/locations/{locationid}/controllers/{imei}/phase/{phase_id}/power/{state}");
                Console.WriteLine("locationid={0}, imei={1}, phase_id={2}, state={3}", locationId, imei, phaseId, state);
            }


            bool onCommand;
            if (!TryParsePhaseState(state, out onCommand))
                return HttpStatusCode.NotAcceptable;

            if (ExecutePhaseCommand(FindPhase(locationId, imei, phaseId), onCommand))
                return HttpStatusCode.OK;

            return HttpStatusCode.NotFound;
        }

        private Phase FindPhase(int locationId, long imei, int phaseId)
        {
            var controller = FindController(locationId, imei);
            if (controller == null)
                return null;

            return controller.FindPhaseById(phaseId);
        }

        private static bool TryParsePhaseState(string state, out bool onCommand)
        {
            if (String.Equals(state, "on", StringComparison.OrdinalIgnoreCase))
            {
                onCommand = true;
                return true;
            }

            if (String.Equals(state, "off", StringComparison.OrdinalIgnoreCase))
            {
                onCommand = false;
                return true;
            }

            onCommand = false;
            return false;
        }

        private Response ChangeAllPhaseState(int locationId, long imei, string state)
        {
            //if (mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/locations/{locationid}/controllers/{imei}/phases/power/{state}");
                Console.WriteLine("locationid={0}, imei={1}, state={2}", locationId, imei, state);   
            }


            bool onCommand;
            if (!TryParsePhaseState(state, out onCommand))
                return HttpStatusCode.NotAcceptable;

            var controller = FindController(locationId, imei);
            if (controller != null)
            {
                if (onCommand)
                    controller.On();
                else
                    controller.Off();
                
                return HttpStatusCode.OK;
            }

            return HttpStatusCode.NotFound;
        }

        private bool ExecutePhaseCommand(Phase phase, bool onCommand)
        {           
            if (phase == null)
                return false;

            if (onCommand)
                phase.On();
            else
                phase.Off();

            return true;
        }

        private Response GetController(int locationId, long imei)
        {
            if (mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/locations/{locationid}/controllers/{imei}");
                Console.WriteLine("locationid={0}, imei={1}", locationId, imei);  
            }

            var controller = FindController(locationId, imei);
            if (controller != null)
                return Response.AsJson(ControllerDTOConverter.ToDTO(controller));

            return HttpStatusCode.NotFound;
        }

        Model.Controller FindController(int locationId, long imei)
        {
            var location = _locationRepository.GetById(locationId);
            if (location == null)
                return null;

            return location.FindController(imei);
        }

        private Response GetControllers(int locationId)
        {
            if (mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/locations/{locationid}/controllers");
                Console.WriteLine("locationid={0}", locationId);   
            }

            return Response.AsJson(ControllerDTOConverter.ToDTO(_locationRepository.GetControllers(locationId)));
        }

        private Response GetAllLocations()
        {
            if (mIsDebug) 
                Console.WriteLine("GET: /rest/v1/locations");
            
            return Response.AsJson(DTOConverter.ToDTO(_locationRepository.GetList()));
        }

        private Response GetLocation(int locationId)
        {
            if (mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/locations/{locationid}");
                Console.WriteLine("locationid={0}", locationId);  
            }


            var location = _locationRepository.GetById(locationId);
            if (location != null)
                return Response.AsJson(DTOConverter.ToDTO(location));

            return HttpStatusCode.NotFound;
        }
    }
}