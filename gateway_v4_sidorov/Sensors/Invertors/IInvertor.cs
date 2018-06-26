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
        /// ������ ���������
        /// </summary>
        EngineStatus Status { get;}

        /// <summary>
        /// ������� �� ���������� ������ ���������
        /// </summary>
        event SignalEvent OnError;

        /// <summary>
        /// �������������
        /// </summary>
        string Id { get; }

        /// <summary>
        /// ����������� ��������
        /// </summary>
        /// <param name="forward"></param>
        void Direction(bool forward);

        /// <summary>
        /// ������� � ����� �� (0.01 ��)
        /// </summary>
        /// <param name="value"></param>
        void Frequency(ushort value);

        /// <summary>
        /// ������� �������� �������
        /// </summary>
        /// <returns></returns>
        ushort GetFrequency();

        /// <summary>
        /// ���������
        /// </summary>
        void On(bool isBroadcast);

        /// <summary>
        /// ����������
        /// </summary>
        void Off(bool isBroadcast);

        /// <summary>
        /// ����� ������
        /// </summary>
        void ResetFault();
    }
}