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
        public int VenderId { get; set; }
        public Vender Vender { get; set; }
        public int StorageId { get; set; }
        public Storage Storage { get; set; }
        public int? FormOfOccurenceId { get; set; }
        public FormOfOccurence FormOfOccurence { get; set; }
        public int? StatusLabelId { get; set; }
        public StatusLabel StatusLabel { get; set; }
    }
}
