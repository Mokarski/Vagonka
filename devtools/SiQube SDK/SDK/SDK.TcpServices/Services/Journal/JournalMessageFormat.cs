namespace SDK.NetworksServices.Services.Journal
{
    public class InfoMessage
    {
        /// <summary>
        /// Включение системы
        /// </summary>
        public static string SystemStart
        {
            get { return "Включение системы"; }
        }

        /// <summary>
        /// Запуск вулканизатора
        /// </summary>
        public static string VulcanizerStart
        {
            get { return "Запуск вулканизатора"; }
        }

        /// <summary>
        /// Остановка вулканизатора
        /// </summary>
        public static string VulcanizerStop
        {
            get { return "Остановка вулканизатора"; }
        }

        /// <summary>
        /// Включен подготовительный режим
        /// </summary>
        public static string PreparingMode
        {
            get { return "Включен подготовительный режим"; }
        }

        /// <summary>
        /// Включен рабочий режим
        /// </summary>
        public static string OperatingMode
        {
            get { return "Включен рабочий режим"; }
        }

        //добавить переключение отображаемого параметра
    }

    public class WarningMessage
    {
        /// <summary>
        /// Перезапуск системы
        /// </summary>
        public static string SystemRestart
        {
            get { return "Перезапуск системы"; }
        }

        /// <summary>
        /// Автоматический перезапуск вулканизатора
        /// </summary>
        public static string VulcanizerAutomaticRestart
        {
            get { return "Автоматический перезапуск вулканизатора"; }
        }

        /// <summary>
        /// Принудительный перезапуск вулканизатора
        /// </summary>
        public static string VulcanizerForceRestart
        {
            get { return "Принудительный перезапуск вулканизатора"; }
        }

        /// <summary>
        /// Принудительный запуск вулканизатора
        /// </summary>
        public static string VulcanizerForceStart
        {
            get { return "Принудительный запуск вулканизатора"; }
        }

        /// <summary>
        /// Принудительная остановка вулканизатора
        /// </summary>
        public static string VulcanizerForceStop
        {
            get { return "Принудительная остановка вулканизатора"; }
        }
    }

    public class ErrorMessage
    {
        /// <summary>
        /// Принудительная остановка вулканизатора
        /// </summary>
        public static string OnHeaterCountError
        {
            get { return "Принудительная остановка вулканизатора"; }
        }

        /// <summary>
        /// Принудительная остановка вулканизатора
        /// </summary>
        public static string OnTermalSensorLost
        {
            get { return "Принудительная остановка вулканизатора"; }
        }

        /// <summary>
        /// Принудительная остановка вулканизатора
        /// </summary>
        public static string OnConnectionError
        {
            get { return "Принудительная остановка вулканизатора"; }
        }

        /// <summary>
        /// Принудительная остановка вулканизатора
        /// </summary>
        public static string OnHeatingError
        {
            get { return "Принудительная остановка вулканизатора"; }
        }

        //обработать вышеописанные ошибки и добавить обработку реакций по исключениям ошибок
    }
}
