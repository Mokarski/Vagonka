using ProtoBuf;

namespace SDK.SignalsFactory.Interface
{
    [ProtoContract]
    public enum SignalType
    {
        /// <summary>
        /// Описание команды на выполнение (для меню)
        /// </summary>
        Action,

        /// <summary>
        /// Дискретное значение
        /// </summary>
        Bool,

        /// <summary>
        /// 16 битное значение
        /// </summary>
        Ushort,

        /// <summary>
        /// значение с плавающей точкой одиночной точности
        /// </summary>
        Float,

        /// <summary>
        /// перечисление - строковое значение (для stored value в меню)
        /// </summary>
        Enum
    }
}