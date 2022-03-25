using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Enum;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class PositionService : IPositionService
    {
        private readonly IRepository<Position> positionRepository;

        public PositionService(IRepository<Position> positionRepository)
        {
            this.positionRepository = positionRepository;
        }

        public async Task <bool> AddAsync(Position position)
        {
            return await positionRepository.AddAsync(position);
        }

        public async Task<bool> DeleteAsync(int id)
        {
           return await positionRepository.DeleteAsync(new Position { Id = id });
        }

        public async Task<Position> GetAsync(int id)
        {
            return await positionRepository.GetAsync(new GetPositionSpecification(id));
        }

        public async Task<IList<Position>> ListAsync(string name)
        {
            return await positionRepository.ListAsync(new PositionSpecification(name));
        }
        public async Task<IList<Position>> GetAllAsync()
        {
            return await positionRepository.ListAsync(new AllPositionInformationSpecification()); //Возвращает коллекцию позиций
        }
        public async Task<bool> UpdateAsync(Position position)
        {
            return await positionRepository.UpdateAsync(position);
        }
        public async Task<IList<Position>> GetPosAtInformTabAsync(int id, InformTab inform)
        {
            IList<Position> result = null;

            switch (inform)
            {
                case InformTab.Vender:
                    {
                        result = await positionRepository.ListAsync(new PositionAtVenderSpecification(id));
                        return result;
                    }
                case InformTab.User:
                    {
                        result = await positionRepository.ListAsync(new PositionAtUserSpecification(id));
                        return result;
                    }
                case InformTab.Storage:
                    {
                        result = await positionRepository.ListAsync(new PositionAtStorageSpecification(id));
                        return result;
                    }
                default:
                    {
                        return result;
                    }
            }
        }
    }
}
