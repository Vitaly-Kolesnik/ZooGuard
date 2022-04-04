using System.Collections.Generic;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region One-to-Many (Organisation - Projects)
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
        #endregion

        #region Many-to-Many (Project-Worker)
        public ICollection<WorkersInProject> WorkersInProjects { get; set; }
        #endregion
    }
}
