using System;
using System.Collections.Generic;
using ZooGuard.Core.Entities.PositionEntities;

namespace ZooGuard.Core.Entities
{
    public class Broken
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActualAddress { get; set; }
        public string Characteristic { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

        #region One-to-Many (Broken - Positions )
        public ICollection<Position> Positions { get; set; }
        #endregion
    }
}
