using System;
using System.IO;
using System.Threading;
using SDK.Common;
using SDK.Interfaces;
using SDK.Prospero.Hardware;
using log4net;

namespace SDK.Gsm
{
    public class GsmHardware : IGsmHardware
    {
        private OutputPort mReset;
        private OutputPort mDtr;
        private IniConfiguration mConfig;
        private readonly ILog mLogger;
        private string mImei;


        public GsmHardware(ILog logger)
        {
            mLogger = logger;
            Init();
        }

        private void Init()
        {
            try
            {
                mConfig = new IniConfiguration(mLogger, "GsmModem.ini");

                // TODO: перенести конфигурацию пинов в INI файл
                mReset = new OutputPort(Pin.Gpio0_21, false); // 21
                mDtr = new OutputPort(Pin.Gpio2_20, true); // 84

                DataPort = new GsmChannel(mLogger, mConfig.GetString("Gprs", "DataPath"));
                DataPort.OnExecuteError += PowerOff;

                AuxPort = new GsmChannel(mLogger, mConfig.GetString("Gprs", "AuxPath"));
            }
            catch (ArgumentException) { }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
            catch (NotSupportedException) { }
            catch (System.Security.SecurityException) { }
        }

        public IGsmChannel DataPort { get; private set; }
        public IGsmChannel AuxPort { get; private set; }

        /*
            at#servinfo
            #SERVINFO: 9,-83,"MTS-RUS","25001",56,9790,00,1,,"II",01,6
             */

        public bool PowerOn()
        {
            mLogger.Debug("PowerOn");
            #region Hardware Reset
            Reset();
            #endregion
           
            IsPowered = false;

            #region Software Init
            {
                try
                {
                    var startupSequence = new[]
                                              {
                                                  "ATZ",  // reset
                                                  "ATE0",  // disable echo
                                                  //"ATX0",   // default by ATX0, ATX4 for debug purpose
                                                  "AT+CLIP=1", // request incoming call number 
                                                  "AT#SIMDET=1", // ignore SIMIN pin and simulate the status СSIM InsertedТ
                                                  "AT+CMEE=2", // enable +CME ERROR: <err> reports, with <err> in verbose format
                                                  "AT#VAUX=1,1",
                                                  "AT#CCLK=\"13/11/12,09:00:00+00,1\"",
                                                  "AT#NITZ=11,0", // see SELINT2 (syncro from BS without Daylight Saving Time)                                                  
                                                  "AT#SLED=2",
                                                  "AT+COPS=0,2",
                                                  "AT#SII=1,115200" // Enable aux port for AT interface (/dev/ttySP2) 
                                              };

                    foreach (var command in startupSequence)
                    {
                        string[] response;
                        if (DataPort.ExecuteRequest(command, out response, new TimeSpan(0, 0, 10))) continue;

                        mLogger.Debug("Modem has problem at software initiliaze");

                        return IsPowered;
                    }

                    
                    Console.WriteLine("Modem is initiliazed: " + Imei); // запрос Imei не убирать
                    mLogger.Debug("Modem is initiliazed: " + Imei); // запрос Imei не убирать

                    IsPowered = true;
                    return IsPowered;
                }
                catch (IOException){}
                catch(ArgumentException){}
                catch(UnauthorizedAccessException){}

                IsPowered = false;
                return IsPowered;
            }
            #endregion
        }

        public void Reset()
        {
            mLogger.Debug("Reset");

            /*
            try
            {
                mReset.Write(true);
                Thread.Sleep(200);
                mReset.Write(false);
                Thread.Sleep(3000);
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
            catch (NotSupportedException) { }
            catch (System.Security.SecurityException) { }
             */
        }

        public void ToCommandMode()
        {
            mLogger.Debug("ToCommandMode");

            try
            {
                mDtr.Write(false);
                Thread.Sleep(100);
                mDtr.Write(true);
                Thread.Sleep(100);
            }
            catch (IOException) { }
            catch (UnauthorizedAccessException) { }
            catch (NotSupportedException) { }
            catch (System.Security.SecurityException) { }
        }


        public bool IsPowered { get; private set; }

        public void PowerOff()
        {
            mLogger.Debug("PowerOff");
            // TODO: аппаратно выключаем
            try
            {
                //File.WriteAllText(mConfiguration.GsmOn, "0");
                Thread.Sleep(1000);
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            IsPowered = false;

            if (DataPort != null)
                    DataPort.Close();

            if (AuxPort != null)
                    AuxPort.Close();
        }

        #region GsmModem Status property
        /// <summary>
        /// Get time of GSM module. Autoupdate from GSM Network BS
        /// </summary>
        public ITimeData NetworkTime
        {
            get
            {
                string[] response;
                if (DataPort.ExecuteRequest("AT#CCLK?", out response, new TimeSpan(0, 0, 5)))
                {
                    if (response.Length > 0)
                    {
                        foreach (var rv in response)
                        {
                            // AT#CCLK?
                            // #CCLK: 02/09/07,22:30:25+04,1
                            try
                            {
                                if (!String.IsNullOrEmpty(rv))
                                    if (rv.Contains("#CCLK:"))
                                    {
                                        var data = rv.Split(new[] { "#CCLK:", "\"", ",", "+", "-" }, StringSplitOptions.RemoveEmptyEntries);
                                        if (data.Length > 3)
                                        {
                                            int year;
                                            int month;
                                            int day;
                                            int hour;
                                            int minutes;
                                            int seconds;
                                            int zone;

                                            #region parse Date
                                            var date = data[1].Split('/');
                                            if (date.Length > 2)
                                            {
                                                year = Int32.Parse(date[0]) + 2000;
                                                month = Int32.Parse(date[1]);
                                                day = Int32.Parse(date[2]);
                                            }
                                            else
                                                return new TimeData();
                                            #endregion

                                            #region parse Time
                                            var time = data[2].Split(':');
                                            if (time.Length > 2)
                                            {
                                                hour = Int32.Parse(time[0]);
                                                minutes = Int32.Parse(time[1]);
                                                seconds = Int32.Parse(time[2]);
                                            }
                                            else
                                                return new TimeData();
                                            #endregion

                                            #region parse TimeZone
                                            if (rv.Contains("+"))
                                                zone = 15 * Int32.Parse(data[3]);
                                            else
                                                zone = -15 * Int32.Parse(data[3]);
                                            #endregion

                                            return new TimeData(new DateTime(year, month, day, hour, minutes, seconds), new TimeSpan(0, zone, 0));
                                        }
                                    }
                            }
                            catch (ArgumentOutOfRangeException ex)
                            {
                                mLogger.Warn("Bad parsing: " + rv, ex);   
                            }                           
                        }
                    }
                }

                return new TimeData();
            }
        }

        public string Imei
        {
            get
            {
                if (!string.IsNullOrEmpty(mImei))
                    return mImei;

                string[] response;
                if (DataPort.ExecuteRequest("AT+CGSN", out response, new TimeSpan(0, 0, 5)))
                {
                    if (response.Length == 1)
                    {
                        mImei = response[0];
                        return mImei;
                    }
                }               
                
                return "";
            }
        }

        public string OperatorName
        {
            get
            {
                string[] response;
                if (DataPort.ExecuteRequest("AT+COPS?", out response, new TimeSpan(0, 0, 30)))
                {
                    if (response.Length > 0)
                    {
                        foreach (var rv in response)
                        {
                            if (!String.IsNullOrEmpty(rv))
                                if(rv.Contains("+COPS:"))
                                    return rv.Split('\"').Length > 1 ? (rv.Split('\"'))[1] : "";
                        } 
                    }
                }

                return "";                                       
            }
        }

        public byte GprsRegistration
        {
            get
            {
                string[] response;
                if (DataPort.ExecuteRequest("AT+CGREG?", out response, new TimeSpan(0, 0, 10)))
                {
                    if (response.Length > 0)
                    {
                        foreach (var rv in response)
                        {
                            if (!String.IsNullOrEmpty(rv))
                                if (rv.Contains("+CGREG:"))
                                    return rv.Split(',').Length > 1 ? Convert.ToByte(rv.Split(',')[1]) : (byte) 4;
                        }
                    }
                }

                return 4;   
            }
        }

        public int Rssi
        {
            get
            {
                string[] response;
                if (AuxPort.ExecuteRequest("AT+CSQ", out response, new TimeSpan(0, 0, 30)))
                {
                    if (response.Length > 0)
                    {
                        foreach (var rv in response)
                        {
                            if (!String.IsNullOrEmpty(rv))
                                if (rv.Contains("+CSQ:"))
                                    return rv.Split(new[] {':', ','}).Length > 1
                                               ? (-113 + Convert.ToByte(rv.Split(new[] {':', ','})[1])*2)
                                               : 99;
                        }
                    }
                }
                return 99;
            }
        }

        #endregion

        public void Dispose()
        {
            PowerOff();

            if(mReset != null)
                mReset.Dispose();

            if (mDtr != null)
                mDtr.Dispose();
        }
    }
}