

namespace ZooGuard.Core.Entities.MultipleConnections
{
    public class WorkersInOrganisation
    {
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }

        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
    }
}
