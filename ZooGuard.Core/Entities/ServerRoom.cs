using System.Collections.Generic;
using ZooGuard.Core.Entities.BaseEntities;

namespace ZooGuard.Core.Entities
{
    public class ServerRoom : BaseStorageEntitties
    {
        #region One-to-Many (ServerRoom - Positions )
        public ICollection<Position> Positions { get; set; }
        #endregion
    }
}
