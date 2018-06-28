using ProtoBuf;

namespace SDK.SignalsFactory.Interface
{
    [ProtoContract]
    public enum SignalType
    {
        /// <summary>
        /// �������� ������� �� ���������� (��� ����)
        /// </summary>
        Action,

        /// <summary>
        /// ���������� ��������
        /// </summary>
        Bool,

        /// <summary>
        /// 16 ������ ��������
        /// </summary>
        Ushort,

        /// <summary>
        /// �������� � ��������� ������ ��������� ��������
        /// </summary>
        Float,

        /// <summary>
        /// ������������ - ��������� �������� (��� stored value � ����)
        /// </summary>
        Enum
    }
}