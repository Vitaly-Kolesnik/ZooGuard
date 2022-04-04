using System;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Core.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string RegistrationDocument { get; set; }
        public string AccountingNumber { get; set; }
        public string Information { get; set; }

        #region Many-to-One (Position - Vender)
        public int VenderId { get; set; }
        public Vender Vender { get; set; }
        #endregion

        #region Many-to-One (Position - Storage)
        public int? StorageId { get; set; }
        public Storage Storage { get; set; }
        #endregion

        #region Many-to-One (Position - FormOfOccurence)
        public int? FormOfOccurenceId { get; set; }
        public FormOfOccurence FormOfOccurence { get; set; }
        #endregion

        #region Many-to-One (Position - StatusLebel)
        public int? StatusLabelId { get; set; }
        public StatusLabel StatusLabel { get; set; }
        #endregion

        #region Many-to-one (Positions - Organisation)
        public int OrganisationId { get; set; }
        public Organisation Organisation { get; set; }
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
