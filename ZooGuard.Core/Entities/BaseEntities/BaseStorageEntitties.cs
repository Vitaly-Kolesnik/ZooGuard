
namespace ZooGuard.Core.Entities.BaseEntities
{
    public abstract class BaseStorageEntitties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActualAddress { get; set; }
        public string Characteristic { get; set; }

        #region Many-To-One (Storages - Worker)
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        #endregion

        #region Many-To-One (Storages - Organisation)
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
        #endregion
    }
}
