using System.Collections.Generic;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Core.Entities
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region One-To-Many (Organisation - Positions)
        public ICollection<Position> Positions { get; set; }
        #endregion

        #region One-To-Many (Organisation - Projects)
        public ICollection<Project> Projects { get; set; }
        #endregion

        #region One-To-Many (Organisation - Places)
        public ICollection<Place> Places { get; set; }
        #endregion

        #region Many-To-Many (Organisations - Workers)
        public ICollection<WorkersInOrganisation> WorkersInOrganisations { get; set; }
        #endregion

        #region One-To-Many (Organisation - Storages)
        public ICollection<Storage> Storages { get; set; }
        #endregion

        #region One-To-Many (Organisation - ServerRooms)
        public ICollection<ServerRoom> ServerRooms { get; set; }
        #endregion
    }
}
