
using System.Collections.Generic;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.BaseEntities
{
    public abstract class BaseStorageEntities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActualAddress { get; set; }
        public string Characteristic { get; set; }

        #region Many-To-One (Storages - Company)
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        #endregion

        #region One-to-Many (Storages - Positions )
        public ICollection<Position> Positions { get; set; }
        #endregion
    }
}
