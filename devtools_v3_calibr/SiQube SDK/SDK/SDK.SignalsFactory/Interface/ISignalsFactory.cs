namespace SDK.SignalsFactory.Interface
{   
    public interface ISignalsFactory
    {
        /// <summary>
        /// �������� ������ �� ��� ��������������
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ISignal GetSignal(string id);

        /// <summary>
        /// �������� ������������ ������
        /// </summary>
        /// <returns></returns>
        ISignal AddSignal(string id, string description);

        /// <summary>
        /// �������� ���������������� �������� (�������� ��� ������������ ����� ����)
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        ISignal AddStored(SignalSpecification specification);

        /// <summary>
        /// ��������� ������������� ����� � ���� � ��� ������
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        /// <param name="Idpref">������� ����� ������ min ��� max</param>
        /// <param name="raw">�������� �������</param>
        /// <param name="physical">���������� ��������, �������������� �������� �������</param>
        /// <returns>����������� ��� ���</returns>
        bool AddCalibrationPoint(string signalId, string Idpref, int raw, float physical);

        /// <summary>
        /// ��������� ������������� ����� � ���� � ����� ������� (��� ����� ���. ��������, �.�. ���. �������� �� ��������)
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        /// <param name="Idpref">������� ����� ������ min ��� max</param>
        /// <param name="raw">�������� �������</param>
        bool UpdateCalibrationPointWithoutPhysical(string signalId, string Idpref, int raw);

        /// <summary>
        /// ��������� ������������� ����� �� ������������� � ����
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        /// <param name="Idpref">������� ����� ������ min ��� max</param>
        bool IsCheckCalibrationPointExist(string signalId, string Idpref);

        /// <summary>
        /// ��������� ������������� ����� �� ������������� � ����, ���� ��� ��� ���� �� ������ �� � ������
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        bool IsCheckOrLoadCalibrationPointExist(string signalId);

        /// <summary>
        /// ��������� ������������� ����� � ���� � ����� ������� � ������ ��������� ���. ��������
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        /// <param name="Idpref">������� ����� ������ min ��� max</param>
        /// <param name="raw">�������� �������</param>
        /// <param name="physical">���������� ��������, �������������� �������� �������</param>
        bool UpdateCalibrationPoint(string signalId, string Idpref, int raw, float physical);

        /// <summary>
        /// ������ �� ���� ��� ������������� ����� � ������
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        /// <param name="checkmode">������ ����� �������� �����, ��� �������� � ������</param>
        bool LoadAllCalibrationPoints(string signalId, bool checkmode = false);

        /// <summary>
        /// ������ ������������� ����� �� �������
        /// </summary>
        /// <param name="signalId">������������� �������</param>
        bool GetCalibrationPoint(string signalId, out int min, out int max);

        /// <summary>
        /// ���������� ������������� �������
        /// </summary>
        bool ClearCalibration(string signalId);

        /// <summary>
        /// ��������� ���� ���� �������� � ��������� ����
        /// </summary>
        string WriteInfo(string FileName);

        void Add(ISignal signal);
    }
}