using SDK.SignalsFactory.Interface;

namespace Sensors.Invertors
{
    public enum EngineStatus
    {
        Init,
        Prelaunched,
        Stopped,
        Activated,
        Failure
    }
    
    public interface IInvertor
    {
        /// <summary>
        /// Статус инвертора
        /// </summary>
        EngineStatus Status { get;}

        /// <summary>
        /// Событие по внутренней ошибке инвертора
        /// </summary>
        event SignalEvent OnError;

        /// <summary>
        /// Идентификатор
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Направление вращения
        /// </summary>
        /// <param name="forward"></param>
        void Direction(bool forward);

        /// <summary>
        /// Частота в сотых Гц (0.01 Гц)
        /// </summary>
        /// <param name="value"></param>
        void Frequency(ushort value);

        /// <summary>
        /// Текущая реальная частота
        /// </summary>
        /// <returns></returns>
        ushort GetFrequency();

        /// <summary>
        /// Включение
        /// </summary>
        void On(bool isBroadcast);

        /// <summary>
        /// Выключение
        /// </summary>
        void Off(bool isBroadcast);

        /// <summary>
        /// Сброс ошибок
        /// </summary>
        void ResetFault();
    }
}