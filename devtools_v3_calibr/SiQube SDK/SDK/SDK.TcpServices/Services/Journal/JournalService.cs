using System;
using System.Threading;
using SDK.NetworksServices.Interfaces;
using SDK.NetworksServices.ProtoBufRemote;

namespace SDK.NetworksServices.Services.Journal
{
    public class JournalService
    {
        private readonly MultiThreadServer mServer;
        private readonly IJournal mJournal;

        public JournalService(bool isConsoleEnable)
        {
            mServer = new MultiThreadServer();
            mJournal = new SqLiteJournal { IsConsoleEnable = isConsoleEnable };
        }

        public void Start()
        {
            if (mServer.IsRunning)
                return;

            var controller = new RpcController();
            var server = new RpcServer(controller);

            server.RegisterService(mJournal);

            mServer.Start(Settings.Port, Settings.NumberOfConnections);

            mServer.SocketProcessing = client =>
                                           {
                                               using (var channel = new TcpClientRpcChannel(controller, client, 5000))//, "server"))
                                               {
                                                   Console.WriteLine("Server get req RPC DATA ->>");

                                                   channel.Start();
                                                   channel.OnError = () => Console.WriteLine("Error: RPC channel not started: controller RPC,client socket, or port 5000");

                                                   while (channel.IsReady) { Thread.Sleep(50); }

                                                   //Thread.Sleep(3000);

                                                   Console.WriteLine("<<-RPC DATA");
                                               }
                                           };
        }

        public void Stop()
        {
            if (mServer.IsRunning)
                mServer.Stop();
        }

        public IJournal GetJournal()
        {
            return mJournal;
        }
    }
}
