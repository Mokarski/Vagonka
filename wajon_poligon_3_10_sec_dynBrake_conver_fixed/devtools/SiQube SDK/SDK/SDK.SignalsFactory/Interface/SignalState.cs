using ProtoBuf;

namespace SDK.SignalsFactory.Interface
{
    [ProtoContract]
    public enum SignalState
    {
        /// <summary>
        /// Доступен для корректной работы
        /// </summary>
        Connected,

        /// <summary>
        /// Отключено
        /// </summary>
        Disconnected,

        /// <summary>
        /// Значение находится в диапазоне предупреждения
        /// </summary>
        Warning,

        /// <summary>
        /// Значение находится в аварином диапазоне
        /// </summary>
        Alarm,

        /// <summary>
        /// Защита по работе сенсора
        /// </summary>
        Failure
    }
}