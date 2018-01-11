namespace Sensors.B17K
{

    public class Sensor
    {
        public string Value;
        public string Channel;
        public string Permission;

        public SensorLevelEvent Alarm;
        public SensorLevelEvent Warning;

        public Sensor(string preffix)
        {
            Value = preffix;
            Channel = preffix + ".channel";
            Permission = preffix + ".enable";
            Alarm = new SensorLevelEvent(preffix + ".alarm");
            Warning = new SensorLevelEvent(preffix + ".warning");
        }

        public class SensorLevelEvent
        {
            public string Max;
            public string Min;

            public SensorLevelEvent(string preffix)
            {
                Min = preffix + ".min";
                Max = preffix + ".max";
            }
        }
    }

    public class Id
    {
        private const string kTemperature = ".temperature";
        private const string kPressure = ".pressure";
        private const string kLevel = ".level";
       

        public class Engine
        {
            private const string kPreffix = "engine";
            public static Sensor Temperature = new Sensor(kPreffix + kTemperature);
            public static Sensor Level = new Sensor(kPreffix + kLevel);

            public class Limit
            {
                public class FmaxByTangage
                {
                    public static string[] Values =
                    {
                        kPreffix + ".limit.tangage.0",
                        kPreffix + ".limit.tangage.1",
                        kPreffix + ".limit.tangage.2",
                        kPreffix + ".limit.tangage.3",
                        kPreffix + ".limit.tangage.4",
                        kPreffix + ".limit.tangage.5",
                        kPreffix + ".limit.tangage.6",
                        kPreffix + ".limit.tangage.7",
                        kPreffix + ".limit.tangage.8",
                        kPreffix + ".limit.tangage.9",
                        kPreffix + ".limit.tangage.10",
                        kPreffix + ".limit.tangage.11",
                        kPreffix + ".limit.tangage.12",
                        kPreffix + ".limit.tangage.13",
                        kPreffix + ".limit.tangage.14",
                        kPreffix + ".limit.tangage.15"
                    };
                    public const string Permission = kPreffix + ".limit.tangage.enable";
                }
            }
        }

        public static class Tank
        {
            private const string kPreffix = "tank";
            public static Sensor Pressure = new Sensor(kPreffix + kPressure);
        }
    }


    public static class SystemStateCodes
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
            TankLevelMin = 1000,

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
            TankLevelMin = 2000,

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
            Kv10OutOfControl,

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

    enum SystemStateCodes2
    {
        /// <summary>
        /// Пониженный уровень масла (предупреждение)
        /// </summary>
        TankLevelWarningMin,

        /// <summary>
        /// Аварийный уровень масла (авария)
        /// </summary>
        TankLevelAlarmMin,

        /// <summary>
        /// Повышенная температура масла (предупреждение)
        /// </summary>
        TankTemperatureWarningMin,

        /// <summary>
        /// Максимальная температура масла (авария)
        /// </summary>
        TankTemperatureAlarmMin,

        /// <summary>
        /// Давление в рулевой магистрали вне допустимого диапазона (предупреждение)
        /// </summary>
        SystemPressureOutOfRange,

        /// <summary>
        /// Повышенная Разница давления на фильтре (предупреждение)
        /// </summary>
        FilterPressureWarningMax,

        /// <summary>
        /// Аварийная Разница давления на фильтре (авария)
        /// </summary>
        FilterPressureAlarmMax,

        /// <summary>
        /// Максимальное давление  в магистрали Кабельного Барабана (предупреждение)
        /// </summary>
        CabelPressureWarningMax,

        /// <summary>
        /// Минимальное давление в магистрали Кабельного Барабана (авария)
        /// </summary>
        CabelPressureAlarmMin,

        /// <summary>
        /// Аварийное максимальное давление  в магистрали Кабельного Барабана (авария)
        /// </summary>
        CabelPressureAlarmMax,

        /// <summary>
        /// Аварийное максимальное давление  в тормозной магистрали (авария)
        /// </summary>
        BrakePressureAlarmMax,

        /// <summary>
        /// Минимальное давление в тормозной магистрали (авария)
        /// </summary>
        BrakePressureAlarmMin,

        /// <summary>
        /// Максимальное давление в тормозной магистрали (предупреждение)
        /// </summary>
        BrakePressureWarningMax,

        /// <summary>
        /// Потеря управлямости реле Kv11
        /// </summary>
        Kv11OutOfControl,
        Kv1OutOfControl,
        Kv8OutOfControl,
        Kv9OutOfControl,

        /// <summary>
        /// Инициализация 
        /// </summary>
        Initialization,

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
