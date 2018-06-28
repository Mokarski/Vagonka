using System.Collections.Generic;
using Service.Model;

namespace Service.Repositories
{
    public interface IControllerRepository
    {
        /// <summary>
        /// Список Imei всех контроллеров
        /// </summary>
        /// <returns></returns>
        List<long> GetImeiList();

        /// <summary>
        /// Список контроллеров
        /// </summary>
        /// <returns></returns>
        List<Model.Controller> GetControllers();

        /// <summary>
        /// Список контроллеров по заданным imei
        /// </summary>
        /// <param name="imeiList"></param>
        /// <returns></returns>
        Controllers GetControllers(IEnumerable<long> imeiList);

        /// <summary>
        /// Список контроллеров с заданным timeTableId
        /// </summary>
        /// <returns></returns>
        Controllers GetControllersByTimeTableId(int timeTableId);

        /// <summary>
        /// Найти контроллер по его imei
        /// </summary>
        /// <param name="imei"></param>
        /// <returns></returns>
        Model.Controller Find(long imei);

        /// <summary>
        /// Найти контроллер по Id фазы
        /// </summary>
        /// <param name="phaseId"></param>
        /// <returns></returns>
        Model.Controller FindController(int phaseId);

        /// <summary>
        /// Список всех фаз
        /// </summary>
        /// <returns></returns>
        List<Phase> GetAllPhases();

        /// <summary>
        /// Найти фазу по Id
        /// </summary>
        /// <param name="phaseId"></param>
        /// <returns></returns>
        Phase FindPhase(int phaseId);
    }
}