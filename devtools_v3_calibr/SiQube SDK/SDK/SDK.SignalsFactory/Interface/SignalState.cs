using ProtoBuf;

namespace SDK.SignalsFactory.Interface
{
    [ProtoContract]
    public enum SignalState
    {
        /// <summary>
        /// �������� ��� ���������� ������
        /// </summary>
        Connected,

        /// <summary>
        /// ���������
        /// </summary>
        Disconnected,

        /// <summary>
        /// �������� ��������� � ��������� ��������������
        /// </summary>
        Warning,

        /// <summary>
        /// �������� ��������� � �������� ���������
        /// </summary>
        Alarm,

        /// <summary>
        /// ������ �� ������ �������
        /// </summary>
        Failure
    }
}