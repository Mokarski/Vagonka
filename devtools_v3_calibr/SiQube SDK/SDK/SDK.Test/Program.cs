using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

using Jayrock.Json;
using Jayrock.JsonRpc;
using SDK.Gsm;
using log4net;

using SDK.Rpc.Common;
using SDK.Rpc.Plugin;
using SDK.Rpc.Server;
using SDK.RestServer;

namespace SDK.Test
{
    class Program
    {
        static void Main()
        {
            var logger = LogManager.GetLogger("application-log");
            log4net.Config.XmlConfigurator.Configure();


            NancyTest(logger);

            //GsmTest(logger);
            //RpcTest(logger);
        }


        internal static void NancyTest(ILog logger)
        {
            var http = new HttpRestServer(logger);
            http.Start();

        }

        class LocalRpcService : BaseService
        {
            [JsonRpcMethod("local.dummy.time")]
            public void GetTime()
            {
                Console.WriteLine("local: {0}", DateTime.Now.ToString(""));
            }

            [JsonRpcMethod("smart.relay")]
            public void Relay(int relayId, int feederId, bool state)
            {
                Console.WriteLine("smart.relay invoke");
            }

        }

        class RemoteRpcService : BaseService
        {
            [JsonRpcMethod("remote.dummy.time")]
            public void GetTime()
            {
                Console.WriteLine("remote: {0}", DateTime.Now.ToString(""));
            }
        }


        class IdentificationService : BaseService
        {
            [JsonRpcMethod("smart.id")]
            public string Id()
            {
                return "111";
               // return "355094042883037";
            }        
        }
        private static string SwapPersonNames()
        {
            var writer = JsonText.CreateWriter(new StringBuilder());
            writer.WriteStartObject();
            writer.WriteMember("id");
            writer.WriteString("12345");
            writer.WriteMember("method");
            writer.WriteString("ru.siqube.itan.swapNames");
            writer.WriteMember("params");
            writer.WriteStartObject();
            writer.WriteMember("p");
            writer.WriteStartObject();
            writer.WriteMember("firstName");
            writer.WriteString("Alex");
            writer.WriteMember("lastName");
            writer.WriteString("Baranov");
            writer.WriteEndObject();
            writer.WriteMember("needChange");
            writer.WriteBoolean(false);
            writer.WriteEndObject();
            writer.WriteEndObject();

            return writer.ToString();
        }


        internal static void RpcTest(ILog logger)
        {
            var loop = true;

            //var modem = new GsmModem(logger);
            //modem.Start();

            var proxy = new ProxyService(logger);
            proxy.Start();


            var server = new ControllerServer(logger, 3302);
            server.Start();



            proxy.AddService(new LocalRpcService());
            proxy.AddService(new IdentificationService());

            var plugin = new Plugin();
            plugin.AddService(new RemoteRpcService());
            plugin.Register("Dummy");


            plugin.Invoke("local.dummy.time");

            /*
            proxy.Invoke(new JsonRequest(0, "local.dummy.time", null));
            proxy.Invoke(new JsonRequest(0, "remote.dummy.time", null));

            proxy.Invoke(new JsonRequest("{\"id\":\"12345\",\"method\":\"smart.relay\",\"params\":{\"relayId\":0, \"feederId\":2, \"state\":true}}"));
            */

            var clientListner = new ServerConnection(logger, proxy, "127.0.0.1", 3300) { ReconnectionTimeout = new TimeSpan(0, 0, 5)};//, RequestGuardtime = new TimeSpan(0, 1, 0)};
            //var clientListner = new ServerConnection(logger, proxy, "92.63.81.70", 3300) { ReconnectionTimeout = new TimeSpan(0, 0, 5) };//, RequestGuardtime = new TimeSpan(0, 1, 0)};
            clientListner.Start();

            while(loop)
            {

                    try
                    {
                        // TODO
                        //server.Invoke("111", new JsonRequest(0, "local.dummy.time", null));

                        //Thread.Sleep(100);

                    }
                    catch (ThreadAbortException)
                    {
                        server.Stop();

                        throw;
                    }
                    catch (Exception ex)
                    {
                        if (!(ex is SocketException || ex is IOException || ex is InvalidOperationException))
                            logger.Warn("Unexpected exception " + ex.GetType() + " at ModuleThread " + ex.Message);

                    }

            }

            plugin.Unregister();

            loop = true;
            while (loop)
            {
                // TODO
                //proxy.Invoke(new JsonRequest(0, "remote.dummy.time", null));
                Thread.Sleep(1000);
            }

            clientListner.Stop();
            proxy.Stop();
            proxy.Dispose();
            //modem.Stop();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        internal static void GsmTest(ILog logger)
        {
            Console.WriteLine("Gsm test");

            var modem = new GsmModem(logger);
            modem.Start();

            Console.ReadLine();
            modem.Stop();
        }
    }
}
