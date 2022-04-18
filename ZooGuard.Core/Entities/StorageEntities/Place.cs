using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.StorageEntities
{
    public class Place : BaseStorageEntities
    {
        #region One-to-One (Place - Worker)
        public Worker Worker { get; set; }
        public int WorkerForeignKey { get; set; }
        #endregion
    }
}
