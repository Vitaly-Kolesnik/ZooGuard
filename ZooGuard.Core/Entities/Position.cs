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
        public int AccountingNumber { get; set; } //инвертарный номер
        public bool RealityFlag { get; set; } //фланг действительности
        public string Information { get; set; }
        //One-to-Many Relationship (Position-Vender)
        //One-to-Many Relationship (Position-FromOfOccurence)
        //One-to-Many Relationship (Position - StatusLabel)
        //One-to-Many Relationship (Position - Storage)
        public int IdVender { get; set; }
        public Vender Vender { get; set; } //Поставщик
        public int IdStorage { get; set; }
        public Storage Storage { get; set; } //место хранения
        public int IdInformationAboutPosition { get; set; }
        public FormOfOccurence FormOfOccurence { get; set; } //форма собственности
        public StatusLabelPos StatusLabel { get; set; } //статус
        //One-to-Many Relationship (Positions - User)
        public int IdUser { get; set; }
        public User User { get; set; }
        //One-to-Many Relationship (Position - Positions)
        public ICollection<Position> Positions { get; set; } //array old position, notReality (after upgrade or modernization) (учетки товаров до изменения, с недействительными флагами действительности)
    }
}
