using System.Collections.Generic;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.StorageEntities;

namespace ZooGuard.Core.Entities.TeamEntities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PMId { get; set; }

        #region One-To-Many (Company - Positions)
        public ICollection<Position> Positions { get; set; }
        #endregion

        #region One-To-Many (Company - Places)
        public ICollection<Place> Places { get; set; }
        #endregion

        #region One-to-Many (Company - Projects)
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        #endregion

        #region Many-to-Many (Project-Worker)
        public ICollection<WorkersInProject> WorkersInProjects { get; set; }
        #endregion

    }
}
