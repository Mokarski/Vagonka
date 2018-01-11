using Controller.DTO.Services;
using Nancy;
using Nancy.TinyIoc;
using SDK.Rpc.Server;
using Service.Configuration;
using Service.Repositories;

namespace Service.Server
{
    public class RestApiBootstrapper : DefaultNancyBootstrapper
    {
        private readonly RemoteServer _tcpServer;

        public RestApiBootstrapper(RemoteServer tcpServer)
        {
            _tcpServer = tcpServer;
        }

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);

            container.Register<ILocationRepository, XmlLocationRepository>().AsSingleton();
            container.Register<IControllerRepository, XmlControllerRepository>().AsSingleton();
            container.Register<ITimeTableRepository, XmlTimeTableRepository>().AsSingleton();
            container.Register<IUpdatesRepository, UpdatesRepository>().AsSingleton();
            container.Register<IJournalRepository, JournalRepository>().AsSingleton();
            container.Register<ISunScheduleService, SunScheduleService>().AsSingleton();
            
            // TODO: Прокинуть через конструктор
            container.Register<IConfiguration, AppConfiguration>().AsSingleton();
            container.Register<IRemoteTcpServer, RemoteServer>(_tcpServer);
        }
    }
}