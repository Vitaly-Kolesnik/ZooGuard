using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.MultipleConnections
{
    public class SpecialitiesOfWorkers
    {
        public int SpecialityWorkerId { get; set; }
        public SpecialityWorker SpecialityWorker { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
    }
}
