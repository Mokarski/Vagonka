using System;
using ProtoBuf;

namespace SDK.SignalsFactory.Interface
{
    /// <summary>
    /// Класс для удаленного чтения состояния
    /// </summary>
    [ProtoContract]
    public class SignalStatus
    {
        /// <summary>
        /// Текущее состояние сенсора
        /// </summary>
        [ProtoMember(1)]
        public SignalState State { get; set; }

        /// <summary>
        /// Текущее значение, приведенное по калибровочной таблице
        /// </summary>
        [ProtoMember(2)]
        public float Value { get; set; }

        /// <summary>
        /// Время последнего обновления информации
        /// </summary>
        [ProtoMember(3)]
        public DateTime LastUpdate { get; set; }
    }
}