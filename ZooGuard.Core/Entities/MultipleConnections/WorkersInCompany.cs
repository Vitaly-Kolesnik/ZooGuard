using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.MultipleConnections
{
    public class WorkersInCompany
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
