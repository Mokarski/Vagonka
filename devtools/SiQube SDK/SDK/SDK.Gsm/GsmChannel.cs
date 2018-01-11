using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using SDK.Interfaces;
using log4net;

namespace SDK.Gsm
{
    internal class GsmChannel : IGsmChannel
    {
        private bool mWarnMessageFirstTime = true;
        private readonly ILog mLogger;
        private SerialPort mPort;
        private readonly string mPortName;

        #region Main request/ response methods

        public GsmChannel(ILog log, string portName) 
        {
            mLogger = log;
            mPortName = portName;
        }

        private void InitPort()
        {
            if(mPortName != null)
            mPort = new SerialPort(mPortName, 115200, Parity.None, 8, StopBits.One)
                        {
                            NewLine = "\r\n",
                            ReadTimeout = 500,
                            WriteTimeout = 250,
                            RtsEnable = true
                        };
        }

        public bool ExecuteRequest(string command, out string[] response, TimeSpan timeout)
        {           
            response = new[] { "" };


            if (!IsOpen)
                Open();

            if (!IsOpen)
                return false;

            if (SendRequest(command))
            {
                // порт как минимум открыт, модем включен

                var startAt = DateTime.Now;
                var responseList = new List<string>();

                while (DateTime.Now.Subtract(startAt) < timeout)
                {
                    try
                    {
                        var rv = mPort.ReadLine();

                        // for debug purpose only
                        if (DebugMode)
                            Console.WriteLine(rv);

                        // check for response
                        switch (rv)
                        {
                            case "OK":
                            case "CONNECT":
                                {
                                    response = responseList.ToArray();

                                    if (DebugMode)
                                    {
                                        foreach (var s in response)
                                        {
                                            Console.WriteLine(s);
                                        }
                                    }

                                    return true;
                                }


                            case "ERROR":
                            case "NO CARRIER":
                            case "NO DIALTONE":
                            case "BUSY":
                            case "NO ANSWER":
                                return false;

                            default:
                                {


                                    if (rv.Contains("CME ERROR"))
                                        return false;

                                    if (rv.Contains("OK") || rv.Contains("CONNECT"))
                                    {
                                        response = responseList.ToArray();

                                        if (DebugMode)
                                            foreach (var s in response)
                                                Console.WriteLine(s);

                                        return true;
                                    }
                                }
                                break;
                        }

                        if (!String.IsNullOrEmpty(rv))
                            responseList.Add(rv);

                    }
                    catch (TimeoutException) { }
                    catch (ArgumentNullException)
                    {
                        return false;
                    }
                    catch (InvalidOperationException)
                    {
                        return false;
                    }
                }
            }

            // we have some hardware errors
            if (OnExecuteError != null)
                OnExecuteError();                

            return false;
        }

        public event ExecuteErrorHandler OnExecuteError;

        public void Close()
        {
            Console.WriteLine("GsmChannel close");
            if(mPort != null)
            {
                if (mPort.IsOpen)
                    mPort.Close();
   
                mPort.Dispose();
                mPort = null;
            }
        }

        [DefaultValue(true)]
        public bool DebugMode { get; set; }

        public string PortName
        {
            get
            {
                return mPort != null ? mPort.PortName : String.Empty;
            }
        }

        public void Open()
        {
            if(mPort == null)
                InitPort();
            
            if (mPort != null)
            try
            {
                if(!IsOpen)
                    mPort.Open();
            }
            catch (IOException)
            {
                if (mWarnMessageFirstTime)
                    mLogger.Warn("Cann't create port " + mPort.PortName);

                mWarnMessageFirstTime = false;
            }
            catch (ArgumentException)
            {
                if (mWarnMessageFirstTime)
                    mLogger.Warn("Cann't open port " + mPort.PortName);

                mWarnMessageFirstTime = false;
            }
            catch (UnauthorizedAccessException)
            {
                if (mWarnMessageFirstTime)
                    mLogger.Warn("You are haven't right to open " + mPort.PortName + " port");

                mWarnMessageFirstTime = false;
            }
        }

        public bool IsOpen
        { 
            get
            {
                return mPort != null && mPort.IsOpen;
            }
        }

        private bool SendRequest(string command)
        {
            try
            {
                if (mPort == null)
                    return false;

                // for debug purpose only
                if (DebugMode)
                    Console.WriteLine(command);

                mPort.Write(command + "\r");

                return true;
            }
            catch (IOException)
            {
                mLogger.Debug("SendRequest IOException");
            }
            catch (TimeoutException)
            {
                mLogger.Debug("SendRequest TimeoutException");
            }
            catch (InvalidOperationException)
            {
                mLogger.Debug("SendRequest InvalidOperationException");
            }

            return false;
        }



        #endregion
    }
}