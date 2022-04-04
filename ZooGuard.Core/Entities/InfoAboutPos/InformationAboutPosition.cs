using System.Collections.Generic;

namespace ZooGuard.Core.Entities.InfoAboutPos
{
    public abstract class InformationAboutPosition
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region One-to-Many (StatusLabel(FormOfOccurence) - Positions)
        public ICollection<Position> Positions { get; set; }
        #endregion
    }
}
