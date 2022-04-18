using System;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.VenderEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Entities.PositionEntities
{
    public class Position
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public DateTime Date { get; set; }
        public string RegistrationDocument { get; set; }
        public string AccountingNumber { get; set; }
        public string Information { get; set; }

        #region Many-to-One (Position - PositionCategory)
        public int PositionCategoryId { get; set; }
        public PositionCategory PositionCategory { get; set; }
        #endregion

        #region Many-to-One (Position - Vender)
        public int VenderId { get; set; }
        public Vender Vender { get; set; }
        #endregion

        #region Many-to-One (Position - Storage)
        public int? StorageId { get; set; }
        public Storage Storage { get; set; }
        #endregion

        #region Many-to-One (Position - Broken)
        public int? BrokenId { get; set; }
        public Broken Broken { get; set; }
        #endregion

        #region Many-to-One (Position - FormOfOccurence)
        public int FormOfOccurenceId { get; set; }
        public FormOfOccurence FormOfOccurence { get; set; }
        #endregion

        #region Many-to-one (Positions - Company)
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        #endregion

        #region Many-to-One (Positions - Worker)
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        #endregion

        #region Many-to-One (Position - ServerRoom)
        public int? ServerRoomId { get; set; }
        public ServerRoom ServerRoom { get; set; }
        #endregion
    }
}
