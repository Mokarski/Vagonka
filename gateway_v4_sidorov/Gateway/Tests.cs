using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using SDK.Common;
using SDK.Configure;
using SDK.Interfaces;
using SDK.JournalService;
using SDK.SignalsFactory;
using SDK.SignalsFactory.Equipment.Wago;
using Sensors.B17K;
using log4net;

namespace Gateway
{


    class Program
    {

        static void MainTest()
        {
            log4net.Config.XmlConfigurator.Configure();
            var journal = new Journal(LogManager.GetLogger("logger"));
            var factory = new SignalsFactory(journal, 502);


            var rv = new Signal("my.signal.one");
            rv.AddCalibrationPoint(2, 100.0f);
            rv.AddCalibrationPoint(50000, 65000.0f);

            //factory.AddUshort(new Signal("my.double.one"), 1);

            //factory.AddDiscreet(new Signal("my.signal.5"), 2, 5, false);
            //factory.AddDiscreet(new Signal("my.signal.6"), 2, 6, false);           

            factory.Start();
            factory.PrintInfo();

            var i = 0;
            var time = new Stopwatch();
            time.Start();
            while (i < 50000)
            {
                rv.Update(i++);
            }
            time.Stop();

            Console.WriteLine(time.ElapsedMilliseconds);
            Console.WriteLine("Enter Press");
            Console.ReadLine();
        }


        private static void CreateDefault(SQLiteConnection config)
        {
            config.Insert(new SignalDescription("brake.pressure.alarm.min", "Минимальное давление в системе тормозов") { Data = 5 }.SaveAsFloat(new[] { 3.0f, 0.1f, 50.0f }));
            config.Insert(new SignalDescription("brake.pressure.alarm.max", "Максимальное давление в системе тормозов") { Data = 25.5f }.SaveAsFloat(new[] { 3.0f, 0.1f, 50.0f }));
            config.Insert(new SignalDescription("brake.pressure.type", "Тип датчика давления") { Data = 1 }.SaveAsEnum(new[] { "4..20 mA", "RS485", "0..10 V" }));
        }

        static void Main()
        {
            //ConfiguratorTest();


            log4net.Config.XmlConfigurator.Configure();
            var journal = new Journal(LogManager.GetLogger("logger"));
            var signals = new SignalsFactory(journal);

            var wago = new Coupler(journal, signals, "192.168.1.111");
            CouplerConfigurator.Init(wago);

            var local = new RemoteConsole(journal, signals, 5000);

            //var invertors = new InvertorsService(journal, signals, "COM7");
            //var invertors = new InvertorsService(journal, signals, "/dev/ttySP1");

            signals.PrintInfo();

            #region start
            //var tasklets = new List<ITask> { invertors, local, wago, signals };
            var tasklets = new List<ITask> { local, wago, signals };

            foreach (var task in tasklets)
            {
                task.Start();
            }
            #endregion


            #region test & dump
            {
                Thread.Sleep(500);
                //TestRelay(signals);

                TestKeyboard(signals);

                //signals.SensorInfo();
                //signals.OutputInfo();
            }
            #endregion

            while (true)
            {
                Thread.Sleep(100);
            }


            //using (new SystemContol(journal, invertors, signals))
            {
                //Console.WriteLine("press Enter to stop");
                //Console.ReadLine();
                while (true)
                {
                    Thread.Sleep(100);
                }
            }

            #region stop tasks
            tasklets.Reverse();
            foreach (var task in tasklets)
            {
                task.Stop();
            }
            #endregion
        }

        private static void ConfiguratorTest()
        {
            #region TODO: конфигуратор для меню

            var config = new Configurator();
            config.DeleteAll<SignalDescription>();
            if (config.IsEmpty())
            {
                CreateDefault(config);
            }
            //else
            {
                var rv = config.QueryById("alarm.min");


                config.Update(
                    new SignalDescription("brake.pressure.alarm.min", "Минимальное давление в системе тормозов").SaveAsFloat(new[]
                                                                                                                      {
                                                                                                                          5.0f,
                                                                                                                          0.1f,
                                                                                                                          50.0f
                                                                                                                      }));
                rv = config.QueryById("alarm.min");

                var s = config.QueryById("alarm");
                foreach (var record in s)
                {
                    Console.WriteLine(record.Id);

                    foreach (var i in record.GetRangeAsEnum())
                        Console.Write("{0} ", i);

                    Console.Write("\t");

                    var k = record.GetRangeAsFloat();
                    if (k == null)
                    {
                        Console.WriteLine();
                        continue;
                    }

                    foreach (var i in k)
                        Console.Write("{0} ", i);

                    Console.WriteLine();
                }
            }

            #endregion

            while (true)
            {
                Thread.Sleep(200);
            }
        }

        #region home test

        /*
        private static void SensorCalibrationTest()
        {
            {
                var sensor = new ModbusInput();
                sensor.AddCalibrationPoint(100, 500);
                sensor.AddCalibrationPoint(150, 1000);
                //sensor.AddCalibrationPoint(200, 1100);
                
                sensor.Update(10);
                Console.WriteLine(sensor.PhisycalValue);

                sensor.Update(100);
                Console.WriteLine(sensor.PhisycalValue);

                sensor.Update(110);
                Console.WriteLine(sensor.PhisycalValue);

                sensor.Update(140);
                Console.WriteLine(sensor.PhisycalValue);

                sensor.Update(150);
                Console.WriteLine(sensor.PhisycalValue);

                sensor.Update(175);
                Console.WriteLine(sensor.PhisycalValue);

                sensor.Update(200);
                Console.WriteLine(sensor.PhisycalValue);
            }
        }

        private static void TestRelay(SignalFactory signals)
        {
            Thread.Sleep(2000);
            
            var period1 = new PeriodicTask(400);
            var state1 = true;
            period1.OnPeriod = () =>
                                   {
                                       //var rv = outputs.FirstOrDefault(s => s.Id == SensorName.Relay(RelayName.Kv10));
                                       var rv = signals.GetOutput(SensorName.Relay(RelayName.Kv10));
                                       if (rv != null)
                                           rv.Set(state1);

                                       state1 = !state1;
                                   };

            period1.Start();

            var period2 = new PeriodicTask(900);
            var state2 = true;
            period2.OnPeriod = () =>
                                   {
                                       var rv = signals.GetOutput(SensorName.Relay(RelayName.Kv8));
                                       if (rv != null)
                                           rv.Set(state2);

                                       state2 = !state2;
                                   };

            period2.Start();

            var period3 = new PeriodicTask(500);
            var state3 = true;
            period3.OnPeriod = () =>
                                   {
                                       var rv = signals.GetOutput(SensorName.Relay(RelayName.Kv4));
                                       if (rv != null)
                                           rv.Set(state3);

                                       state3 = !state3;
                                   };

            period3.Start();

            var keyboard = signals.GetSignal(SensorName.Keyboard()) as LocalKeyboard;
            if (keyboard != null)
            {
                keyboard.OnPress += value => Console.WriteLine("press: {0}", value);
                keyboard.OnRelese += value => Console.WriteLine("release: {0}", value);
            }
        }
        */
        #endregion

        private static void TestKeyboard(SignalsFactory signals)
        {
            /*
            var kv4 = signals.GetOutput(SensorName.Relay(RelayName.Kv4));
            var kv8 = signals.GetOutput(SensorName.Relay(RelayName.Kv8));
            var kv9 = signals.GetOutput(SensorName.Relay(RelayName.Kv9));
            var kv10 = signals.GetOutput(SensorName.Relay(RelayName.Kv10));
            var kv11 = signals.GetOutput(SensorName.Relay(RelayName.Kv11));

            var list = new List<IOutput> {kv4, kv8, kv9, kv10, kv11};


            var sensors = new List<ISignal>
                              {
                                  signals.GetSignal(SensorName.Relay(RelayName.Kv1, SignalName.Feedback)),
                                  signals.GetSignal(SensorName.Relay(RelayName.Kv2, SignalName.Feedback)),
                                  signals.GetSignal(SensorName.Relay(RelayName.Kv8, SignalName.Feedback)),
                                  signals.GetSignal(SensorName.Relay(RelayName.Kv9, SignalName.Feedback)),
                                  signals.GetSignal(SensorName.Relay(RelayName.Kv10, SignalName.Feedback)),
                                  signals.GetSignal(SensorName.Relay(RelayName.Kv11, SignalName.Feedback))
                              };

            var timer = new PeriodicTask(500);
            timer.OnPeriod += () =>
                                  {
                                      Console.Write("\r");

                                      foreach (var sensor in sensors)
                                      {
                                          Console.ForegroundColor = sensor.Value > 0
                                                                        ? ConsoleColor.Green
                                                                        : ConsoleColor.Gray;
                                          Console.Write("{0}: {1}\t", sensor.Id.Replace("relay.", ""), sensor.Value);
                                      }
                                  };
            timer.Start();
            */


            Keyboard.OnPress += value =>
            {
                Console.WriteLine("press: {0}", value);
                /*
                switch (value)
                {
                        case KeyboardCode.SpeedUp:
                        kv4.Set(true);
                        break;

                        case KeyboardCode.MotionStart:
                        kv8.Set(true);
                        break;

                        case KeyboardCode.SpeedDown:
                        kv9.Set(true);
                        break;

                        case KeyboardCode.MotionStop:
                        kv10.Set(true);
                        break;

                        case KeyboardCode.PumpStart:
                        kv11.Set(true);
                        break;
                }
                */
            };


            Keyboard.OnRelese += value =>
            {
                Console.WriteLine("release: {0}", value);
                /*
                foreach (var output in list)
                {
                    output.Set(false);
                }
                */
            };

        }
    }
}
