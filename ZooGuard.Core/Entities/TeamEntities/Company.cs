using System.Collections.Generic;
using ZooGuard.Core.Entities.MultipleConnections;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.StorageEntities;

namespace ZooGuard.Core.Entities.TeamEntities
{
    public class Company 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region One-To-Many (Company - Positions)
        public ICollection<Position> Positions { get; set; }
        #endregion

        #region One-To-Many (Organisation - Places)
        public ICollection<Place> Places { get; set; }
        #endregion

        #region One-To-Many (Organisation - Projects)
        public ICollection<Project> Projects { get; set; }
        #endregion

        #region One-To-Many (Organisation - Storagies)
        public ICollection<Storage> Storages { get; set; }
        #endregion

        #region One-To-Many (Organisation - ServerRooms)
        public ICollection<ServerRoom> ServerRooms { get; set; }
        #endregion

        #region Many-to-Many (Organisation-Worker)
        public ICollection<WorkersInCompany> WorkersInCompanies { get; set; }
        #endregion
    }
}
