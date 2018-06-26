namespace SDK.SignalsFactory.Interface
{   
    public interface ISignalsFactory
    {
        /// <summary>
        /// Получить сигнал по его идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ISignal GetSignal(string id);

        /// <summary>
        /// Добавить реалтаймовый сигнал
        /// </summary>
        /// <returns></returns>
        ISignal AddSignal(string id, string description);

        /// <summary>
        /// Добавить конфигурационный параметр (доступен для конфигурации через меню)
        /// </summary>
        /// <param name="specification"></param>
        /// <returns></returns>
        ISignal AddStored(SignalSpecification specification);

        /// <summary>
        /// Добавляем калибровочную точку в базу и сам сигнал
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        /// <param name="Idpref">префикс точки только min или max</param>
        /// <param name="raw">значение датчика</param>
        /// <param name="physical">физическая величина, соответсвующая значению датчика</param>
        /// <returns>Установлено или нет</returns>
        bool AddCalibrationPoint(string signalId, string Idpref, int raw, float physical);

        /// <summary>
        /// Обновляем калибровочную точку в базе и самом сигнале (без учета физ. величины, т.е. физ. величина не меняется)
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        /// <param name="Idpref">префикс точки только min или max</param>
        /// <param name="raw">значение датчика</param>
        bool UpdateCalibrationPointWithoutPhysical(string signalId, string Idpref, int raw);

        /// <summary>
        /// Проверяем калибровочную точку на существование в базе
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        /// <param name="Idpref">префикс точки только min или max</param>
        bool IsCheckCalibrationPointExist(string signalId, string Idpref);

        /// <summary>
        /// Проверяем калибровочную точку на существование в базе, если она там есть то грузим ее в сигнал
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        bool IsCheckOrLoadCalibrationPointExist(string signalId);

        /// <summary>
        /// Обновляем калибровочную точку в базе и самом сигнале с учетом изменения физ. величины
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        /// <param name="Idpref">префикс точки только min или max</param>
        /// <param name="raw">значение датчика</param>
        /// <param name="physical">физическая величина, соответсвующая значению датчика</param>
        bool UpdateCalibrationPoint(string signalId, string Idpref, int raw, float physical);

        /// <summary>
        /// Грузим из базы все калибровочные точки в сигнал
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        /// <param name="checkmode">только режим проверки точек, без загрузки в сигнал</param>
        bool LoadAllCalibrationPoints(string signalId, bool checkmode = false);

        /// <summary>
        /// Грузим калибровочные точки из сигнала
        /// </summary>
        /// <param name="signalId">идентификатор сигнала</param>
        bool GetCalibrationPoint(string signalId, out int min, out int max);

        /// <summary>
        /// Сбрасываем калибровочные таблицы
        /// </summary>
        bool ClearCalibration(string signalId);

        /// <summary>
        /// Сохраняем дамп всех сигналов в текстовый файл
        /// </summary>
        string WriteInfo(string FileName);

        void Add(ISignal signal);
    }
}