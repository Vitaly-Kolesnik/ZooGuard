using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.StorageEntities
{
    public class ServerRoom : BaseStorageEntities
    {
        #region Many-To-One (ServerRoom - Worker)
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        #endregion
    }
}
