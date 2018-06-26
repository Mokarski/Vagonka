using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SDK.NetworksServices
{
    /// <summary>
    /// Сервер с поддержкой мультиклиентов
    /// </summary>
    public class MultiThreadServer : IDisposable
    {
        internal struct Settings
        {
            public Settings(int port, int numberConnections, ProtocolType type)
            {
                mPort = port;
                mNumberConnections = numberConnections;
                mType = type;
            }

            public int mPort;
            public int mNumberConnections;
            public ProtocolType mType;
        }

        private readonly List<TcpClient> mClients;
        private Thread mThread;

        public MultiThreadServer()
        {
            mClients = new List<TcpClient>();
            mThread = null;
        }

        /// <summary>
        /// Gets a collection of client sockets.
        /// </summary>
        public IEnumerable<TcpClient> Clients { get { return mClients; } }

        /// <summary>
        /// Returns the status of the server. True means the server is currently 
        /// running and ready to serve any client requests.
        /// </summary>
        public bool IsRunning { get { return (mThread != null && mThread.IsAlive); } }

        /// <summary>
        /// Starts the server to accepts any new connections on the specified port.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="connections"> </param>
        /// <param name="type"> </param>
        public void Start(int port, int connections, ProtocolType type = ProtocolType.Tcp)
        {
            lock (this)
            {
                mThread = new Thread(ServerThread) { IsBackground = true };
                mThread.Start(new Settings(port, connections, type));
            }
        }

        public void Stop()
        {
            if (IsRunning)
            {
                try
                {
                    mThread.Join();
                    mThread.Abort();
                }
                finally
                {
                    lock (mClients)
                    {

                        foreach (var s in mClients)
                        {
                            try
                            {
                                s.Close();
                            }
                            catch (Exception ex) { Console.WriteLine(ex); }
                        }
                        mClients.Clear();
                    }

                    mThread = null;
                }
            }
        }

        /// <summary>
        /// This the main thread of the server that serves all the new 
        /// connections from clients.
        /// </summary>
        /// <param name="state"></param>
        private void ServerThread(object state)
        {
            try
            {
                var server = new TcpListener(new IPEndPoint(IPAddress.Any, ((Settings)state).mPort));
                //var server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ((Settings)state).mType);

                //server.Bind(new IPEndPoint(IPAddress.Any, ((Settings)state).mPort));
                //server.Listen(((Settings)state).mNumberConnections);
                server.Start(((Settings)state).mNumberConnections);

                while (true)
                {
                    var client = server.AcceptTcpClient();

                    var thread = new Thread(ClientThread);// {IsBackground = false};
                    thread.Start(client);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            Stop();
        }

        /// <summary>
        /// внешний обработчик соединения
        /// </summary>
        public Action<TcpClient> SocketProcessing;

        /// <summary>
        /// Each client connection will be served by this thread.
        /// </summary>
        /// <param name="client"></param>
        private void ClientThread(object client)
        {
            var socket = (TcpClient)client;

            lock (mClients)
                mClients.Add(socket);

            try
            {
                if (SocketProcessing != null)
                    SocketProcessing(socket);
            }
            catch (Exception ex) { Console.WriteLine(ex); }
            finally
            {
                lock (mClients)
                    mClients.Remove(socket);
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            Stop();
        }

        #endregion
    }

    /*
    static class SocketExtensions
    {
        public static IEnumerable<Socket> IncommingConnectoins(this Socket server)
        {
            while (true)
            {
                yield return server.Accept(); 
            }
        }
    }
     */
}