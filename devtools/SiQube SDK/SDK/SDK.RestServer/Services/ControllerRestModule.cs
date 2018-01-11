using System;
using System.Text;
using Jayrock.Json;
using Nancy;
using SDK.Rpc.Common;
using Service.DTO;
using Service.Repositories;

namespace Service.Server
{
    public class ControllerRestModule : NancyModule
    {
        private readonly IControllerRepository _controllerRepository;
        private readonly IUpdatesRepository _updatesRepository;

        private bool mIsDebug = false;

        public ControllerRestModule(IControllerRepository controllerRepository, IUpdatesRepository updatesRepository)
            : base("/rest/v1/controllers")
        {
            _controllerRepository = controllerRepository;
            _updatesRepository = updatesRepository;


            Get["/"] = parameters => GetControllers();
            Get["/{imei}"] = parameters => GetController(parameters.imei);
            Get["/{imei}/timetablefile"] = parameters => GetTimeTableFile(parameters.imei);

            Post["/{imei}/jsonrpc"] = parameters => Invoke(parameters.imei, Context.Request);
        }

        private Response GetTimeTableFile(long imei)
        {
            if(mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/controllers/{imei}/timetablefile");
                Console.WriteLine("imei={0}", imei); 
            }


            var controller = _controllerRepository.Find(imei);
            if (controller == null)
                return HttpStatusCode.NotFound;

            // TODO: Стоит ли каждый раз создавать файл обновления??? (может его создание перенести в репозитарий обновления)
            _updatesRepository.UpdateTimeTable(controller);
            return Response.AsFile(_updatesRepository.GetRelativeTimeTableFileName(imei));
        }

        private Response Invoke(long imei, Request request)
        {
            if (mIsDebug)
            {
                Console.WriteLine("POST: /rest/v1/controllers/{imei}/jsonrpc");
                Console.WriteLine("imei={0}", imei);
            }

            
            var controller = _controllerRepository.Find(imei);
            if (controller == null)
                return HttpStatusCode.NotFound;

            var lenght = request.Body.Length;
            var data = new byte[lenght];
            request.Body.Read(data, 0, (int)lenght);

            try
            {
                var jsonRequest = new JsonRequest(Encoding.ASCII.GetString(data));
                if(mIsDebug)
                    Console.WriteLine("request={0}", jsonRequest);

                return Response.AsJson(controller.Invoke(typeof(JsonBuffer), jsonRequest).ToString());
            }
            catch (Exception ex)
            {
                if (!(ex is ArgumentNullException || ex is ArgumentException))
                {
                    // TODO: WTF???
                }
            }

            return HttpStatusCode.BadRequest;
        }
        
        private Response GetControllers()
        {
            if (mIsDebug)
                Console.WriteLine("GET: /rest/v1/controllers");
            
            return Response.AsJson(ControllerDTOConverter.ToDTO(_controllerRepository.GetControllers()));
        }

        private Response GetController(long imei)
        {
            if (mIsDebug)
            {
                Console.WriteLine("GET: /rest/v1/controllers/{imei}");
                Console.WriteLine("imei={0}", imei);    
            }
            Console.WriteLine("GET: /rest/v1/controllers/{imei}");
            Console.WriteLine("imei={0}", imei);

            var controller = _controllerRepository.Find(imei);
            if (controller == null)
                return HttpStatusCode.NotFound;

            return Response.AsJson(ControllerDTOConverter.ToDTO(controller));
        }
    }
}