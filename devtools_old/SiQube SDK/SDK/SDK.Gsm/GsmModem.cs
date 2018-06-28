using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;
using SDK.Common;
using log4net;
using SDK.Interfaces;


namespace SDK.Gsm
{
    public class GsmModem : IGsmModem
    {
        private static ILog mLogger;

        private Thread mConnectThread;
        private bool mThreadIsRun;
        private readonly IniConfiguration mConfig;
        private int mTimeoutPeriod = 1;

        public GsmModem(ILog aLogger)
        {
            mLogger = aLogger;

            mConfig = new IniConfiguration(mLogger, "GsmModem.ini");


            Operators = new CellOperators(); // add hardcoded operators
            AddOperators(); // add operator from config

            Hardware = new GsmHardware(aLogger);
            Session = new GprsSession(aLogger, Hardware, Operators);
        }

        private void AddOperators()
        {
            if (mConfig == null) return;
            
            var id = mConfig.GetInt("ExtraOperator", "Id");
            if(id == null) return;
            
            var login = mConfig.GetString("ExtraOperator", "Login");
            if(login == null) return;

            var password = mConfig.GetString("ExtraOperator", "Password");
            if(password == null) return;
            
            var apn = mConfig.GetString("ExtraOperator", "Apn");
            if(apn == null) return;

            var phone = mConfig.GetString("ExtraOperator", "Phone");
            if(phone == null) return;

            var ussd = mConfig.GetString("ExtraOperator", "Ussd");
            if(ussd == null) return;

            Operators.Add((ushort) id, new CellOperatorInfo(login, password, apn, phone, ussd));
        }


        private ushort SessionTimeout
        {
            get
            {
                if(mConfig != null)
                {
                    var i = mConfig.GetInt("Gprs", "SessionTimeout");
                    if (i != null)
                        return (ushort) (i * mTimeoutPeriod);
                }

                return (ushort) (5 * mTimeoutPeriod);
            }
        }


        public static CellOperators Operators
        {
            get;
            private set;
        }

        // TODO: переписать на использование ExecuteCommand
        /*
        private bool IsRingEvent()
        {
            if (mIsEnabled && !string.IsNullOrEmpty(GetResponse("RING", new TimeSpan(0, 0, 10))))
            {
                var response = GetResponse("+CLIP:", new TimeSpan(0, 0, 15));

                if (!string.IsNullOrEmpty(response))
                    response = (response.Split('\"'))[1];

                GetCommandStatus(new TimeSpan(0, 0, 2)); // get "OK"

                SendRequest("ATH0"); // "кладем трубку"

                //проверка каждой ячейки на равенство...
                if (mConfiguration.AutorizatedNumbers.Any(number => number == response))
                {
                    mObserverService.NotifyObservers(response, ObserverTopics.RingEvent);
                    return true;
                }
            }

            return false;
        }
         */


        #region Library startup/tracking/stop methods
        public void Start()
        {
            mConnectThread = new Thread(ConnectionTracking) { IsBackground = true };
            mConnectThread.Start();

            mLogger.Info("Gsm thread handler run");

        }

        public void Stop()
        {
            if (mConnectThread != null)
            {
                mThreadIsRun = false;
                mLogger.Info("Gsm thread wait stopped");
                while (!mConnectThread.IsAlive) { Thread.Sleep(500); }

                mConnectThread = null;
            }

            mLogger.Info("Gsm modem stopped");
        }

        private void ConnectionTracking()
        {
            mThreadIsRun = true;
            var dnsUpdated = false;

            while (mThreadIsRun)
            {

                #region enable modem hardware
                if(!Hardware.IsPowered)
                {                                               
                    dnsUpdated = false;         
                    Hardware.PowerOn();
                }
                else
                {
                    #region automatic re-connection pppd
                    if (!Session.IsConnected)
                    {
                        // переводим модем в командный режим                     
                        Hardware.ToCommandMode();

                        Session.Connect();
                    }
                    else
                    {
                        if (DateTime.Now.Subtract(Session.Uptime).TotalSeconds > 10 && !dnsUpdated)
                        {
                            // update DNS
                            dnsUpdated = true;
                            Process.Start("/bin/cp", "-f ./resolv.conf /etc/");
                        }

                        // restart session if uptime more then SessionTimeout minutes
                        if (DateTime.Now.Subtract(Session.Uptime).TotalMinutes > SessionTimeout)
                        {
                            var ping = new Ping();
                            var reply = ping.Send("www.ya.ru", 10000);

                            if(reply != null)
                            {
                                if(reply.Status == IPStatus.Success)
                                {
                                    mTimeoutPeriod++;                                   
                                }
                                else
                                {
                                    mTimeoutPeriod = 1;
                                    dnsUpdated = false;
                                    Session.Disconnect(); 
                                }
                            }
                            else
                            {
                                mTimeoutPeriod = 1;
                                dnsUpdated = false;
                                Session.Disconnect(); 
                            }
                        }
                    }
                    #endregion

                    #region get rssi
                    //Console.WriteLine(Hardware.Rssi);
                    #endregion

                }
                #endregion
                
                Thread.Sleep(1000);
            }

            Dispose();
            mLogger.Info("Gsm thread stopped");
        }
        #endregion

        public IGprsSession Session { get; private set; }
        public IGsmHardware Hardware { get; private set; }

        private void Dispose()
        {
            Session.Dispose();
            Hardware.Dispose();
        }
    }
}