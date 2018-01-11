using System;

namespace SDK.SignalsFactory.Interface
{
    public delegate void SignalEvent(IReadonlySignal signal);
    
    public interface IReadonlySignal
    {
        /// <summary>
        /// ������ �������� �������
        /// </summary>
        SignalSpecification Specification { get; }

        /// <summary>
        /// ������ �������� ������� QT
        /// </summary>
        QtSignalSpecification QtSpecification { get; }

        /// <summary>
        /// ����� ���������� ���������� ����������
        /// </summary>
        DateTime LastUpdate { get; }

        /// <summary>
        /// ��������� ������� 
        /// </summary>
        SignalState State { get; }

        /// <summary>
        /// ������� �� ������ ������ Update
        /// </summary>
        event SignalEvent OnUpdate;

        /// <summary>
        /// ������� �� ��������� ����������� ���������
        /// </summary>
        event SignalEvent OnChange;

        /// <summary>
        /// ������� ��������, ����������� � ���������� ��������
        ///  </summary>
        float Value { get; }

        /// <summary>
        /// �������� �������� ��� bool 
        /// </summary>
        bool IsSet { get; }

        /// <summary>
        /// �������� �������� ��� int, ����������� � ���������� ��������
        /// </summary>
        int ValueAsInt { get; }

        /// <summary>
        /// ��������������� ����� ��������
        /// </summary>
        /// <returns></returns>
        string ToString();


    }
}