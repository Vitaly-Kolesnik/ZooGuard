using System.Collections.Generic;
using System.Linq;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Specifications
{
    internal class FindPositionSpecification : Specifications<Position>
    {
        private string name;

        public IList<string> Includes => new List<string> //Мы создаем коллекцию адресов.   //Выражение nameof создает имя, тип или элемент переменной в качестве строковой константы                                 
        {                                                                                                       
          $"{nameof(Position.FormOfOccurence)}",
          $"{nameof(Position.Vender)}",
          $"{nameof(Position.StatusLabel)}",
          $"{nameof(Position.Storage)}",
        };
        public FindPositionSpecification(string name)
        {
            this.name = name;
        }
        public IQueryable<Position> Apply(IQueryable<Position> source) //получает перечисление реализующие интерфейс IQueryable, soure
        {
            return source.Where(p => p.Name.ToLower().IndexOf(name.ToLower()) != -1); //Where, фильтрует по свойствам Name (пониженный регистр), IndexOf - метод класса string, возвращает или значение, если параметр найден или -1, если пустой - вернет 0.
            //на выходе мы получим IQueryable<Position>, отвечающий условию наличия в имени переданного строкового параметра.
        }
    }
}
