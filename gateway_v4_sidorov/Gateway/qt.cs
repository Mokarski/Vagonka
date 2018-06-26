using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using SDK.NetworksServices.Interfaces;
using SDK.NetworksServices.Services.Journal;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Interface;
using Sensors.B17K;
using SDK.NetworksServices.Client.Journal; //added journal network
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Globalization;

namespace qttcpparser
{

    public class qt
    {
        JournalService mServer;
        SignalsFactory signals;
        IJournal journal;
        Thread qtthread;
        Thread clientread;
        Thread clientwrite;
        TcpListener tcpListener;
        int maxreadtimeout = 10000;
        bool isclient = false;
        bool testmode;
        System.Threading.AutoResetEvent ev;
        HashSet<String> toclient;
        //List<String> toclient;
        List<String> updsignals;
        object lck;
        CultureInfo en;
        int kvant = 80;
        bool usekvant; // отадвать данные порциями


        private void SetDateTimeCommand(string dt)
        {
            string args = "-s '" + dt + "'";
            var proc = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/bin/date",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
            };
            proc.Start();
            args = "-w";
            proc = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "/sbin/hwclock",
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
            };
            proc.Start();
        }

        private void DoCMD(string cmd, string args)
        {
            var proc = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = cmd,
                    Arguments = args,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
            };
            try
            {
                proc.Start();
            }
            catch { }

        }


        private List<string> GetJournalRecords(int start, int count)
        {
            List<string> rcd = new List<string>();
            //var XYZ = new JournalCondition { Limit = 200, Reverse = true, Time = DateTime.Now };
            var XYZ = new JournalCondition { Limit = 200, Reverse = true, Time = DateTime.Now };
            var records = journal.GetRecords(XYZ);
            string dtformat = "dd:MM:yy HH:mm";
            if (records != null)
            {
                int k = 1;
                if ((count == -1) || (count == 0))
                {
                    foreach (var message in records.Messages)
                    {
                        if (k >= start) rcd.Add(message.Time.ToString(dtformat) + "|" + message.Message);
                        ++k;
                    }
                } else
                foreach (var message in records.Messages)
                {
                    if ((k >= start) && (k <= (start + count)))
                    {
                        rcd.Add(message.Time.ToString(dtformat) + "|" + message.Message);
                    }
                    ++k;
                    if (k > (start + count)) break;
                }
                rcd.Add("stop");
            }

            
            return rcd;
        }


        public qt(ref JournalService j, ref SignalsFactory s, ref IJournal ij, bool uskv = true)
        {
            journal = ij;
            mServer = j;
            signals = s;
            isclient = false;
            ev = new AutoResetEvent(false);
            //toclient = new List<string>();
            toclient = new HashSet<String>();
            updsignals = new List<string>();
            lck = new object();
            en = new CultureInfo("en-US");
            usekvant = uskv;
        }


        public void SendSignal(IReadonlySignal s, String pref = "upd")
        {
            if (!isclient) return;
            String snd = s.Specification.Id + "|" + pref + "|";
            if (s.QtSpecification.maxvalcal > 0)
            {
                float pr = s.Value;
                if (pr > 0.0f)
                {
                    switch (s.QtSpecification.accuracy) //  умножаем на 100% и делим потом на 100%
                    {
                        case 3:
                            pr = pr * 0.12f;
                            break;
                        case 2: ;
                            break;
                        default: pr *= 10.0f;
                            break;
                    }
                    pr = pr / (float)s.QtSpecification.maxvalcal;
                    snd += ((int)pr).ToString();
                }
                else snd += "0";
            } else snd += s.QtSpecification.maxvalcal.ToString() ;

            switch (s.QtSpecification.accuracy)
            {
                case -2:
                    if (s.IsSet) snd += "|1\r\n"; else snd += "|0\r\n";
                    break;
                default:
                    snd += "|" + formatFloat(s.Value, s.QtSpecification.accuracy) + "\r\n";
                    break;
            }
            
            lock (lck)
            {
                toclient.Add(snd);
            }
            if (!usekvant) ev.Set();
        }

        private String formatFloat(float f, Int16 accuracy = 1)
        {

            if (float.IsNaN(f)) return "0";
            if (f == 0.0f) return "0";
            switch (accuracy)
            {
                case 100:
                    return ((Int32)(f*100.0f)).ToString();
                case 10:
                    return 
                        ((Int32)f).ToString();
                case -1:
                    if (f > 0) return "1";
                    return "0";
                case 0:
                    f /= 10.0f;
                    return ((Int32)f).ToString();
                case 1:
                    f /= 10.0f;
                    return String.Format("{0:0.0}", f, en);
                case 2:
                    f /= 100.0f;
                    return String.Format("{0:0.00}", f, en);
                case 3:
                    f /= 100.0f;
                    return String.Format("{0:0.000}", f, en);
                case 4:
                    return String.Format("{0:0.000}", f, en);
                case 30:
                    return String.Format("{0:0.000}", f / 1000.0f, en);
                default:
                    break;
            }

            return String.Format("{0:0.0}", f, en);

        }

        public void startLiterner()
        {
            // формирует сигналы на обновление при изменении и ставим им ограничения и формат
            qtFormSignalsUpdate(false);
            qtFormSignalsUpdateTest(false);
            qtFormSignalsOnlyUpdateSignals(false);
            qtthread = new Thread(new ParameterizedThreadStart(qtGUI));
            qtthread.Start(null);

            //ISignal s = signals.GetSignal("derivative.system.speed.settings.1");
            //s.Specification.QtSaveAsUshort(800, 100, 100, 10000);
            //signals.DatabaseSignalUpdate(s);
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                    CheckSdcardStatus();
                    break;
                default:
                    break;
            }


        }

        private void qtFormSignal(String s, Int16 accuracy, Int16 maxvaluecalibrated, bool onupdate = true)
        {
            signals.GetSignal(s).QtSpecification.accuracy = accuracy;
            signals.GetSignal(s).QtSpecification.maxvalcal = maxvaluecalibrated;
            signals.GetSignal(s).QtSpecification.IsConfiguretForQt = true;
            if (onupdate)
                signals.GetSignal(s).OnUpdate += sensor => this.SendSignal(sensor);
            else
                signals.GetSignal(s).OnChange += sensor => this.SendSignal(sensor);
        }

        private void qtPreFormSignal(String s, Int16 accuracy, Int16 maxvaluecalibrated)
        {
            signals.GetSignal(s).QtSpecification.accuracy = accuracy;
            signals.GetSignal(s).QtSpecification.maxvalcal = maxvaluecalibrated;
        }


        public void qtFormSignalsUpdateTest(bool isupdate = false)
        {

            qtPreFormSignal("system.settings.Panel43Ver", 30, 0);
            qtPreFormSignal("system.settings.PcProcVer", 30, 0);
            qtPreFormSignal("system.settings.MotoHours", 4, 0);
            qtPreFormSignal("system.settings.OilHours", 4, 0);

        }

        public void qtFormSignalsOnlyUpdateSignals(bool isupdate = true)
        {

            // педали тест
            qtFormSignal("drive.forward", 10, 0, isupdate);
            qtFormSignal("drive.reverse", 10, 0, isupdate);
            // тест кордов
            qtFormSignal("cord.f1", 10, 0, isupdate);
            qtFormSignal("cord.f2", 10, 0, isupdate);
            qtFormSignal("cord.f3", 10, 0, isupdate);
            qtFormSignal("cord.f4", 10, 0, isupdate);
            qtFormSignal("cord.f5", 10, 0, isupdate);
            qtFormSignal("cord.f6", 10, 0, isupdate);
            // реле
            qtFormSignal("relay.kv4", 10, 0, isupdate);
            qtFormSignal("relay.kv11", 10, 0, isupdate);
            qtFormSignal("relay.kv10", 10, 0, isupdate);
            qtFormSignal("relay.kv9", 10, 0, isupdate);
            //qtFormSignal("relay.rectifierreset", 10, 0, isupdate);
            qtFormSignal("relay.kv1", 10, 0, isupdate);


            qtFormSignal("relay.kv11.k1", 10, 0, isupdate);
            qtFormSignal("relay.kv2.k2", 10, 0, isupdate);
            qtFormSignal("relay.kv1.k3", 10, 0, isupdate);
            qtFormSignal("relay.kv8.k4", 10, 0, isupdate);
            qtFormSignal("relay.kv9.k6", 10, 0, isupdate);
            qtFormSignal("relay.kv10.k5", 10, 0, isupdate);

            
            qtFormSignal("uz.2.mode", 10, 0, isupdate);
            qtFormSignal("uz.2.error", 10, 0, isupdate);
            qtFormSignal("uz.2.frequency", 2, 0, isupdate);
            qtFormSignal("uz.2.current", 10, 0, isupdate);
            qtFormSignal("uz.2.voltage", 10, 0, isupdate);
            qtFormSignal("uz.2.temperature", 10, 0, isupdate);
            qtFormSignal("uz.2.angle", 10, 0, isupdate);

            qtFormSignal("uz.3.mode", 10, 0, isupdate);
            qtFormSignal("uz.3.error", 10, 0, isupdate);
            qtFormSignal("uz.3.frequency", 2, 0, isupdate);
            qtFormSignal("uz.3.current", 10, 0, isupdate);
            qtFormSignal("uz.3.voltage", 10, 0, isupdate);
            qtFormSignal("uz.3.temperature", 10, 0, isupdate);
            qtFormSignal("uz.3.angle", 10, 0, isupdate);

            qtFormSignal("uz.4.mode", 10, 0, isupdate);
            qtFormSignal("uz.4.error", 10, 0, isupdate);
            qtFormSignal("uz.4.frequency", 2, 0, isupdate);
            qtFormSignal("uz.4.current", 10, 0, isupdate);
            qtFormSignal("uz.4.voltage", 10, 0, isupdate);
            qtFormSignal("uz.4.temperature", 10, 0, isupdate);
            qtFormSignal("uz.4.angle", 10, 0, isupdate);

            qtFormSignal("uz.5.mode", 10, 0, isupdate);
            qtFormSignal("uz.5.error", 10, 0, isupdate);
            qtFormSignal("uz.5.frequency", 3, 25, isupdate);
            qtFormSignal("uz.5.current", 10, 0, isupdate);
            qtFormSignal("uz.5.voltage", 10, 0, isupdate);
            qtFormSignal("uz.5.temperature", 10, 0, isupdate);
            qtFormSignal("uz.5.angle", 10, 0, isupdate);

        }

        public void qtFormSignalsUpdate(bool isupdate = false)
        {

            qtFormSignal("local.steering.pressure", 1, 16, isupdate); // кузов
            qtFormSignal("local.cabel.pressure", 1, 14, isupdate); // барабан
            qtFormSignal("local.brake.pressure", 1, 10, isupdate); // тормоз
            qtFormSignal("local.tank.level", 0, 100, isupdate);
            qtFormSignal("local.tank.temperature", 0, 100, isupdate);

            qtFormSignal("phase.1.voltage", 10, 0, isupdate);
            qtFormSignal("derivative.system.code", 10, 0, isupdate);
            qtFormSignal("derivative.system.speed", 10, 0, isupdate);
            qtFormSignal("derivative.conveyor.speed", 10, 0, isupdate);

            qtFormSignal("derivative.pump.status", 10, 0, isupdate);
            qtFormSignal("derivative.uz.2.status", 10, 0, isupdate);
            qtFormSignal("derivative.uz.3.status", 10, 0, isupdate);
            qtFormSignal("derivative.uz.4.status", 10, 0, isupdate);
            qtFormSignal("derivative.uz.5.status", 10, 0, isupdate);
            qtFormSignal("derivative.conveyor.status", 10, 0, isupdate);

        }

        private int CheckSdcardStatus()
        {
            if (System.IO.File.Exists("/mnt/sdcard/journal.flg"))
                return 1;
            else
            {
                journal.Error("Карта памяти не найдена или не примонтирована", MessageLevel.System);
                journal.Error("Все настройки системы и журнал временные", MessageLevel.System);
            }
            return 0;

        }

        private void qtGUI(object obj)
        {

            // формирует сигналы на обновление при изменении и ставим им ограничения и формат
            
            Thread.CurrentThread.CurrentCulture = en;
            IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Any, 9999);
            updsignals.Clear();

            while (true)
            {
                tcpListener = new TcpListener(serverEndPoint);
                isclient = false;
                try
                {
                    tcpListener.Start();
                }
                catch
                {
                    Thread.Sleep(3000);
                    tcpListener = null;
                    continue;
                }
                while (true)
                {
                    TcpClient client;
                    try
                    {
                        client = this.tcpListener.AcceptTcpClient();
                    }
                    catch
                    {
                        Thread.Sleep(3000);
                        this.tcpListener = null;
                        break;
                    }
                    if (isclient)
                    {
                        client.Close();
                        continue;
                    }
                    toclient.Clear();
                    isclient = true;
                    testmode = true;
                    Console.WriteLine("Qt patch: connect from " + client.Client.RemoteEndPoint.ToString());
                    clientread = new Thread(new ParameterizedThreadStart(qtTcpClientRead));
                    clientwrite = new Thread(new ParameterizedThreadStart(qtTcpClientWrite));
                    clientread.Start((object)client);
                    clientwrite.Start((object)client);

                }
            }
        }

        private void qtTcpClientRead(object obj)
        {
            Thread.CurrentThread.CurrentCulture = en;
            const int msglen = 4096;
            byte[] message = new byte[msglen];
            String buff = "";
            String tmp = "";
            int bytesRead;
            //ASCIIEncoding encoder = new ASCIIEncoding();
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            var mMsgLvlSys = MessageLevel.System;
            char[] delimit = new char[] { '\n' };
            TcpClient client = (TcpClient) obj;
            NetworkStream clientStream;
            try
            {
                clientStream = client.GetStream();
            }
            catch
            {
                isclient = false;
                ev.Set();
                try { client.Close(); }
                catch { }
                return;
            }

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    if (testmode == false) clientStream.ReadTimeout = maxreadtimeout;
                    else clientStream.ReadTimeout = -1;
                    bytesRead = clientStream.Read(message, 0, msglen);
                }
                catch
                {
                    //a socket error has occured
                    isclient = false;
                    ev.Set();
                    try { client.Close(); } 
                    catch { }
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }
                tmp = "";
                buff += win1251.GetString(message, 0, bytesRead);
                bool found = false;
                for (int i = 0; i < bytesRead; ++i)
                {
                    if (message[i] == (byte)delimit[0])
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    
                {
                    foreach (String substr in buff.Split(delimit)) if (substr.Length > 0) // ищем полные пакеты, если в строке есть \r то пакет полный
                        {
                            //if (substr.Length < 2) { tmp += buff; continue; }
                            if (String.Compare(substr, "nonenone\r", true) == 0)
                            {
                                if (Environment.OSVersion.Platform != PlatformID.Unix)
                                    Console.WriteLine("Info: Get signal none");

                            } else
                            if (String.Compare(substr, "teston\r", true) == 0)
                            {
                                testmode = true;
                                lock (lck)
                                {
                                    toclient.Add("teston\r\n");
                                }
                                ev.Set();
                            }
                            else
                                if (String.Compare(substr, "testoff\r", true) == 0)
                                {
                                    testmode = false;
                                    lock (lck)
                                    {
                                        toclient.Add("testoff\r\n");
                                    }
                                    ev.Set();
                                }
                                else
                                    if (String.Compare(substr, "online\r", true) == 0)
                                    {

                                    }
                                    else
                                        if (String.Compare(substr, "exit\r", true) == 0)
                                        {
                                            isclient = false;
                                            break;
                                        }
                                        else
                                            if (String.Compare(substr, "getsignals\r", true) == 0)
                                            {
                                                if (Environment.OSVersion.Platform != PlatformID.Unix)
                                                    Console.WriteLine("Info: Get signal getsignals");
                                                List<ISignal> specs = signals.GetSignalsLocal();
                                                if (specs.Count > 0)
                                                {
                                                    foreach (var spec in specs)
                                                    {
                                                        if (spec.QtSpecification.IsConfiguretForQt)
                                                            SendSignal(spec);
                                                    }
                                                    ev.Set();
                                                }

                                            }
                                            else
                                                if (String.Compare(substr, "getallsignals\r", true) == 0)
                                                {
                                                    if (Environment.OSVersion.Platform != PlatformID.Unix)
                                                        Console.WriteLine("Info: Get signal getallsignals");
                                                    List<ISignal> specs = signals.GetSignalsLocal();
                                                    if (specs.Count > 0)
                                                    {
                                                        foreach (var spec in specs)
                                                        {
                                                            SendSignal(spec);
                                                        }
                                                        ev.Set();
                                                    }

                                                }
                                                else
                                                    if (substr.Contains("|") && (substr[substr.Length - 1] == '\r'))
                                                    {
                                                        String pck = substr.Substring(0, substr.Length - 1);
                                                        List<String> ls = new List<String>(pck.Split('|'));
                                                        if (ls.Count == 3)
                                                        {
                                                            String result = ls[0];
                                                            if (String.Compare(result, "sdcard", true) == 0)
                                                            {
                                                                string str = "";
                                                                switch(ls[1])
                                                                {
                                                                    case "stat":
                                                                        int r = this.CheckSdcardStatus();
                                                                        str = "sdcard|stat|" + r.ToString() + "\r\n";
                                                                        break;
                                                                    case "space":
                                                                        try
                                                                        {
                                                                            System.IO.DriveInfo drv = new DriveInfo("/mnt/sdcard");
                                                                            long sp = drv.AvailableFreeSpace / ((long) 1024*1024);
                                                                            str = "sdcard|space|" + sp.ToString() + "\r\n";
                                                                        } catch
                                                                        {
                                                                            str = "sdcard|space|0\r\n";
                                                                        }
                                                                        break;
                                                                }
                                                                if (str.Length > 0)
                                                                {
                                                                    lock(lck)
                                                                    {
                                                                        toclient.Add(str);
                                                                    }
                                                                    ev.Set();
                                                                }
                                                            } else
                                                            if (String.Compare(result, "datetime", true) == 0)
                                                            {

                                                                if (String.Compare(ls[1], "set", true) == 0)
                                                                {
                                                                    if (Environment.OSVersion.Platform != PlatformID.Unix)
                                                                        Console.WriteLine("Setting DateTime to [" + ls[2] + " ]");
                                                                    try
                                                                    {
                                                                        this.SetDateTimeCommand(ls[2]);
                                                                    }
                                                                    catch { }
                                                                    //format 2017-11-23 23:00
                                                                }
                                                                else
                                                                    if (String.Compare(ls[1], "get", true) == 0)
                                                                    {
                                                                        string dtformat = "|dd|MM|yyyy|HH|mm";
                                                                        DateTime time = DateTime.Now;
                                                                        lock (lck)
                                                                        {
                                                                            toclient.Add(result + "|get" + time.ToString(dtformat) + "\r\n");
                                                                        }
                                                                        //this.SetDateTimeCommand(ls[1]);
                                                                        //format 2017-11-23 23:00
                                                                        ev.Set();
                                                                    }
                                                            }
                                                            else
                                                                if (String.Compare(result, "setjournal", true) == 0)
                                                                {
                                                                    Int16 acc = 0;
                                                                    try
                                                                    {
                                                                        acc = Convert.ToInt16(ls[1]);
                                                                    }
                                                                    catch { }
                                                                    switch (acc)
                                                                    {
                                                                        case 0:
                                                                        default:
                                                                            journal.Warning(ls[2], mMsgLvlSys);
                                                                            break;
                                                                    }

                                                                }
                                                                else
                                                                    if (String.Compare(result, "systemcmd", true) == 0)
                                                                    {
                                                                        if (String.Compare(ls[2], "-", true) == 0) DoCMD(ls[1], "");
                                                                        else
                                                                            DoCMD(ls[1], ls[2]);
                                                                    }
                                                                    else
                                                                        if (String.Compare(result, "getallcalibrpoints", true) == 0)
                                                                        {
                                                                            if (Environment.OSVersion.Platform != PlatformID.Unix)
                                                                                Console.WriteLine("Info: Get signal getallcalibrpoints");
                                                                            List<ISignal> lst = signals.GetSignalsLocal();
                                                                            foreach (var rv in lst)
                                                                            {
                                                                                if (rv.QtSpecification.IsCalibrated)
                                                                                {
                                                                                    string str = rv.Specification.Id + "|gcmin|";
                                                                                    int rawmin;
                                                                                    int rawmax;
                                                                                    signals.GetCalibrationPoint(rv.Specification.Id, out rawmin, out rawmax);
                                                                                    str = str + rawmin.ToString() + "\r\n" + rv.Specification.Id + "|gcmax|";
                                                                                    str = str + rawmax.ToString() + "\r\n";
                                                                                    lock (lck)
                                                                                    {
                                                                                        toclient.Add(str);
                                                                                    }
                                                                                }
                                                                            }
                                                                            ev.Set();
                                                                        }
                                                                        else
                                                                            if (String.Compare(ls[1], "scmin", true) == 0)
                                                                            {
                                                                                int raw = -1;
                                                                                try
                                                                                {
                                                                                    raw = Convert.ToInt32(ls[2]);
                                                                                    
                                                                                }
                                                                                catch { }
                                                                                if (raw >= 0) signals.UpdateCalibrationPointWithoutPhysical(result, "min", raw);
                                                                            }
                                                                            else
                                                                                if (String.Compare(ls[1], "scmax", true) == 0)
                                                                                {
                                                                                    int raw = -1;
                                                                                    try
                                                                                    {
                                                                                        raw = Convert.ToInt32(ls[2]);
                                                                                        
                                                                                    }
                                                                                    catch { }
                                                                                    if (raw >= 0) signals.UpdateCalibrationPointWithoutPhysical(result, "max", raw);
                                                                                }
                                                                                else
                                                                                    if (String.Compare(ls[1], "guc", true) == 0)
                                                                                    {
                                                                                        try
                                                                                        {
                                                                                            ISignal rv = signals.GetSignal(result);
                                                                                            if (Environment.OSVersion.Platform != PlatformID.Unix)
                                                                                                Console.WriteLine("Info: Get signal guc for " + rv.Specification.Id);
                                                                                            if (rv.QtSpecification.IsCalibrated)
                                                                                            {
                                                                                                string cmd = rv.Specification.Id + "|guc|" +
                                                                                                    rv.QtSpecification.raw.ToString() + "|" + rv.QtSpecification.raw.ToString() + "\r\n";
                                                                                                lock (lck)
                                                                                                    toclient.Add(cmd);
                                                                                                ev.Set();
                                                                                            }

                                                                                        }
                                                                                        catch { }
                                                                                    } else
                                                                                    if (String.Compare(ls[1], "get", true) == 0)
                                                                                    {
                                                                                        Int16 acc = 0;
                                                                                        try
                                                                                        {
                                                                                            acc = Convert.ToInt16(ls[2]);
                                                                                        }
                                                                                        catch { }
                                                                                        switch (acc)
                                                                                        {
                                                                                            case -1:
                                                                                                break;
                                                                                            default:
                                                                                                try
                                                                                                {
                                                                                                    SendSignal(signals.GetSignal(result), "get");
                                                                                                }
                                                                                                catch { }
                                                                                                break;
                                                                                        }

                                                                                    }
                                                                                    else
                                                                                        if (String.Compare(ls[1], "set", true) == 0)
                                                                                        {
                                                                                            bool r = true;
                                                                                            float c = 0.0f;
                                                                                            try
                                                                                            {
                                                                                                c = float.Parse(ls[2], en);
                                                                                                
                                                                                                //Console.WriteLine("Setting " + result + " - " + r.ToString());
                                                                                            }
                                                                                            catch {
                                                                                                r = false;
                                                                                            }
                                                                                            try
                                                                                            {
                                                                                                if (r) signals.Update(result, c);
                                                                                            }
                                                                                            catch { }
                                                                                            //mReciever.Update("tangage", rv[0]);
                                                                                            //mReciever.Update("roll", rv[1]);
                                                                                        }
                                                                                        else
                                                                                            if (String.Compare(result, "getjournal", true) == 0)
                                                                                            {
                                                                                                int start = 1;
                                                                                                int count = 0;
                                                                                                try
                                                                                                {
                                                                                                    start = Convert.ToInt32(ls[1]);
                                                                                                    count = Convert.ToInt32(ls[2]);
                                                                                                }
                                                                                                catch { }
                                                                                                List<string> rcd = GetJournalRecords(start, count);
                                                                                                if (rcd.Count > 0)
                                                                                                {
                                                                                                    lock (lck)
                                                                                                    {
                                                                                                        foreach (string s in rcd)
                                                                                                            toclient.Add("getjournal|" + s + "\r\n");
                                                                                                    }
                                                                                                    ev.Set();
                                                                                                    rcd.Clear();
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    lock (lck)
                                                                                                    {
                                                                                                        toclient.Add("getjournal|none\r\n");
                                                                                                    }
                                                                                                    ev.Set();
                                                                                                }
                                                                                                rcd = null;
                                                                                            }

                                                        }
                                                        ls = null;

                                                    }
                                                    else
                                                        if (substr[substr.Length - 1] == '\r')
                                                        {

                                                        }
                                                        else
                                                            tmp += substr;

                        }
                    buff = tmp;
                }
                if (buff.Length > msglen) buff = "";
                if (isclient == false) break;

            }

            isclient = false;
            ev.Set();
            try
            {
                client.Close();
            }
            catch { }
            message = null;

        }

        private void qtTcpClientWrite(object obj)
        {
            Thread.CurrentThread.CurrentCulture = en;
            TcpClient client = (TcpClient)obj;
            NetworkStream clientStream;
            String auth = "online\r\n";
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");

            try
            {
                clientStream = client.GetStream();
            }
            catch
            {
                isclient = false;
                try { client.Close(); }
                catch { }
                return;
            }

            int maxcounter = maxreadtimeout / (kvant * 2);
            int counter = 0;

            while (true)
            {

                if (usekvant)
                {
                    if (ev.WaitOne(kvant) == false)
                    {
                            ++counter;
                            int c = 0;
                            lock (lck)
                            {
                                c = toclient.Count;
                            }
                            if (c == 0)
                            {
                                if ((counter >= maxcounter) && (testmode == false))
                                {
                                    try
                                    {
                                        byte[] s = win1251.GetBytes(auth);
                                        clientStream.Write(s, 0, s.Length);
                                        clientStream.Flush();
                                    }
                                    catch
                                    {
                                        try { client.Close(); }
                                        catch { }
                                        break;
                                    }
                                    counter = 0;
                                }
                                if (testmode) counter = 0;
                                continue;
                            }

                    }

                }
                else
                {
                    if (ev.WaitOne(maxreadtimeout / 2) == false)
                    {
                        if (testmode == false)
                        {
                                try
                                {
                                    byte[] s = win1251.GetBytes(auth);
                                    clientStream.Write(s, 0, s.Length);
                                    clientStream.Flush();
                                }
                                catch
                                {
                                    try { client.Close(); }
                                    catch { }
                                    break;
                                }
                        }
                        int c = 0;
                        lock (lck)
                        {
                            c = toclient.Count;
                        }
                        if (c == 0) continue;

                    }
                }
                
                if (isclient == false) return;
                counter = 0;
                try
                {
                    lock (lck)
                    {
                        foreach (String str in toclient)
                        {
                            //clientStream.Write(System.Text.Encoding.ASCII.GetBytes(str), 0, str.Length);
                            byte[] s = win1251.GetBytes(str);
                            clientStream.Write(s, 0, s.Length);
                        }
                        clientStream.Flush();
                        toclient.Clear();
                    }

                }
                catch
                {
                    try { client.Close(); }
                    catch { }
                    isclient = false;
                    break;
                }

            }

        }

      


    }

    
}