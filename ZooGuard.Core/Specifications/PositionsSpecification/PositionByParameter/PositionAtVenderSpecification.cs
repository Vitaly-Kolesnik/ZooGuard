using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class PositionAtVenderSpecification : ISpecification<Position>
    {
        private readonly int id;

        public PositionAtVenderSpecification(int id)
        {
            this.id = id;
        }
        public IList<string> Includes => new List<string>
        {
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.Storage)}",
        };

        public IQueryable<Position> Apply(IQueryable<Position> query)
        {
            return query.Where(x => x.VenderId == id);
        }
    }
}
