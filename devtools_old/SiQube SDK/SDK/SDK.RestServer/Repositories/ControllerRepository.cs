using System.Collections.Generic;
using System.Linq;
using Service.Model;

namespace Service.Repositories
{
    public class ControllerRepository : IControllerRepository
    {
        private readonly Controllers _controllers;

        public ControllerRepository()
        {
            _controllers = new Controllers();
        }

        public void Add(Model.Controller controller)
        {
            _controllers.Add(controller);
        }

        public List<long> GetImeiList()
        {
            return _controllers.GetImeiList();
        }

        public List<Model.Controller> GetControllers()
        {
            return _controllers.GetList();
        }

        public Controllers GetControllers(IEnumerable<long> imeiList)
        {
            return _controllers.GetControllers(imeiList);
        }

        public Controllers GetControllersByTimeTableId(int timeTableId)
        {
            return _controllers.GetControllersByTimeTableId(timeTableId);
        }

        public Model.Controller Find(long imei)
        {
            return _controllers.Find(imei);
        }

        public Model.Controller FindController(int phaseId)
        {
            return (from controller in _controllers.GetList() from phase in controller.Phases where phase.Id == phaseId select controller).FirstOrDefault();
        }

        public List<Phase> GetAllPhases()
        {
            var phases = new List<Phase>();

            foreach (var controller in _controllers.GetList())
                phases.AddRange(controller.Phases);

            return phases;
        }

        public Phase FindPhase(int phaseId)
        {
            return _controllers.GetList().SelectMany(controller => controller.Phases).FirstOrDefault(phase => phase.Id == phaseId);
        }
    }
}