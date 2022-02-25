using System;
using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Specifications
{
    public class AllPositionInformationSpecification : Specifications<Position>
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
