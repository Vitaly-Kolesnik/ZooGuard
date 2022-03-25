using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class GetPositionSpecification : Specifications<Position>
    {
        private readonly int id;

        public GetPositionSpecification(int id)
        {
            this.id = id;
        }

        public IList<string> Includes => new List<string>                               
        {
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.StatusLabel)}",
          $"{nameof(Position.Storage)}",
        };

        public IQueryable<Position> Apply(IQueryable<Position> query)
        {
           return query.Where(x => x.Id == id);
        }
    }
}
