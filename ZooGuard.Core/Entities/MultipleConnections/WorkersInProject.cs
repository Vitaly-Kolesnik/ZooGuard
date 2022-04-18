using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.MultipleConnections
{
    public class WorkersInProject
    {
        public int? WorkerId { get; set; }
        public Worker Worker { get; set; }

        public int? ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
