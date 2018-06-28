namespace Sensors.B17K
{
    public enum SystemState
    {
        /// <summary>
        /// �������������� �������� ��� ��������� ����� ������ ������ 
        ///  </summary>
        Init,

        /// <summary>
        /// ����������� ��� ����������� �������, ��� ������
        /// </summary>
        Ready,

        /// <summary>
        /// ��������� � ��������� ������
        /// </summary>
        Active,

        /// <summary>
        /// ���������� �������������
        /// </summary>
        UserLock,

        /// <summary>
        /// ������ � ������, ������������
        /// </summary>
        Failure
    }
}