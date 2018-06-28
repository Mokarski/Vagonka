using System;
using ProtoBuf;

namespace SDK.SignalsFactory.Interface
{
    /// <summary>
    /// ����� ��� ���������� ������ ���������
    /// </summary>
    [ProtoContract]
    public class SignalStatus
    {
        /// <summary>
        /// ������� ��������� �������
        /// </summary>
        [ProtoMember(1)]
        public SignalState State { get; set; }

        /// <summary>
        /// ������� ��������, ����������� �� ������������� �������
        /// </summary>
        [ProtoMember(2)]
        public float Value { get; set; }

        /// <summary>
        /// ����� ���������� ���������� ����������
        /// </summary>
        [ProtoMember(3)]
        public DateTime LastUpdate { get; set; }
    }
}