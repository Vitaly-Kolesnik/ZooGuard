using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class PositionService : IPositionService
    {
        private readonly IRepository<Position> positionRepository; //репозиторий позиций

        public PositionService(IRepository<Position> positionRepository)
        {
            this.positionRepository = positionRepository;
        }

        public int Add(Position position) //добавляет позицию в базу, возвращает id позиции
        {
            positionRepository.Add(position);
            return position.Id;
        }

        public void Delete(int id) //Удаление из базы данных
        {
            positionRepository.Delete(new Position { Id = id }); //схема удаления, Entity, передаю id, он сам найдет и будет ее трекать как удаленную при вызове базы
        }

        public Position Get(int id) //поиск по id
        {
            return positionRepository.Get(id); //Вызываем соответствующий метод из EfRepository
        }

        public List<Position> List(string name) //возврат коллекции по строке
        {
            return positionRepository.List(new PositionSpecification(name)).ToList(); //создание и передача объекта спецификации, филд - строка
        }
        public List<Position> GetAll()
        {
            return positionRepository.List().ToList(); //Возвращает коллекцию позиций
        }

        public int Update(Position position)
        {
            positionRepository.Update(position);
            return position.Id;
        }
    }
}
