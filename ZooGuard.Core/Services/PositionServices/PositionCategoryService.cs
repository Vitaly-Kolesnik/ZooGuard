using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.ForPosition;

namespace ZooGuard.Core.Services.PositionServices
{
    public class PositionCategoryService : IPositionCategoryService
    {
        private readonly IUnitOfWork unitOfWork;

        public PositionCategoryService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(PositionCategory positionCategory)
        {
           using(unitOfWork)
            {
               await unitOfWork.PositionCategoryRepository.AddAsync(positionCategory);

               await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using(unitOfWork)
            {
                await unitOfWork.PositionCategoryRepository.DeleteAsync(new PositionCategory { Id=id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<bool> UpdateAsync(PositionCategory positionCategory)
        {
            using(unitOfWork)
            {
                await unitOfWork.PositionCategoryRepository.UpdateAsync(positionCategory);

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<IList<PositionCategory>> GetAllAsync()
        {
            using(unitOfWork)
            {
                var list = await unitOfWork.PositionCategoryRepository.ListAsync();

                return list;
            }
        }

        public async Task<PositionCategory> GetAsync(int id)
        {
            using(unitOfWork)
            {
                return await unitOfWork.PositionCategoryRepository.GetAsync(id);
            }
        }
    }
}
