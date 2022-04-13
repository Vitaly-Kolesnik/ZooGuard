using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Enum;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.ForPosition;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services.PositionServices
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
            using (unitOfWork)
            {
                await unitOfWork.PositionRepository.AddAsync(position);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.PositionRepository.DeleteAsync(new Position { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(Position position)
        {
            await unitOfWork.PositionRepository.UpdateAsync(position);

            await unitOfWork.SaveAsync();

            return true;
        }
        public async Task<Position> GetAsync(int id)
        {
            using (unitOfWork)
            {
                var entity = await unitOfWork.PositionRepository.GetAsync(new GetPositionSpecification(id));

                return entity;
            }
            
        }
        public async Task<IList<Position>> ListAsync(string name)
        {
            using(unitOfWork)
            {
                var result = await unitOfWork.PositionRepository.ListAsync(new PositionSpecification(name));

                return result;
            }
        }
        public async Task<IList<Position>> GetAllAsync()
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.PositionRepository.ListAsync(new AllPositionInformationSpecification());

                return list;
            }
            
        }
        public async Task<IList<Position>> GetPosAtInformTabAsync(int id, InformTab inform)
        {
            using (unitOfWork)
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
}
