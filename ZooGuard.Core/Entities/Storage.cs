using System.Collections.Generic;

namespace ZooGuard.Core.Entities
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActualAddress { get; set; }
        public ICollection<Position> Positions { get; set; }
    }
}
