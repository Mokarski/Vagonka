using System.Data.SqlClient;
using SDK.SignalsFactory;

namespace SignalsNamespace
{
    public static class SystemCodes
    {
        private const int kStateStartAt = 0;
        private const int kWarningStartAt = 1000;
        private const int kAlarmStartAt = 2000;

        public enum State
        {
            /// <summary>
            /// Инициализация 
            /// </summary>
            Initialization = kStateStartAt,

            /// <summary>
            /// Активен режим ход 
            /// </summary>
            MotionMode,

            /// <summary>
            /// Режим ожидания (норма)
            /// </summary>
            ReadyToUse,

            /// <summary>
            /// Активен режим конвейера
            /// </summary>
            ConveyorMode,
        }

        public enum Warning
        {
            /// <summary>
            /// Пониженный уровень масла (предупреждение)
            /// </summary>
            TankLevelMin = kWarningStartAt,

            /// <summary>
            /// Повышенная температура масла (предупреждение)
            /// </summary>
            TankTemperatureMin,

            /// <summary>
            /// Повышенная Разница давления на фильтре (предупреждение)
            /// </summary>
            FilterPressureMax,

            /// <summary>
            /// Максимальное давление  в магистрали Кабельного Барабана (предупреждение)
            /// </summary>
            CabelPressureMax,

            /// <summary>
            /// Максимальное давление в тормозной магистрали (предупреждение)
            /// </summary>
            BrakePressureMax
        }

        public enum Alarm
        {
            /// <summary>
            /// Аварийный уровень масла (авария)
            /// </summary>
            TankLevelMin = kAlarmStartAt,

            /// <summary>
            /// Максимальная температура масла (авария)
            /// </summary>
            TankTemperatureMin,

            /// <summary>
            /// Давление в рулевой магистрали вне допустимого диапазона (авария)
            /// </summary>
            SystemPressureOutOfRange,

            /// <summary>
            /// Аварийная Разница давления на фильтре (авария)
            /// </summary>
            FilterPressureMax,

            /// <summary>
            /// Минимальное давление в магистрали Кабельного Барабана (авария)
            /// </summary>
            CabelPressureMin,

            /// <summary>
            /// Аварийное максимальное давление  в магистрали Кабельного Барабана (авария)
            /// </summary>
            CabelPressureMax,

            /// <summary>
            /// Аварийное максимальное давление  в тормозной магистрали (авария)
            /// </summary>
            BrakePressureMax,

            /// <summary>
            /// Минимальное давление в тормозной магистрали (авария)
            /// </summary>
            BrakePressureMin,

            /// <summary>
            /// Потеря управлямости реле Kv11
            /// </summary>
            Kv11OutOfControl,
            Kv1OutOfControl,
            Kv8OutOfControl,
            Kv9OutOfControl,

            /// <summary>
            /// Сработал корд 1
            /// </summary>
            Cord1OutOfControl,
            Cord2OutOfControl,
            Cord3OutOfControl,
            Cord4OutOfControl,
            Cord5OutOfControl,
            Cord6OutOfControl,
            Cord7OutOfControl,
            UnknownCordOutOfControl,

            /// <summary>
            /// защита в работе частотника Uz.x
            /// </summary>
            Uz2Error,
            Uz3Error,
            Uz4Error,
            Uz5Error,
            UnknownNameUzError
        }
    }

    [Id("")]
    public class B17K
    {
        /// <summary>
        /// Рабочие параметры всех систем управления
        /// </summary>
        public class Status
        {
            /// <summary>
            /// Общий статус системы
            /// </summary>
            [UshortSignal((ushort)SystemCodes.State.Initialization)]
            public static string Code;

            /// <summary>
            /// Крен
            /// </summary>
            [FloatSignal(DefaultValue = 0.0f)]
            public static string Roll;

            /// <summary>
            /// Тангаж
            /// </summary>
            [FloatSignal(DefaultValue = 0.0f)]
            public static string Tangage;

            /// <summary>
            /// Скорость движения вагона
            /// </summary>
            [FloatSignal(DefaultValue = 0.0f)]
            public static string Speed;

            /// <summary>
            /// Код состояния клавиатуры
            /// </summary>
            [UshortSignal(0)]
            public static string Keyboard;

            /// <summary>
            /// Описательная часть силовых установок
            /// </summary>
            [Id("")]
            public class Engine
            {                
                public class Pedals
                {
                    /// <summary>
                    /// Педаль "назад"
                    /// </summary>
                    [BoolSignal]
                    public static string Reverse;

                    /// <summary>
                    /// Педаль "вперед"
                    /// </summary>
                    [BoolSignal]
                    public static string Forward;                     
                }

                public class Gear
                {
                    /// <summary>
                    /// Установленная передача в режиме "конвейер"
                    /// </summary>
                    [UshortSignal(1)]
                    public static string Conveyor;

                    /// <summary>
                    /// Установленная передача в режиме "ход"
                    /// </summary>
                    [UshortSignal(1)]
                    public static string Engine;
                }
                
                /// <summary>
                /// Силовая установка uz2 с учетом системы защиты
                /// </summary>
                public class Uz2
                {
                    /// <summary>
                    /// Статус работы силовой установки с учетом системы защиты
                    /// </summary>
                    public static string Code;
                    /// <summary>
                    /// Состояние работы инвертора
                    /// </summary>
                    public class Invertor
                    {
                        /// <summary>
                        /// Режим работы, 1 - стоп, 2 - работа, 3 - авария, 4 - запуск
                        /// </summary>
                        public static string State;

                        /// <summary>
                        /// Статус последнего выключения: 0 - нормально выключен, все что больше нуля - защита
                        /// </summary>
                        public static string Code;

                        /// <summary>
                        /// Частота работы в сотых Гц 
                        /// </summary>
                        public static string Frequency;

                        /// <summary>
                        /// Ток инвертора
                        /// </summary>
                        public static string Current;

                        /// <summary>
                        /// Напряжение на выходе
                        /// </summary>
                        public static string Voltage;

                        /// <summary>
                        /// Рабочая температура
                        /// </summary>
                        public static string Temperature;
                    }
                }

                /// <summary>
                /// Силовая установка uz3 с учетом системы защиты
                /// </summary>
                public class Uz3
                {
                    /// <summary>
                    /// Статус работы силовой установки с учетом системы защиты
                    /// </summary>
                    public static string Code;

                    /// <summary>
                    /// Состояние работы инвертора
                    /// </summary>
                    public class Invertor
                    {
                        /// <summary>
                        /// Режим работы, 1 - стоп, 2 - работа, 3 - авария, 4 - запуск
                        /// </summary>
                        public static string State;

                        /// <summary>
                        /// Статус последнего выключения: 0 - нормально выключен, все что больше нуля - защита
                        /// </summary>
                        public static string Code;

                        /// <summary>
                        /// Частота работы в сотых Гц 
                        /// </summary>
                        public static string Frequency;

                        /// <summary>
                        /// Ток инвертора
                        /// </summary>
                        public static string Current;

                        /// <summary>
                        /// Напряжение на выходе
                        /// </summary>
                        public static string Voltage;

                        /// <summary>
                        /// Рабочая температура
                        /// </summary>
                        public static string Temperature;
                    }
                }

                /// <summary>
                /// Силовая установка uz4 с учетом системы защиты. Используется также в режиме конвейера
                /// </summary>
                public class Uz4
                {
                    /// <summary>
                    /// Статус работы силовой установки с учетом системы защиты
                    /// </summary>
                    public static string Code;

                    /// <summary>
                    /// Состояние работы инвертора
                    /// </summary>
                    public class Invertor
                    {
                        /// <summary>
                        /// Режим работы, 1 - стоп, 2 - работа, 3 - авария, 4 - запуск
                        /// </summary>
                        public static string State;

                        /// <summary>
                        /// Статус последнего выключения: 0 - нормально выключен, все что больше нуля - защита
                        /// </summary>
                        public static string Code;

                        /// <summary>
                        /// Частота работы в сотых Гц 
                        /// </summary>
                        public static string Frequency;

                        /// <summary>
                        /// Ток инвертора
                        /// </summary>
                        public static string Current;

                        /// <summary>
                        /// Напряжение на выходе
                        /// </summary>
                        public static string Voltage;

                        /// <summary>
                        /// Рабочая температура
                        /// </summary>
                        public static string Temperature;
                    }
                }

                /// <summary>
                /// Силовая установка uz5 с учетом системы защиты
                /// </summary>
                public class Uz5
                {
                    /// <summary>
                    /// Статус работы силовой установки с учетом системы защиты
                    /// </summary>
                    public static string Code;

                    /// <summary>
                    /// Состояние работы инвертора
                    /// </summary>
                    public class Invertor
                    {
                        /// <summary>
                        /// Режим работы, 1 - стоп, 2 - работа, 3 - авария, 4 - запуск
                        /// </summary>
                        public static string State;

                        /// <summary>
                        /// Статус последнего выключения: 0 - нормально выключен, все что больше нуля - защита
                        /// </summary>
                        public static string Code;

                        /// <summary>
                        /// Частота работы в сотых Гц 
                        /// </summary>
                        public static string Frequency;

                        /// <summary>
                        /// Ток инвертора
                        /// </summary>
                        public static string Current;

                        /// <summary>
                        /// Напряжение на выходе
                        /// </summary>
                        public static string Voltage;

                        /// <summary>
                        /// Рабочая температура
                        /// </summary>
                        public static string Temperature;
                    }
                }

                /// <summary>
                /// Состояния кордов системы токовой защиты
                /// </summary>
                public class Cord
                {
                    public static string F1;
                    public static string F2;
                    public static string F3;
                    public static string F4;
                    public static string F5;
                    public static string F6;
                }

                /// <summary>
                /// Обратная связь и состояние управления реле
                /// </summary>
                public class Relay
                {

                    /// <summary>
                    /// Включение питания станции управления (заряд)
                    /// </summary>
                    [Id("")]
                    public class Kv1
                    {
                        [Id("kv1")]
                        public static string State;
                        [Id("k3")]
                        public static string Feedback;
                    }

                    /// <summary>
                    /// Контактор основного включения питания магнитной станции
                    /// </summary>
                    [Id("")]
                    public class Kv2
                    {
                        [Id("k2")]
                        public static string Feedback;
                    }

                    /// <summary>
                    /// Звуковая сигнализация
                    /// </summary>
                    [Id("")]
                    public class Kv4
                    {
                        [Id("kv4")]
                        public static string State;
                    }

                    /// <summary>
                    /// Режим "ход"
                    /// </summary>
                    [Id("")]
                    public class Kv8
                    {
                        [Id("kv8")]
                        public static string State;
                        [Id("k4")]
                        public static string Feedback;
                    }

                    /// <summary>
                    /// Режим "конвейер"
                    /// </summary>
                    [Id("")]
                    public class Kv9
                    {
                        [Id("kv9")]
                        public static string State;
                        [Id("k5")]
                        public static string Feedback;
                    }

                    /// <summary>
                    /// Аппаратный сброс сетевого выпрямителя
                    /// </summary>
                    [Id("")]
                    public class RectifierReset
                    {
                        [Id("rreset")]
                        public static string State;
                    }

                    /// <summary>
                    /// Включение насосной станции
                    /// </summary>
                    [Id("")]
                    public class Kv11
                    {
                        [Id("kv11")]
                        public static string State;
                        [Id("k1")]
                        public static string Feedback;
                    }
                }
            }

            /// <summary>
            /// Датчики в различных системах самоходного вагона
            /// </summary>
            [Id("")]
            public class Sensors
            {
                public class Phase
                {
                    /// <summary>
                    /// Напряжение на трансформаторе собственных нужд
                    /// </summary>
                    [Calibration(0, 0f, 500, 1583.33f)]
                    public static string Voltage;
                }

                public class Filter
                {
                    /// <summary>
                    /// Давление в гидросистемы фильтрации
                    /// </summary>
                    [Calibration(385, 0f, 2500, 400f)]
                    public static string Pressure;
                }

                public class Steering
                {
                    /// <summary>
                    /// Давление в гидросистемы рулевого управления
                    /// </summary>
                    [Calibration(385, 0f, 2500, 400f)]
                    public static string Pressure;

                    [Id("")]
                    public class Encoder
                    {
                        /// <summary>
                        /// Угол поворота колес
                        /// </summary>
                        [FloatSignal(DefaultValue = 0.0f)]
                        public static string Angle;
                    }
                }

                public class Cabel
                {
                    /// <summary>
                    /// Давление в гидросистемы кабельного барабана
                    /// </summary>
                    [Calibration(385, 0f, 2500, 400f)]
                    public static string Pressure;
                }

                public class Brake
                {
                    /// <summary>
                    /// Давление в гидросистемы тормозов
                    /// </summary>
                    [Calibration(385, 0f, 2500, 400f)]
                    public static string Pressure;
                }

                public class Tank
                {
                    /// <summary>
                    /// Уровень масла в баке
                    /// </summary>
                    [Calibration(900, 0f, 2085, 100.0f)]
                    public static string Level;

                    /// <summary>
                    /// Температура масла в баке
                    /// </summary>
                    [Calibration(385, 0f, 2000, 100.0f)]
                    public static string Temperature;
                }
            }
        }

        public class Settings
        {
            /// <summary>
            /// Общие настройки
            /// </summary>
            public class Generic
            {
                            
            //signals.AddStored(new SignalSpecification("pump.alarm.pressure.min", "Min рабочее давление насоса").SaveAsFloat(1.0f, true, 0.1f, 0.1f, 10.0f));
            //signals.AddStored(new SignalSpecification("pump.alarm.pressure.max", "Max рабочее давление насоса").SaveAsFloat(10.0f, true, 0.1f, 0.1f, 10.0f));
            //signals.AddStored(new SignalSpecification("pump.alarm.startup.timeout", "Время выхода насоса на режим").SaveAsUshort(10, true, 1, 1, 100)); 
            //signals.AddStored(new SignalSpecification("pump.alarm.shutdown.timeout", "Задержка на выключение насоса").SaveAsUshort(5, true, 1, 1, 30));

            //signals.AddStored(new SignalSpecification("tank.level.warning.min", "Уровень в баке, предупреждение").SaveAsUshort(10, true, 1, 1, 100));
            //signals.AddStored(new SignalSpecification("tank.level.alarm.min", "Уровень в баке, авария").SaveAsUshort(5, true, 1, 1, 100));
            //signals.AddStored(new SignalSpecification("tank.temperature.warning.max", "Т в баке, предупреждение").SaveAsUshort(70, true, 1, 1, 120));
            //signals.AddStored(new SignalSpecification("tank.temperature.alarm.max", "Т в баке, авария").SaveAsUshort(90, true, 1, 1, 120));

            //signals.AddStored(new SignalSpecification("filter.pressure.warning.max", "Давление на фильтре, предупреждение").SaveAsFloat(19.0f, true, 0.1f, 0.1f, 20.0f));
            //signals.AddStored(new SignalSpecification("filter.pressure.alarm.max", "Давление на фильтре, авария").SaveAsFloat(20.0f, true, 0.1f, 0.1f, 20.0f));           
 
            //signals.AddStored(new SignalSpecification(string.Format("{0}.warning.min", SensorName.Steering(SignalName.Pressure)), "Предупреждение P рулевого, min").SaveAsUshort(ushort.MaxValue));
            //signals.AddStored(new SignalSpecification(string.Format("{0}.warning.max", SensorName.Steering(SignalName.Pressure)), "Предупреждение P рулевого, max").SaveAsUshort(ushort.MaxValue));

            //signals.AddStored(new SignalSpecification(string.Format("{0}.warning.min", SensorName.Brake(SignalName.Pressure)), "Предупреждение P тормозного, min").SaveAsUshort(ushort.MaxValue));
            //signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.min", SensorName.Brake(SignalName.Pressure)), "Авария P тормозного, min").SaveAsUshort(ushort.MaxValue));
            //signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.max", SensorName.Brake(SignalName.Pressure)), "Авария P тормозного, max").SaveAsUshort(ushort.MaxValue));

            //signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.min", SensorName.Cabel(SignalName.Pressure)), "Авария P кабельного, min").SaveAsUshort(ushort.MaxValue));
            //signals.AddStored(new SignalSpecification(string.Format("{0}.warning.max", SensorName.Cabel(SignalName.Pressure)), "Предупреждение P кабельного, max").SaveAsUshort(ushort.MaxValue));
            //signals.AddStored(new SignalSpecification(string.Format("{0}.alarm.max", SensorName.Cabel(SignalName.Pressure)), "Авария P кабельного, max").SaveAsUshort(ushort.MaxValue));
            
                //signals.AddStored(new SignalSpecification("engines.alarm.shutdown.timeout", "Задержка на выключение двигателей").SaveAsUshort(10, true, 1, 1, 100));

                public class SoundAlarm
                {
                    public class Timeout
                    {
                        [Description("Т звучания сирены, мс")]
                        [UshortSignal(6000, Min = 1000, Step = 100, Max = 6000)]
                        public static string On;

                        [Description("Т после звучания сирены, мс")]
                        [UshortSignal(5000, Min = 1500, Step = 100, Max = 10000)]
                        public static string Off;
                    }
                }

                public class Relay
                {
                     public class Timeout
                     {
                         public class Feedback
                         {
                             /// <summary>
                             /// Время на старт контактора, мс
                             /// </summary>
                             [Description("Т включение контактора, мс")]
                             [UshortSignal(3000, Min = 1500, Step = 100, Max = 6000)]
                             public static string On;  
                         }
                     }
                }

                public class Pump
                {
                    public class Timeout
                    {
                        public class Startup
                        {
                            /// <summary>
                            /// Время на старт насосной станции, мс
                            /// </summary>
                            [Description("T старт маслянного насоса, mc")]
                            [UshortSignal(5000, Min = 3000, Step = 1000, Max = 20000)]
                            public static string On;
                        }
                    }
                }

                public class Gear 
                {
                    public class Engine
                    {
                        [Ids("C1", "C2", "C3", "C4")]
                        public static string[] Speed;

                        [UshortSignal(700, Min = 100, Step = 100, Max = 10000)]
                        [Description("Движение, скорость 1")]
                        public static string C1;

                        [UshortSignal(2500, Min = 100, Step = 100, Max = 10000)]                                                                        
                        [Description("Движение, скорость 2")]
                        public static string C2;

                        [UshortSignal(5000, Min = 100, Step = 100, Max = 10000)]                        
                        [Description("Движение, скорость 3")]
                        public static string C3;
                        
                        [UshortSignal(7500, Min = 100, Step = 100, Max = 10000)]
                        [Description("Движение, скорость 4")]
                        public static string C4;
                    }

                    public class Conveyor
                    {
                        [Ids("C1", "C2", "C3")]
                        public static string[] Speed;

                        [UshortSignal(1000, Min = 100, Step = 100, Max = 10000)]
                        [Description("Конвейер, скорость 1")]
                        public static string C1;

                        [UshortSignal(1500, Min = 100, Step = 100, Max = 10000)]
                        [Description("Конвейер, скорость 2")]
                        public static string C2;

                        [UshortSignal(2000, Min = 100, Step = 100, Max = 10000)]
                        [Description("Конвейер, скорость 3")]
                        public static string C3;
                    }
                }
            }
            
            /// <summary>
            /// Защита и компенсация
            /// </summary>
            public class Limit
            {
                /// <summary>
                /// Компенсация угла наклона при движении
                /// </summary>
                public class Tangage
                {
                    /// <summary>
                    /// Ограничение Fmax при уклоне
                    /// </summary>
                    [Description("Ограничение Fmax при уклоне")]
                    [BoolSignal]
                    public static string Enable;
                    
                    [Ids("C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15")]
                    public static string[] Compensation;

                    #region
                    [Description("Fmax, 0⁰")]
                    [Id("0")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C0;

                    [Description("Fmax, 1⁰")]
                    [Id("1")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C1;

                    [Description("Fmax, 2⁰")]
                    [Id("2")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C2;

                    [Description("Fmax, 3⁰")]
                    [Id("3")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C3;

                    [Description("Fmax, 4⁰")]
                    [Id("4")]
                    [UshortSignal(60, Min = 1, Step = 1, Max = 100)]
                    public static string C4;

                    [Description("Fmax, 5⁰")]
                    [Id("5")]
                    [UshortSignal(50, Min = 1, Step = 1, Max = 100)]
                    public static string C5;

                    [Description("Fmax, 0⁰")]
                    [Id("6")]
                    [UshortSignal(49, Min = 1, Step = 1, Max = 100)]
                    public static string C6;

                    [Description("Fmax, 7⁰")]
                    [Id("7")]
                    [UshortSignal(48, Min = 1, Step = 1, Max = 100)]
                    public static string C7;

                    [Description("Fmax, 8⁰")]
                    [Id("8")]
                    [UshortSignal(47, Min = 1, Step = 1, Max = 100)]
                    public static string C8;

                    [Description("Fmax, 9⁰")]
                    [Id("9")]
                    [UshortSignal(46, Min = 1, Step = 1, Max = 100)]
                    public static string C9;

                    [Description("Fmax, 10⁰")]
                    [Id("10")]
                    [UshortSignal(45, Min = 1, Step = 1, Max = 100)]
                    public static string C10;

                    [Description("Fmax, 11⁰")]
                    [Id("11")]
                    [UshortSignal(44, Min = 1, Step = 1, Max = 100)]
                    public static string C11;

                    [Description("Fmax, 12⁰")]
                    [Id("12")]
                    [UshortSignal(43, Min = 1, Step = 1, Max = 100)]
                    public static string C12;

                    [Description("Fmax, 13⁰")]
                    [Id("13")]
                    [UshortSignal(42, Min = 1, Step = 1, Max = 100)]
                    public static string C13;

                    [Description("Fmax, 14⁰")]
                    [Id("14")]
                    [UshortSignal(41, Min = 1, Step = 1, Max = 100)]
                    public static string C14;

                    [Description("Fmax, 15⁰+")]
                    [Id("15")]
                    [UshortSignal(40, Min = 1, Step = 1, Max = 100)]
                    public static string C15;
                    #endregion
                }
                
                /// <summary>
                /// Компенсация угла поворота колес
                /// </summary>
                public class Steering
                {
                    /// <summary>
                    /// Ограничение Fmax при уклоне
                    /// </summary>
                    [Description("Компенсация тяги при повороте")]
                    [BoolSignal]
                    public static string Enable;

                    [Description("Нулевая точка")]
                    [Id("zero")] [UshortSignal(0, Min = 1, Step = 1, Max = 1023)]                    
                    public static string ZeroPoint;

                    [Ids("C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "C10", "C11", "C12", "C13", "C14", "C15",
                         "C16", "C17", "C18", "C19", "C20", "C21", "C22", "C23", "C24", "C25", "C26", "C27", "C28", "29", "C30")]
                    public static string[] Compensation;

                    #region
                    [Id("1")]
                    [Description("%, 1⁰")]
                    [UshortSignal(100, Min = 1, Step = 1, Max = 100)]
                    public static string C1;

                    [Id("2")]
                    [Description("%, 2⁰")]
                    [UshortSignal(100, Min = 1, Step = 1, Max = 100)]
                    public static string C2;

                    [Id("3")]
                    [Description("%, 3⁰")]
                    [UshortSignal(100, Min = 1, Step = 1, Max = 100)]
                    public static string C3;

                    [Id("4")]
                    [Description("%, 4⁰")]
                    [UshortSignal(100, Min = 1, Step = 1, Max = 100)]
                    public static string C4;

                    [Id("5")]
                    [Description("%, 5⁰")]
                    [UshortSignal(100, Min = 1, Step = 1, Max = 100)]
                    public static string C5;

                    [Id("6")]
                    [Description("%, 6⁰")]
                    [UshortSignal(95, Min = 1, Step = 1, Max = 100)]
                    public static string C6;

                    [Id("7")]
                    [Description("%, 7⁰")]
                    [UshortSignal(95, Min = 1, Step = 1, Max = 100)]
                    public static string C7;

                    [Id("8")]
                    [Description("%, 8⁰")]
                    [UshortSignal(95, Min = 1, Step = 1, Max = 100)]
                    public static string C8;

                    [Id("9")]
                    [Description("%, 9⁰")]
                    [UshortSignal(95, Min = 1, Step = 1, Max = 100)]
                    public static string C9;

                    [Id("10")]
                    [Description("%, 10⁰")]
                    [UshortSignal(95, Min = 1, Step = 1, Max = 100)]
                    public static string C10;

                    [Id("11")]
                    [Description("%, 11⁰")]
                    [UshortSignal(90, Min = 1, Step = 1, Max = 100)]
                    public static string C11;

                    [Id("12")]
                    [Description("%, 12⁰")]
                    [UshortSignal(90, Min = 1, Step = 1, Max = 100)]
                    public static string C12;

                    [Id("13")]
                    [Description("%, 13⁰")]
                    [UshortSignal(90, Min = 1, Step = 1, Max = 100)]
                    public static string C13;

                    [Id("14")]
                    [Description("%, 14⁰")]
                    [UshortSignal(90, Min = 1, Step = 1, Max = 100)]
                    public static string C14;

                    [Id("15")]
                    [Description("%, 15⁰")]
                    [UshortSignal(90, Min = 1, Step = 1, Max = 100)]
                    public static string C15;

                    [Id("16")]
                    [Description("%, 16⁰")]
                    [UshortSignal(85, Min = 1, Step = 1, Max = 100)]
                    public static string C16;

                    [Id("17")]
                    [Description("%, 17⁰")]
                    [UshortSignal(85, Min = 1, Step = 1, Max = 100)]
                    public static string C17;

                    [Id("18")]
                    [Description("%, 18⁰")]
                    [UshortSignal(85, Min = 1, Step = 1, Max = 100)]
                    public static string C18;

                    [Id("19")]
                    [Description("%, 19⁰")]
                    [UshortSignal(85, Min = 1, Step = 1, Max = 100)]
                    public static string C19;

                    [Id("20")]
                    [Description("%, 20⁰")]
                    [UshortSignal(85, Min = 1, Step = 1, Max = 100)]
                    public static string C20;

                    [Id("21")]
                    [Description("%, 21⁰")]
                    [UshortSignal(80, Min = 1, Step = 1, Max = 100)]
                    public static string C21;

                    [Id("22")]
                    [Description("%, 22⁰")]
                    [UshortSignal(80, Min = 1, Step = 1, Max = 100)]
                    public static string C22;

                    [Id("23")]
                    [Description("%, 23⁰")]
                    [UshortSignal(80, Min = 1, Step = 1, Max = 100)]
                    public static string C23;

                    [Id("24")]
                    [Description("%, 24⁰")]
                    [UshortSignal(80, Min = 1, Step = 1, Max = 100)]
                    public static string C24;

                    [Id("25")]
                    [Description("%, 25⁰")]
                    [UshortSignal(80, Min = 1, Step = 1, Max = 100)]
                    public static string C25;

                    [Id("26")]
                    [Description("%, 26⁰")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C26;

                    [Id("27")]
                    [Description("%, 27⁰")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C27;

                    [Id("28")]
                    [Description("%, 28⁰")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C28;

                    [Id("29")]
                    [Description("%, 29⁰")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C29;

                    [Id("30")]
                    [Description("%, 30⁰")]
                    [UshortSignal(75, Min = 1, Step = 1, Max = 100)]
                    public static string C30;

                    #endregion   
                }
            }



            /// <summary>
            /// Датчики в различных системах самоходного вагона
            /// </summary>
            [Id("")]
            public class Sensors
            {
                public class Filter
                {
                    public class Pressure
                    {
                        [Description("Включить датчик Р фильтра")]
                        [BoolSignal]
                        public static string Enable;

                        [Description("Канал датчика Р фильтра")]
                        [UshortSignal(4, Min = 1, Step = 1, Max = 6)]
                        public static string Channel;
                    }
                }

                public class Steering
                {
                    public class Pressure
                    {
                        [Description("Включить датчик Р рулевого")]
                        [BoolSignal]
                        public static string Enable;

                        [Description("Канал датчика Р рулевое")]
                        [UshortSignal(1, Min = 1, Step = 1, Max = 6)]
                        public static string Channel;
                    }
                }

                public class Cabel
                {
                    public class Pressure
                    {
                        [Description("Включить датчик Р кабельное")]
                        [BoolSignal]
                        public static string Enable;

                        [Description("Канал датчика Р кабельное")]
                        [UshortSignal(5, Min = 1, Step = 1, Max = 6)]
                        public static string Channel;
                    }
                }

                public class Brake
                {
                    public class Pressure
                    {
                        [Description("Включить датчик Р тормозное")]
                        [BoolSignal]
                        public static string Enable;

                        [Description("Канал датчика Р тормозное")]
                        [UshortSignal(2, Min = 1, Step = 1, Max = 6)]
                        public static string Channel;
                    }                
                }

                public class Tank
                {
                    public class Level
                    {
                        [Description("Включить датчик L бак")]
                        [BoolSignal]
                        public static string Enable;

                        [Description("Канал датчика L бак")]
                        [UshortSignal(6, Min = 1, Step = 1, Max = 6)]
                        public static string Channel;
                    }

                    public class Temperature
                    {
                        [Description("Включить датчик Т бак")]
                        [BoolSignal]
                        public static string Enable;

                        [Description("Канал датчика T бак")]
                        [UshortSignal(3, Min = 1, Step = 1, Max = 6)]
                        public static string Channel;
                    }         
                }
            }
        }
    }



}