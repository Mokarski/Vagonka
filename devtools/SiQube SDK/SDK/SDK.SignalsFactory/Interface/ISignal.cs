namespace SDK.SignalsFactory.Interface
{
    public interface ISignal : IReadonlySignal
    {      
        /// <summary>
        /// ���������� �������
        /// </summary>
        /// <param name="value"></param>
        void Update(float value);

        /// <summary>
        /// ���������� �������
        /// </summary>
        /// <param name="value"></param>
        void Update(uint value);

        /// <summary>
        /// ���������� �������
        /// </summary>
        /// <param name="value"></param>
        void Update(bool value);

    }
}