using System;
using System.Collections.Generic;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Core.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string RegistrationDocument { get; set; }
        public string AccountingNumber { get; set; } //инвертарный номер
        public string Information { get; set; }
        //One-to-Many Relationship (Position-Vender)
        //One-to-Many Relationship (Position-FromOfOccurence)
        //One-to-Many Relationship (Position - StatusLabel)
        //One-to-Many Relationship (Position - Storage)
        public int VenderId { get; set; }
        public Vender Vender { get; set; } //Поставщик
        public int StorageId { get; set; }
        public Storage Storage { get; set; } //место хранения
        public int FormOfOccurenceId { get; set; }
        public FormOfOccurence FormOfOccurence { get; set; } //форма собственности
        public int StatusLabelId { get; set; }
        public StatusLabel StatusLabel { get; set; } //статус
        //One-to-Many Relationship (Positions - User)
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
