namespace Sensors.B17K
{
    public enum SystemState
    {
        /// <summary>
        /// Первоначальная проверка или состояние после сброса ошибки 
        ///  </summary>
        Init,

        /// <summary>
        /// Подготовлен для дальнейшего запуска, нет ошибок
        /// </summary>
        Ready,

        /// <summary>
        /// Находится в выбранном режиме
        /// </summary>
        Active,

        /// <summary>
        /// Блокировка пользователем
        /// </summary>
        UserLock,

        /// <summary>
        /// Ошибки в работе, заблокирован
        /// </summary>
        Failure
    }
}