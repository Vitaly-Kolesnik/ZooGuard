using System;
using System.Collections.Generic;
using ZooGuard.Core.Entites.InfoAboutPos;

namespace ZooGuard.Core.Entites
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

        //One-to-Many Relationship (Position-OwnerPosition)
        //One-to-Many Relationship (Position-FromOfOccurence)
        //One-to-Many Relationship (Position - StatusLabel)
        public int IdInformationAboutPosition { get; set; }
        public OwnerPosition OwnerPosition { get; set; } //Поставщик
        public FormOfOccurence FormOfOccurence { get; set; } //форма собственности
        public StatusLabelPos StatusLabel { get; set; } //статус
        public Storage Storage { get; set; } //место хранения

        //One-to-Many Relationship (Positions - User)
        public int IdUser { get; set; }
        public User User { get; set; }

        //One-to-Many Relationship (Position - Positions)
        public ICollection<Position> Positions { get; set; } //array old position, notReality (after upgrade or modernization) (учетки товаров до изменения, с недействительными флагами действительности)
    }
}
