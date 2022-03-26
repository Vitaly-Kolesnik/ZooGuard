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
        private readonly IUnitOfWork unitOfWork;
        public PositionService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task <bool> AddAsync(Position position)
        {
            await unitOfWork.PositionRepository.AddAsync(position);

            await unitOfWork.SaveAsync();

            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            await unitOfWork.PositionRepository.DeleteAsync(new Position { Id = id });

            await unitOfWork.SaveAsync();

            return true;
        }
        public async Task<Position> GetAsync(int id)
        {
            return await unitOfWork.PositionRepository.GetAsync(new GetPositionSpecification(id));
        }
        public async Task<IList<Position>> ListAsync(string name)
        {
            return await unitOfWork.PositionRepository.ListAsync(new PositionSpecification(name));
        }
        public async Task<IList<Position>> GetAllAsync()
        {
            return await unitOfWork.PositionRepository.ListAsync(new AllPositionInformationSpecification()); //Возвращает коллекцию позиций
        }
        public async Task<bool> UpdateAsync(Position position)
        {
            await unitOfWork.PositionRepository.UpdateAsync(position);

            await unitOfWork.SaveAsync();

            return true;
        }
        public async Task<IList<Position>> GetPosAtInformTabAsync(int id, InformTab inform)
        {
            IList<Position> result = null;

            switch (inform)
            {
                case InformTab.Vender:
                    {
                        result = await unitOfWork.PositionRepository.ListAsync(new PositionAtVenderSpecification(id));
                        return result;
                    }
                case InformTab.User:
                    {
                        result = await unitOfWork.PositionRepository.ListAsync(new PositionAtUserSpecification(id));
                        return result;
                    }
                case InformTab.Storage:
                    {
                        result = await unitOfWork.PositionRepository.ListAsync(new PositionAtStorageSpecification(id));
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
