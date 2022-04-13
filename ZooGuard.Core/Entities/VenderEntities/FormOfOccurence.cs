using System.Collections.Generic;
using ZooGuard.Core.Entities.PositionEntities;

namespace ZooGuard.Core.Entities.VenderEntities
{
    public class FormOfOccurence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}
