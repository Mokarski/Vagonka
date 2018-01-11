using System;

namespace SDK.SignalsFactory.Interface
{
    public delegate void SignalEvent(IReadonlySignal signal);
    
    public interface IReadonlySignal
    {
        /// <summary>
        /// Полное описание сигнала
        /// </summary>
        SignalSpecification Specification { get; }

        /// <summary>
        /// Полное описание сигнала QT
        /// </summary>
        QtSignalSpecification QtSpecification { get; }

        /// <summary>
        /// Время последнего обновления информации
        /// </summary>
        DateTime LastUpdate { get; }

        /// <summary>
        /// Состояние сигнала 
        /// </summary>
        SignalState State { get; }

        /// <summary>
        /// Событие по вызову метода Update
        /// </summary>
        event SignalEvent OnUpdate;

        /// <summary>
        /// Событие по изменению внутреннего состояния
        /// </summary>
        event SignalEvent OnChange;

        /// <summary>
        /// Текущее значение, приведенное в физическую величину
        ///  </summary>
        float Value { get; }

        /// <summary>
        /// Получить значение как bool 
        /// </summary>
        bool IsSet { get; }

        /// <summary>
        /// Получить значение как int, приведенное в физическую величину
        /// </summary>
        int ValueAsInt { get; }

        /// <summary>
        /// Форматированный вывод значения
        /// </summary>
        /// <returns></returns>
        string ToString();


    }
}