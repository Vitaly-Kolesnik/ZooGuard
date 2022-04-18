using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.StorageEntities
{
    public class Storage : BaseStorageEntities
    {
        #region Many-To-One (Storages - Worker)
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        #endregion
    }
}
