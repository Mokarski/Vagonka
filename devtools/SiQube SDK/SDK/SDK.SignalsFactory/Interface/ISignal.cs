namespace SDK.SignalsFactory.Interface
{
    public interface ISignal : IReadonlySignal
    {      
        /// <summary>
        /// Обновление датчика
        /// </summary>
        /// <param name="value"></param>
        void Update(float value);

        /// <summary>
        /// Обновление датчика
        /// </summary>
        /// <param name="value"></param>
        void Update(uint value);

        /// <summary>
        /// Обновление датчика
        /// </summary>
        /// <param name="value"></param>
        void Update(bool value);

    }
}