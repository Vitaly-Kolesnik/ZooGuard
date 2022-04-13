using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Entities.PositionEntities;

namespace ZooGuard.Core.Specifications
{
    public class AllPositionInformationSpecification : ISpecification<Position>
    {
        public IList<string> Includes => new List<string> //Мы создаем коллекцию адресов.                                 
        {
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.Storage)}",
        };

        public IQueryable<Position> Apply(IQueryable<Position> query)
        {
            return query;
        }
    }
}
