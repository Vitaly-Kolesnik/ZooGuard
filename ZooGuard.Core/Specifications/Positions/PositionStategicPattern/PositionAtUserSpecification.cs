using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class PositionAtUserSpecification : Specifications<Position>
    {
        private readonly int id;

        public PositionAtUserSpecification(int id)
        {
            this.id = id;
        }
        public IList<string> Includes => new List<string>
        {
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.StatusLabel)}",
          $"{nameof(Position.Storage)}",
          $"{nameof(Position.User)}",
        };
        public IQueryable<Position> Apply(IQueryable<Position> query)
        {
            return query.Where(x => x.UserId == id);
        }
    }
}
