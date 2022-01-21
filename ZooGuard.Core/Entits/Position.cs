using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Entits
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string RegistrationDocument { get; set; }
        public int AccountingNumber { get; set; }
        public bool RealityFlag { get; set; }
        public string Information { get; set; }

        //One-to-One Relationship (Position-OwnerPosition)
        public int IdOwnerPosition { get; set; }
        public string NameOwnerPosition { get; set; }

        //One-to-One Relationship (Position-FromOfOccurence)
        public int IdFormOfOccurence { get; set; }
        public string NameFormOfOccurence { get; set; }

        //One-to-Many Relationship (User - Positions)
        public int IdUser { get; set; }
        public string NameUser { get; set; }

        //One-to-One Relationship (Position - StatusLabel)
        public int IdStatusLabel { get; set; }
        public int NameStatusLabel { get; set; }

        //One-to-Many Relationship (Position - Positions)
        public ICollection<Position> Positions { get; set; }
    }
}
