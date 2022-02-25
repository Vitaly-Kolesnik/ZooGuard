using System.Collections.Generic;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Enum;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class PositionService : IPositionService
    {
        private readonly IRepository<Position> positionRepository; //поля для возврата репозитория позиций

        public PositionService(IRepository<Position> positionRepository)
        {
            this.positionRepository = positionRepository; //передача репозитория позиций (условного)
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
            return positionRepository.Get(new GetPositionSpecification(id)); //Вызываем соответствующий метод из EfRepository
        }

        public IList<Position> List(string name) //возврат коллекции по строке
        {
            return positionRepository.List(new PositionSpecification(name)); //создание и передача объекта спецификации, филд - строка
        }
        public IList<Position> GetAll()
        {
            return positionRepository.List(new AllPositionInformationSpecification()); //Возвращает коллекцию позиций
        }

        public int Update(Position position)
        {
            positionRepository.Update(position);
            return position.Id;
        }

        public IList<Position> GetPosAtStorage (int id) 
        {
            return positionRepository.List(new PositionAtStorageSpecification(id));
        }

        public IList<Position> GetPosAtVender(int id)
        {
            return positionRepository.List(new PositionAtVenderSpecification(id));
        }

        public IList<Position> GetPosAtUser(int id, InformTab inform)
        {
            IList<Position> result;

            switch (inform)
            {
                case InformTab.Vender:
                    {
                        result = positionRepository.List(new PositionAtVenderSpecification(id));
                        break;
                    }
                case InformTab.User:
                    {
                        result = positionRepository.List(new PositionAtUserSpecification(id));
                        break;
                    }
                case InformTab.Storage:
                    {
                        result = positionRepository.List(new PositionAtStorageSpecification(id));
                        break;
                    }
                default:
                    {
                        result= new List<Position>();
                        break;
                    }
            }
            return result;
        }
    }
}
