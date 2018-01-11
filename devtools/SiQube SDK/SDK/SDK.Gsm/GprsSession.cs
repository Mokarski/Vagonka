using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using SDK.Interfaces;
using log4net;


namespace SDK.Gsm
{
    internal class GprsSession : IGprsSession
    {

        private Process mPppd;
        private readonly IGsmHardware mHardware;
        private readonly CellOperators mOperators;
        private bool mWarnMessageFirstTime = true;
        private static ILog mLogger;
        private CellOperatorInfo mActiveOperator;
        private const string kPppdPath = "/sbin/pppd";
        private const int kPppdExitTimeout = 10000; // ms

        public GprsSession(ILog logger, IGsmHardware hardware, CellOperators operators)
        {
            mLogger = logger;
            mHardware = hardware;
            mOperators = operators;
            Disconnect(); // kill all PPPd session from othes processes
        }

        #region Control of PPP session
        public void Connect()
        {
            if (mHardware.IsPowered && !IsConnected)
            {
                try
                {                   
                    #region проверяем, есть ли возможность подключения к gprs
                    var gprsRegistration = mHardware.GprsRegistration;
                    if ((gprsRegistration != 1) && (gprsRegistration != 5))
                        return;
                    #endregion

                    #region пробуем получить информацию об операторе
                    var operatorName = mHardware.OperatorName;
                    if (!String.IsNullOrEmpty(operatorName))
                    {
                        mActiveOperator = mOperators.Get(Convert.ToUInt16(operatorName));
                        if (mActiveOperator == null)
                        {
                            if(mWarnMessageFirstTime)
                                mLogger.Warn("Not available record of cell operator id: " + operatorName);
                                
                            mWarnMessageFirstTime = false;
                            return;
                        }
                    }
                    else
                        return;


                    mLogger.Info(mActiveOperator.ToString());

                    #endregion
                }
                catch (OverflowException) { }
                catch (FormatException) { }
                catch (FileNotFoundException) { }
                catch (DirectoryNotFoundException) { }
                catch (UnauthorizedAccessException) { }
                catch (IOException) { }
                //catch (Exception ex) {mLogger.Debug(ex.ToString());} // test purpose

                if (mActiveOperator != null)
                {
                    #region Try to create GPRS context

                    // ATQ0 V1 E1 S0=0 &C1 &D2 +FCLASS=0
                    // AT+CGDCONT=1,"IP","internet.mts.ru"
                    // ATD*99***1#

                    var connectSequence = new[]
                                              {                                                                                                                       
                                                  "ATQ0 V1 E1 S0=0 &C1 &D2 +FCLASS=0",
                                                  //"AT+CGATT=1",        
                                                  "AT+CGDCONT=1,\"IP\",\"" + mActiveOperator.AccessPoint + "\"",
                                                  "ATD" + mActiveOperator.Phone
                                              };



                    foreach (var command in connectSequence)
                    {
                        string[] response;
                        if (mHardware.DataPort.ExecuteRequest(command, out response, new TimeSpan(0, 0, 60)) == false)
                            return;
                    }

                    #endregion

                    #region Try to start PPPd session
                    //pppd /dev/ttySP0 115200 debug crtscts noauth -detach asyncmap 0 show-password user mts password mts lcp-echo-interval 60 lcp-echo-failure 5 local :10.1.0.1 noipdefault ipcp-accept-local defaultroute usepeerdns novj novjccomp nopcomp noaccomp noccp                      

                    string[] pppdOptions = 
                        {
                            mHardware.DataPort.PortName,
                            "115200",
                            "debug", // comment later
                            //"usepeerdns",
                            //"ms-dns 8.8.8.8",
                            "mru 1350 mtu 1350", // 576
                            "crtscts",
                            "noauth",
                            "-detach",
                            "asyncmap 0",
                            "show-password",
                            "user " + mActiveOperator.Login,
                            "password " + mActiveOperator.Password,
                            "lcp-echo-interval 60 lcp-echo-failure 5",
                            "local :10.1.0.1 noipdefault ipcp-accept-local defaultroute novj novjccomp nopcomp noaccomp noccp"
                        };


                    try
                    {
                        mPppd = null;
                        mPppd = Process.Start(kPppdPath, String.Join(" ", pppdOptions));
                        if (mPppd != null)
                        {
                            mLogger.Info("PppSessionRun succeful run with options: " + String.Join(" ", pppdOptions));
                            Uptime = DateTime.Now;

                            mHardware.DataPort.Close();
                            return;
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        if(mWarnMessageFirstTime)
                            mLogger.Warn("PppSessionRun: Unknown filepath for pppd - " + kPppdPath);

                        mWarnMessageFirstTime = false;
                    }
                    catch (Win32Exception)
                    {
                        if(mWarnMessageFirstTime)
                            mLogger.Warn("PppSessionRun: Win32Exception for pppd - " + kPppdPath);

                        mWarnMessageFirstTime = false;
                    }
                        
                    if(mWarnMessageFirstTime)
                        mLogger.Warn("PppSessionRun: failed run for pppd - " + kPppdPath);

                    mWarnMessageFirstTime = false;

                    #endregion
                }
            }
        }

        public DateTime Uptime
        {
            get; private set;
        }

        public void Disconnect()
        {
            if (mPppd != null)
            {
                try
                {
                    if (mPppd.CloseMainWindow())
                    {
                        mPppd.WaitForExit(kPppdExitTimeout);
                        mPppd.Close();
                        mPppd.Kill();
                    }
                }
                catch (InvalidOperationException) { }
                catch (PlatformNotSupportedException) { }
                catch (NotSupportedException) { }
                catch (Win32Exception) { }
                catch (SystemException) { }
            }

            mPppd = null;
            Thread.Sleep(100);

            // control disconnect
            AllPppSessionStop();
        }

        private static void AllPppSessionStop()
        {
            #region kill all pppd processes
            try
            {
                var processes = Process.GetProcessesByName("pppd");
                if (processes.Length <= 0) return;
                
                foreach (var process in processes)
                {
                    if (!process.CloseMainWindow()) continue;
                    process.WaitForExit(kPppdExitTimeout);
                    process.Kill();
                    process.Close();
                }
            }
            catch (InvalidOperationException) { }
            #endregion
        }
        #endregion

        public bool IsConnected
        {
            get
            {
                try
                {
                    if (mPppd != null) return !mPppd.HasExited;

                    return false;
                }
                catch (InvalidOperationException)
                {
                    return false;
                }
            }
        }

        public void Dispose()
        {
            Disconnect();
        }
    }
}