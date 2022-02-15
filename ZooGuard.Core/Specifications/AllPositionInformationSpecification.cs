using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class AllPositionInformationSpecification : ISpecification<Position>
    {
        public IList<string> Includes => new List<string> //Мы создаем коллекцию адресов.   //Выражение nameof создает имя, тип или элемент переменной в качестве строковой константы                                 
        {
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.StatusLabel)}",
          $"{nameof(Position.Storage)}",
          $"{nameof(Position.User)}",
        };

        public IQueryable<Position> Apply(IQueryable<Position> query)
        {
            return query;
        }
    }
}
