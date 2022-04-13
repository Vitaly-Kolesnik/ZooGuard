using System.Collections.Generic;

namespace ZooGuard.Core.Entities.PositionEntities
{
    public class PositionCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Many-To-One (Positions - PositionCategory)
        public ICollection<Position> Positions { get; set; }
        #endregion
    }
}
