using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Specifications
{
    public class AllPositionInformationSpecification : Specifications<Position>
    {
        public IList<string> Includes => new List<string> //Мы создаем коллекцию адресов.                                 
        {
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.StatusLabel)}",
          $"{nameof(Position.Storage)}",
        };

        public IQueryable<Position> Apply(IQueryable<Position> query)
        {
            return query;
        }
    }
}
