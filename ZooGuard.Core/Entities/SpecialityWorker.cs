using System.Collections.Generic;
using ZooGuard.Core.Entities.MultipleConnections;

namespace ZooGuard.Core.Entities
{
    public class SpecialityWorker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Many-to-Many (SpecialityWorker - Worker)
        public ICollection<SpecialitiesOfWorkers> SpecialitiesOfWorkers { get; set; }
        #endregion
    }
}
