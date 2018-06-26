using System;
using System.Collections.Generic;
using System.Threading;
using SDK.Interfaces;
using SDK.NetworksServices.Interfaces;
using SDK.NetworksServices.Services.Journal;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Equipment.Wago;
using SDK.SignalsFactory.Interface;
using Sensors.B17K;
using SignalsNamespace;
using qttcpparser;


namespace Gateway
{
    class Program
    {
        // wago - 192.168.1.111
        // gate - 192.168.1.121
        // 4.3" - 192.168.1.122
        // 10" - 192.168.1.131
        // stm32 - 192.168.1.141

        // wago test modules 

        static void Main()
        {

            //var journal = new ConsoleJournal();//journalService.GetJournal();            
            //var journal = new SqLiteJournal {IsConsoleEnable = true};//journalService.GetJournal();            
            //var journal = new JournalClient("127.0.0.1");   

            //Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding(866);
            bool debug = false;

            bool oldPanel43 = false;

            var mJServer = new JournalService(true);
            mJServer.Start();
            var journal = mJServer.GetJournal();

            var mMsgLvlSys = MessageLevel.System;
            journal.Warning("Старт работы PCproc", mMsgLvlSys);

            var signals = new SignalsFactory(journal);
            ConfigureSignalFactory(signals);
            journal.Warning("Запуск и конфигурирование Фабрики сигналов", mMsgLvlSys);
            //ModBusWago();

            var wago = new Coupler(journal, "192.168.1.111");


            //if (CouplerConfigurator.W750493_flag == false) wago.SetBaseAddr(524);
            CouplerConfigurator.Init(wago, signals);
            journal.Warning("Инициализация Ваго", mMsgLvlSys);
            List<ITask> tasklets;
            //if (oldPanel43) {
                var local = new RemoteConsole(journal, signals, 5000);
                journal.Warning(" Подключение к порту журнала на 5000 ", mMsgLvlSys);
                tasklets = new List<ITask> { local, wago, signals };
            //} else tasklets = new List<ITask> { wago, signals };
            

            /* This code added to support Qt GUI version of 4.3 Panel*/
            var qt = new qt(ref mJServer, ref signals, ref journal, true);
            qt.startLiterner();

            /* This code added to support Qt GUI version of 4.3 Panel*/

            try
            {
                //signals.GetSignal(SensorName.Keyboard()).OnChange += signal => Console.WriteLine("Keyboard: {0}", signal.Value);

                //signals.GetSignal(SensorName.Tank(SignalName.Level)).OnUpdate += signal => journal.Debug(string.Format("Level: {0}", signal.Value), MessageLevel.User);
                //signals.GetSignal("encoder.point").OnUpdate += signal => journal.Info(string.Format("Angle: {0}", signal.Value), MessageLevel.User);
                //signals.GetSignal(SensorName.Tank(SignalName.Temperature)).OnChange += signal => Console.WriteLine("Temp: {0}", signal.Value);

                //signals.GetSignal(SensorName.Cabel(SignalName.Pressure)).OnUpdate += signal => journal.Debug(string.Format("Cabel: {0}", signal.Value), MessageLevel.User);
                //signals.GetSignal(SensorName.Filter(SignalName.Pressure)).OnUpdate += signal => journal.Debug(string.Format("Filter: {0}", signal.Value), MessageLevel.User);
                //signals.GetSignal(SensorName.Steering(SignalName.Pressure)).OnUpdate += signal => journal.Debug(string.Format("Steering: {0}", signal.Value), MessageLevel.User);
                //signals.GetSignal(SensorName.Brake(SignalName.Pressure)).OnUpdate += signal => journal.Debug(string.Format("Brake: {0}", signal.Value), MessageLevel.User);

                //var pStatus = signals.GetSignal(SensorName.Derivative(SystemName.Pump, SignalName.Status));
                //var uz2Status = signals.GetSignal(SensorName.Derivative(SystemName.Uz, 2, SignalName.Status));
                //var uz3Status = signals.GetSignal(SensorName.Derivative(SystemName.Uz, 3, SignalName.Status));
                //var uz4Status = signals.GetSignal(SensorName.Derivative(SystemName.Uz, 4, SignalName.Status));
                //var uz5Status = signals.GetSignal(SensorName.Derivative(SystemName.Uz, 5, SignalName.Status));
                //var cStatus = signals.GetSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Status));
                //var code = 0;
                //cStatus.Update(code);
                //code++;

                //if (code > 2)
                //    code = 0;

                int first_cycle = 0;
                int show_delay = 0;
                int MotoSeconds = 0;
                int MotoMinutes = 0;
                int MotoDays = 0;
                //float TotalMotoHours = 0;
                float MotoHours = signals.GetSignal("system.settings.MotoHours").Value;
                //float TotalMotoHours = signals.GetSignal("system.settings.TotalMotoHours").Value;
                using (new SystemContol(journal, signals))
                {
                    //signals.PrintInfo(); //отладка сигналов в процессоре

                    foreach (var task in tasklets)
                    {
                        task.Start();
                    }

                    while (true)
                    {
                        Thread.Sleep(1000);
                        //проверка состояния насоса маслостанции
                        var signalPump = signals.GetSignal("derivative.pump.status").Value;
                        if (debug) { if (signalPump == 0) Console.WriteLine("Pump stopped: " + signalPump); }
                        
                        //debug signalPump=1
                        signalPump = 1;
                        //Debug 1sec = 1min
                        MotoMinutes = MotoSeconds;

                        if (signalPump == 1)
                        {
                            //насос включен
                            if (debug) Console.WriteLine("Pump started: " + signalPump);
                            
                            //первый проход забрали из базы и прибавили к текущему время
                            if (debug) Console.WriteLine(">>>>>> Moto hours from DB: " + MotoHours);
                            //first_cycle = 1;
                            //if (first_cycle == 1) MotoHours = MotoHours + MotoSeconds / 120; 

                            //Считаем секунды
                            MotoSeconds++;
                            if (MotoSeconds == 60) //одна минута
                            {   
                                MotoSeconds = 0; //сброс секунд
                                MotoMinutes = MotoMinutes + 1;
                            }


                            if (debug)
                            {
                                Console.WriteLine("Moto seconds: " + MotoSeconds);
                                Console.WriteLine("Moto Minutes: " + MotoMinutes);
                            }

                            //Считаем минуты
                            if (MotoMinutes == 60)
                            {
                                //Сброс минут по накоплении одного часа
                                MotoMinutes = 0;
                                //Cчитаем часы
                                MotoHours = MotoHours + 1;
                                //MotoHours = MotoHours + 100;

                                if (debug)
                                {
                                    Console.WriteLine("Moto seconds: " + MotoSeconds);
                                    Console.WriteLine("Moto Minutes: " + MotoMinutes);
                                    Console.WriteLine(">>>>>> Moto hours now: " + MotoHours);
                                }
                                signals.Update("system.settings.MotoHours", MotoHours );                                

                            }

                            
                            //Защита от переполнения счетчика 
                            if (MotoHours >= 250000) // Т.е. 250 000 часов это 28 лет
                            {
                                MotoHours = 0;
                                if (debug) Console.WriteLine(">>>>>> Moto hours now: " + MotoHours);
                                
                                
                            }

                            //if (MotoHours >= 200) //Замена масла через 200 М.ч.
                        }
                        show_delay++;
                        if (show_delay == 3)
                        {
                           // signals.PrintInfo(); //отладка сигналов в процессоре
                            //signals.WriteInfo(@"/mnt/sdcard/failsignals.raw"); //отладка сигналов в процессоре rwfs директория для перезаписи
                            show_delay = 0; //сброс таймера задержки

                            //Учет входа в меню сервисантов и инжинеров
                             
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                journal.Fatal(ex.ToString(), MessageLevel.System);
            }


            #region stop tasks
            tasklets.Reverse();
            foreach (var task in tasklets)
            {
                task.Stop();
            }
            #endregion
        }

        private static void ConfigureSignalFactory(ISignalsFactory signals)
        {
            var signalBuilder = new SignalBuilder(signals);
            signalBuilder.Init<B17K>();


            signals.AddSignal(SensorName.Keyboard(), "клавиатура");
            signals.AddSignal("derivative.system.code", "Статус работы");

            //signals.AddSignal("derivative.system.authorize", "Блокировка по паролю").Update(false);
            //new SignalSpecification(string.Format("system.settings.Panel43Ver", SensorName.PcprocVer(SignalName.PcProcVer)), "Версия Процессора")

            signals.AddSignal("derivative.system.authorize", "Блокировка по паролю").Update(true);

            #region Отладочные сигналы

            signals.AddSignal("system.debug.SysInit", "Система:предстарт").Update(0);
            signals.AddSignal("system.debug.SysStart", "Система:старт").Update(0);
            signals.AddSignal("system.debug.SysStop", "Система:стоп").Update(0);
            signals.AddSignal("system.debug.SysMotion", "Система:движение").Update(0);
            signals.AddSignal("system.debug.SysError", "Система:защита").Update(0);
            #endregion

            #region Учет входа в меню сервисантов и инжинеров
            signals.AddSignal("system.settings.serviceenter", "Вход сервисанта").Update(true);
            signals.AddSignal("system.settings.engineerenter", "Вход сервисанта").Update(true);
            //signals.AddSignal(new SignalSpecification(string.Format("system.settings.year", SensorName.Year(SignalName.Year))), "Вход сервисанта");
            //signals.AddSignal("derivative.system.authorize", "Вход сервисанта").Update(true);
            #endregion

            

            #region Управление скоростью движения и конвейера
            signals.AddSignal(SensorName.Derivative(SystemName.System, SignalName.Speed), "").Update(0);//, SignalType.Ushort);
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.System, SignalName.Speed), 1), "Движение, 1 скорость").SaveAsUshort(700, true, 100, 100, 10000));
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.System, SignalName.Speed), 2), "Движение, 2 скорость").SaveAsUshort(2500, true, 100, 100, 10000));
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.System, SignalName.Speed), 3), "Движение, 3 скорость").SaveAsUshort(5000, true, 100, 100, 10000));
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.System, SignalName.Speed), 4), "Движение, 4 скорость").SaveAsUshort(7500, true, 100, 100, 10000));


            signals.AddSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Speed), "").Update(0);//, SignalType.Ushort);
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.Conveyor, SignalName.Speed), 1), "Конвейер, 1 скорость").SaveAsUshort(1000, true, 100, 100, 10000));
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.Conveyor, SignalName.Speed), 2), "Конвейер, 2 скорость").SaveAsUshort(1500, true, 100, 100, 10000));
            signals.AddStored(new SignalSpecification(string.Format("{0}.settings.{1}", SensorName.Derivative(SystemName.Conveyor, SignalName.Speed), 3), "Конвейер, 3 скорость").SaveAsUshort(2000, true, 100, 100, 10000));

            signals.AddSignal("roll", "").Update(0.0f); //
            signals.AddSignal("tangage", "").Update(0.0f); // 
            //signals.AddSignal("roll", "крен").Update(0.0f); //
            //signals.AddSignal("tangage", "тангаж").Update(0.0f); // 
            //signals.AddStored(new SignalSpecification("tangage.uphill.frequency.max", "максимальная частота при движении в гору").SaveAsUshort(true, 1000, 100, 3500)).Update(3000);
            //signals.AddStored(new SignalSpecification("tangage.uphill.frequency.max.settings", "угол наклона для применения максимальной частоты").SaveAsUshort(true, 5, 1, 15)).Update(10);

            //signals.AddStored(new SignalSpecification("tangage.normal.frequency.levelup", "скорость набора частоты на плоскости").SaveAsUshort(true, 5, 1, 20)).Update(15);
            //signals.AddStored(new SignalSpecification("tangage.uphill.frequency.levelup", "скорость набора частоты в гору").SaveAsUshort(true, 15, 1, 25)).Update(20);
            //signals.AddStored(new SignalSpecification("tangage.uphill.frequency.levelup.settings", "угол наклона для применения повышенной скорости набора частоты").SaveAsUshort(true, 5, 1, 15)).Update(10);
            #endregion

            #region Настройка ограничения по частоте при спуске-подъеме

            signals.AddStored(new SignalSpecification("tangage.uphill.limit.enable", "Ограничение Fmax при уклоне").SaveAsBool(false));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.0", "Fmax,  0⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.1", "Fmax,  1⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.2", "Fmax,  2⁰").SaveAsUshort(71, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.3", "Fmax,  3⁰").SaveAsUshort(67, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.4", "Fmax,  4⁰").SaveAsUshort(63, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.5", "Fmax,  5⁰").SaveAsUshort(59, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.6", "Fmax,  6⁰").SaveAsUshort(55, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.7", "Fmax,  7⁰").SaveAsUshort(51, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.8", "Fmax,  8⁰").SaveAsUshort(47, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.9", "Fmax,  9⁰").SaveAsUshort(46, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.10", "Fmax, 10⁰").SaveAsUshort(45, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.11", "Fmax, 11⁰").SaveAsUshort(44, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.12", "Fmax, 12⁰").SaveAsUshort(43, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.13", "Fmax, 13⁰").SaveAsUshort(42, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.14", "Fmax, 14⁰").SaveAsUshort(41, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tangage.uphill.limit.15", "Fmax, 15+⁰").SaveAsUshort(40, true, 1, 1, 100));
            #endregion

            #region Дискретные выхода
            signals.AddSignal(SensorName.Relay(RelayName.Kv4), "");// SignalType.Ushort), // sound alarm                                                
            signals.AddSignal(SensorName.Relay(RelayName.Kv11), "");// SignalType.Ushort), // pump on                                                
            signals.AddSignal(SensorName.Relay(RelayName.Kv10), ""); //SignalType.Ushort), // mode moving,                                                
            signals.AddSignal(SensorName.Relay(RelayName.Kv9), ""); //SignalType.Ushort),// mode conveyeor,                                                
            signals.AddSignal(SensorName.Relay(RelayName.RectifierReset), ""); //SignalType.Ushort),// rectifier reset//null,//new Signal(SensorName.Relay(RelayName.Kv10)),//mode mix,                                                                                           
            signals.AddSignal(SensorName.Relay(RelayName.Kv1), ""); //SignalType.Ushort),// rectifier active mode
            #endregion

            #region Дискретные входа
            signals.AddSignal(SensorName.Drive(SignalName.Forward), "");// SignalType.Ushort),                                          
            signals.AddSignal(SensorName.Drive(SignalName.Reverse), "");// SignalType.Ushort),                                          
            signals.AddSignal(SensorName.Cord(1), ""); //SignalType.Ushort), // F1                                          
            signals.AddSignal(SensorName.Cord(2), ""); //SignalType.Ushort), // F2                                          
            signals.AddSignal(SensorName.Cord(3), ""); //SignalType.Ushort), // F3                                          
            signals.AddSignal(SensorName.Cord(4), ""); //SignalType.Ushort), // F4                                          
            signals.AddSignal(SensorName.Cord(5), ""); //SignalType.Ushort), // F5                                          
            signals.AddSignal(SensorName.Cord(6), ""); //SignalType.Ushort), // F6                                          
            signals.AddSignal(SensorName.Relay(RelayName.Kv11, SignalName.Feedback), ""); //SignalType.Ushort),// K1                                          
            signals.AddSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback), ""); //SignalType.Ushort),// K2                                           
            signals.AddSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback), ""); //SignalType.Ushort),// K3 -                                           
            signals.AddSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback), ""); //SignalType.Ushort),// K4 -                                           
            signals.AddSignal(SensorName.Relay(RelayName.Kv9, SignalName.Feedback), ""); //SignalType.Ushort),// K5 -                                           
            signals.AddSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback), ""); //SignalType.Ushort),// K6                                          
            #endregion

            #region Аналоговые входа и их настройки

            signals.AddSignal(SensorName.Phase(1, SignalName.Voltage), ""); //, SignalType.Ushort)

            signals.AddSignal(SensorName.Filter(SignalName.Pressure), "");
            signals.AddSignal(SensorName.Steering(SignalName.Pressure), "");
            signals.AddSignal(SensorName.Cabel(SignalName.Pressure), "");
            signals.AddSignal(SensorName.Brake(SignalName.Pressure), "");
            signals.AddSignal(SensorName.Tank(SignalName.Level), "tannk level pizda");
            signals.AddSignal(SensorName.Tank(SignalName.Temperature), "");

            //Заводим дату и время как сигнал описав его в SensorName
            signals.AddSignal(SensorName.Year(SignalName.Year), "");
            signals.AddSignal(SensorName.Month(SignalName.Month), "");
            signals.AddSignal(SensorName.Date(SignalName.Date), "");
            signals.AddSignal(SensorName.Date(SignalName.Hour), "");
            signals.AddSignal(SensorName.Date(SignalName.Minutes), "");


            /*     
            // правильные значения - для Update нужно значение на 1 больше 
            case "local.steering.pressure": return 0;            
            case "local.cabel.pressure": return 4;            
            case "local.filter.pressure": return 3;            
            case "local.brake.pressure": return 1;            
            case "local.tank.level": return 5;            
            case "local.tank.temperature": return 2;
            */

            // Update(0) - датчик не применим, канал отключен
            signals.AddStored(new SignalSpecification(string.Format("{0}.channel", SensorName.Steering(SignalName.Pressure)), "Канал датчика P рулевое").SaveAsUshort(1, true, 0, 1, 6));
            signals.AddStored(new SignalSpecification(string.Format("{0}.channel", SensorName.Cabel(SignalName.Pressure)), "Канал датчика P кабельное").SaveAsUshort(5, true, 0, 1, 6));
            signals.AddStored(new SignalSpecification(string.Format("{0}.channel", SensorName.Filter(SignalName.Pressure)), "Канал датчика P фильтра").SaveAsUshort(4, true, 0, 1, 6));
            signals.AddStored(new SignalSpecification(string.Format("{0}.channel", SensorName.Brake(SignalName.Pressure)), "Канал датчика P тормозное").SaveAsUshort(2, true, 0, 1, 6));
            signals.AddStored(new SignalSpecification(string.Format("{0}.channel", SensorName.Tank(SignalName.Level)), "Канал датчика L бак").SaveAsUshort(6, true, 0, 1, 6));
            signals.AddStored(new SignalSpecification(string.Format("{0}.channel", SensorName.Tank(SignalName.Temperature)), "Канал датчика T бак").SaveAsUshort(3, true, 0, 1, 6));
            #endregion

            #region Общие настройки
            signals.AddStored(new SignalSpecification("relay.feedback.on.timeout", "T старт включения контактора").SaveAsUshort(3000, true, 1500, 100, 6000));
            signals.AddStored((new SignalSpecification("pump.sensor.startup.timeout", "T старт маслянного насоса")).SaveAsUshort(5000, true, 3000, 1000, 20000));

            signals.AddStored(new SignalSpecification("soundalarm.on.timeout", "T звучание сирены").SaveAsUshort(1500, true, 1500, 100, 6000)); // правильное значение 6000 
            signals.AddStored(new SignalSpecification("soundalarm.off.timeout", "T после звучания сирены").SaveAsUshort(5000, true, 1500, 100, 10000));
            #endregion

            #region Рабочие параметры частотников
            for (byte i = 1; i < 19; i++)
            {
                signals.AddSignal(SensorName.Invertor(i, SignalName.Mode), "");//, SignalType.Ushort);
                signals.AddSignal(SensorName.Invertor(i, SignalName.Error), "");//, SignalType.Ushort);
                signals.AddSignal(SensorName.Invertor(i, SignalName.Frequency), "");//, SignalType.Ushort);
                signals.AddSignal(SensorName.Invertor(i, SignalName.Current), "");//, SignalType.Ushort);
                signals.AddSignal(SensorName.Invertor(i, SignalName.Voltage), "");//, SignalType.Ushort);
                signals.AddSignal(SensorName.Invertor(i, SignalName.Temperature), "");//, SignalType.Ushort);
                signals.AddSignal(SensorName.Invertor(i, SignalName.Angle), "");//, SignalType.Ushort);   
                /*
                  40009 причина последнего выключения (код как выше)
                  40010 час выключения (если время не подаётся в SLAVE показывает „00”)
                    40011 минута выключения (если время не подаётся в SLAVE показывает „00”)
                    40012 день выключения (если время не подаётся в SLAVE показывает „00”)
                    40013 месяц выключения (если время не подаётся в SLAVE показывает „00”)
                    40014 год выключения (если время не подаётся в SLAVE показывает „00”)
                    40015 Fzad при выключении в сотых частях [Гц]
                    40016 Fpracy при выключении в сотых частях [Гц]
                    40017 Ud при выключении
                    40018 Iskut при выключении
                    40019 температура сенсора при выключении
                    40020 скорость вращения двигателя в [обр/мин] подключенного к энкодеру
                    LastStop,
                    HourStop,
                    MinuteStop,
                    DayStop,
                    MonthStop,
                    YearStop,
                    FzadStop,
                    FpracyStop,
                    UdStop,
                    IskutStop,
                    TermSensStop,
                 */
                signals.AddSignal(SensorName.Invertor(i, SignalName.LastStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.HourStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.MinuteStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.DayStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.MonthStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.YearStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.FzadStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.FpracyStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.UdStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.IskutStop), "");//, SignalType.Ushort);   
                signals.AddSignal(SensorName.Invertor(i, SignalName.TermSensStop), "");//, SignalType.Ushort);   
            }
            #endregion

            // как забираем Koshamarski
            //  mReciever.GetSignal("derivative.pump.status"),
            //  mReciever.GetSignal("derivative.uz.2.status"),
            //  mReciever.GetSignal("derivative.uz.3.status"),
            //  mReciever.GetSignal("derivative.uz.4.status"),
            //  mReciever.GetSignal("derivative.uz.5.status"),
            //  mReciever.GetSignal("derivative.conveyor.status"),
            //signals.AddSignal(SensorName.Drive(SignalName.Forward), "");// SignalType.Ushort),                                          
            //signals.AddSignal(SensorName.Drive(SignalName.Reverse), "");// SignalType.Ushort),    
            #region Статусы объектов управления
            signals.AddSignal(SensorName.Derivative(SystemName.Pump, SignalName.Status), "");//, SignalType.Ushort);
            signals.AddSignal(SensorName.Derivative(SystemName.Uz, 2, SignalName.Status), "");//, SignalType.Ushort);
            signals.AddSignal(SensorName.Derivative(SystemName.Uz, 3, SignalName.Status), "");//, SignalType.Ushort);
            signals.AddSignal(SensorName.Derivative(SystemName.Uz, 4, SignalName.Status), "");//, SignalType.Ushort);
            signals.AddSignal(SensorName.Derivative(SystemName.Uz, 5, SignalName.Status), "");//, SignalType.Ushort);
            signals.AddSignal(SensorName.Derivative(SystemName.Conveyor, SignalName.Status), "");//, SignalType.Ushort);
            #endregion

            #region Защитные уставки
            signals.AddStored(new SignalSpecification("pump.alarm.pressure.min", "Min рабочее давление насоса").SaveAsFloat(1.0f, true, 0.1f, 0.1f, 10.0f));
            signals.AddStored(new SignalSpecification("pump.alarm.pressure.max", "Max рабочее давление насоса").SaveAsFloat(10.0f, true, 0.1f, 0.1f, 10.0f));
            signals.AddStored(new SignalSpecification("pump.alarm.startup.timeout", "Время выхода насоса на режим").SaveAsUshort(10, true, 1, 1, 100));

            signals.AddStored(new SignalSpecification("pump.alarm.shutdown.timeout", "Задержка на выключение насоса").SaveAsUshort(5, true, 1, 1, 30));

            signals.AddStored(new SignalSpecification("tank.level.warning.min", "Уровень в баке, предупреждение").SaveAsUshort(10, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tank.level.alarm.min", "Уровень в баке, авария").SaveAsUshort(5, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("tank.temperature.warning.max", "Т в баке, предупреждение").SaveAsUshort(70, true, 1, 1, 120));
            signals.AddStored(new SignalSpecification("tank.temperature.alarm.max", "Т в баке, авария").SaveAsUshort(90, true, 1, 1, 120));

            signals.AddStored(new SignalSpecification("filter.pressure.warning.max", "Давление на фильтре, предупреждение").SaveAsFloat(19.0f, true, 0.1f, 0.1f, 20.0f));
            signals.AddStored(new SignalSpecification("filter.pressure.alarm.max", "Давление на фильтре, авария").SaveAsFloat(20.0f, true, 0.1f, 0.1f, 20.0f));

            signals.AddStored(new SignalSpecification(string.Format("{0}.warning.min", SensorName.Steering(SignalName.Pressure)), "Предупреждение P рулевого, min").SaveAsUshort(ushort.MaxValue));
            signals.AddStored(new SignalSpecification(string.Format("{0}.warning.max", SensorName.Steering(SignalName.Pressure)), "Предупреждение P рулевого, max").SaveAsUshort(ushort.MaxValue));

            signals.AddStored(new SignalSpecification(string.Format("{0}.warning.min", SensorName.Brake(SignalName.Pressure)), "Предупреждение P тормозного, min").SaveAsUshort(ushort.MaxValue));
            signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.min", SensorName.Brake(SignalName.Pressure)), "Авария P тормозного, min").SaveAsUshort(ushort.MaxValue));
            signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.max", SensorName.Brake(SignalName.Pressure)), "Авария P тормозного, max").SaveAsUshort(ushort.MaxValue));

            signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.min", SensorName.Cabel(SignalName.Pressure)), "Авария P кабельного, min").SaveAsUshort(ushort.MaxValue));
            signals.AddStored(new SignalSpecification(string.Format("{0}.warning.max", SensorName.Cabel(SignalName.Pressure)), "Предупреждение P кабельного, max").SaveAsUshort(ushort.MaxValue));
            signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.max", SensorName.Cabel(SignalName.Pressure)), "Авария P кабельного, max").SaveAsUshort(ushort.MaxValue));

            signals.AddStored(new SignalSpecification("engines.alarm.shutdown.timeout", "Задержка на выключение двигателей").SaveAsUshort(10, true, 1, 1, 100));
            #endregion

            #region Версия ПО
            signals.AddStored(new SignalSpecification(string.Format("system.settings.Panel43Ver", SensorName.PcprocVer(SignalName.PcProcVer)), "Версия Процессора").SaveAsUshort(3002, true, 0, 1, 10000));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.PcProcVer", SensorName.Panel43Ver(SignalName.Panel43Ver)), "Версия панель43").SaveAsUshort(3001, true, 0, 1, 10000));
            #endregion
            #region МотоЧасы и КиловатЧасы
            signals.AddStored(new SignalSpecification(string.Format("system.settings.MotoHours", SensorName.MotorHour(SignalName.MotoHours)), "МотоЧасы").SaveAsFloat(0.0f, true, 0.0f, 0.1f, 9999f));
            //signals.AddStored(new SignalSpecification(string.Format("system.settings.MotoHours", SensorName.MotorHour(SignalName.MotoHours)), "МотоЧасы").SaveAsUshort(0, true, 0, 1, 3000));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.KWHours", SensorName.KilowatH(SignalName.KWHours)), "КиловаттЧасы").SaveAsUshort(0, true, 0, 1, 9999));
            #endregion

            #region Учет  наработки маслостанции
            signals.AddSignal("system.settings.ChangeOil", "НЕОБХОДИМА ЗАМЕНА МАСЛА").Update(true);
            signals.AddStored(new SignalSpecification(string.Format("system.settings.OilState", SensorName.OilPump(SignalName.OilRefresh)), "Замена масла").SaveAsUshort(0, true, 0, 1, 200));
            #endregion

            #region Системные функции
            signals.AddStored(new SignalSpecification(string.Format("system.settings.comport", SensorName.ComPort(1, SignalName.ComNumber)), "Номер COM порта").SaveAsUshort(0, true, 0, 1, 3));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.comspeed", SensorName.ComSpeed(1, SignalName.ComSpeed)), "Скорость COM порта").SaveAsUshort(19200, true, 9600, 9600, 57600));

            signals.AddStored(new SignalSpecification(string.Format("system.settings.wago493", SensorName.Wago493(1, SignalName.Detect493)), "Wago модуль 493").SaveAsUshort(1, true, 0, 1, 1));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.convmode", SensorName.ConvMode(1, SignalName.Convmode)), "Режим конвеера ПЧН").SaveAsUshort(0, true, 0, 1, 1));
            #endregion

            #region Дата и время
            //DateTime.Now.ToString("mm:ss.fff");
            //int year=DateTime.Now.Year;
            //int month = DateTime.Now.Month;
            //int hour = DateTime.Now.Hour;
            //int minute = DateTime.Now.Minute;
            //int day = DateTime.Now.Day;
            signals.AddStored(new SignalSpecification(string.Format("system.settings.year", SensorName.Year(SignalName.Year)), "Год").SaveAsUshort(2016, true, 2016, 1, 2090));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.month", SensorName.Month(SignalName.Month)), "Месяц").SaveAsUshort(01, true, 01, 1, 12));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.day", SensorName.Date(SignalName.Date)), "День").SaveAsUshort(01, true, 01, 1, 31));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.hour", SensorName.Hour(SignalName.Hour)), "Часы").SaveAsUshort(01, true, 0, 1, 24));
            signals.AddStored(new SignalSpecification(string.Format("system.settings.minutes", SensorName.Minutes(SignalName.Minutes)), "Минуты").SaveAsUshort(0, true, 0, 1, 60));
            #endregion



            #region Калибровочные точки для сигналов

            signals.AddStored(new SignalSpecification("encoder.settings.enable", "Учет поворота колес").SaveAsUshort(0, true, 0, 1, 1));
            signals.AddStored(new SignalSpecification("encoder.settings.zero", "Нулевая точка энкодера поворота").SaveAsUshort(0, true, 0, 1, 1023));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.1", "% max,  1⁰").SaveAsUshort(100, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.2", "% max,  2⁰").SaveAsUshort(100, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.3", "% max,  3⁰").SaveAsUshort(100, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.4", "% max,  4⁰").SaveAsUshort(100, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.5", "% max,  5⁰").SaveAsUshort(100, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.6", "% max,  6⁰").SaveAsUshort(95, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.7", "% max,  7⁰").SaveAsUshort(95, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.8", "% max,  8⁰").SaveAsUshort(95, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.9", "% max,  9⁰").SaveAsUshort(95, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.10", "% max, 10⁰").SaveAsUshort(95, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.11", "% max, 11⁰").SaveAsUshort(90, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.12", "% max, 12⁰").SaveAsUshort(90, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.13", "% max, 13⁰").SaveAsUshort(90, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.14", "% max, 14⁰").SaveAsUshort(90, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.15", "% max, 15⁰").SaveAsUshort(90, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.16", "% max, 16⁰").SaveAsUshort(85, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.17", "% max, 17⁰").SaveAsUshort(85, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.18", "% max, 18⁰").SaveAsUshort(85, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.19", "% max, 19⁰").SaveAsUshort(85, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.20", "% max, 20⁰").SaveAsUshort(85, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.21", "% max, 21⁰").SaveAsUshort(80, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.22", "% max, 22⁰").SaveAsUshort(80, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.23", "% max, 23⁰").SaveAsUshort(80, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.24", "% max, 24⁰").SaveAsUshort(80, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.25", "% max, 25⁰").SaveAsUshort(80, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.26", "% max, 26⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.27", "% max, 27⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.28", "% max, 28⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.29", "% max, 29⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddStored(new SignalSpecification("encoder.settings.limit.30", "% max, 30⁰").SaveAsUshort(75, true, 1, 1, 100));
            signals.AddSignal("encoder.point", "Коэфициент компенсации поворота");

            var rv = signals.GetSignal((SensorName.Tank(SignalName.Level)));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 700, 0);
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 3200, 1000);
            }
            

            rv = signals.GetSignal((SensorName.Tank(SignalName.Temperature)));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 385, 0);
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 2000, 1000);
            }

            rv = signals.GetSignal((SensorName.Brake(SignalName.Pressure)));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 385, 0);
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 2000, 100);
            }
            

            rv = signals.GetSignal((SensorName.Steering(SignalName.Pressure)));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 385, 0);
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 2000, 500);
            }
            

            rv = signals.GetSignal((SensorName.Filter(SignalName.Pressure)));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 385, 0);
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 2000, 500);
            }
            

            rv = signals.GetSignal((SensorName.Cabel(SignalName.Pressure)));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 385, 0);
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 2000, 500);
            }
            
            rv = signals.GetSignal(SensorName.Phase(1, SignalName.Voltage));
            if (!signals.IsCheckOrLoadCalibrationPointExist(rv.Specification.Id))
            {
                signals.AddCalibrationPoint(rv.Specification.Id, "min", 0, 0);
                //signals.AddCalibrationPoint(rv.Specification.Id, 500, 1583.33f); // 36V transf
                signals.AddCalibrationPoint(rv.Specification.Id, "max", 500, 1357.14f); // 42V transf
            }
            


            #endregion

        }
    }
}
