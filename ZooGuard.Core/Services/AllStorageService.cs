using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class AllStorageService<T> : IAllStorageService<T>
        where T : BaseStorageEntities, new()
    {
        private readonly IUnitOfWork unitOfWork;

        public AllStorageService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(T t)
        {
            using (unitOfWork)
            {
                await unitOfWork.GetRepository<T>().AddAsync(t);

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.GetRepository<T>().DeleteAsync(new T { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<bool> UpdateAsync(T t)
        {
            using(unitOfWork)
            {
                await unitOfWork.GetRepository<T>().UpdateAsync(t);

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<T> GetAsync(int id)
        {
            using(unitOfWork)
            {
                T entity = await unitOfWork.GetRepository<T>().GetAsync(id);

                return entity;
            }
        }

        public async Task<IList<T>> GetAllAsync()
        {
            var list = await unitOfWork.GetRepository<T>().ListAsync();

            return list;
        }

        public async Task<IList<T>> ListAsync(string name)
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.GetRepository<T>().ListAsync(new PositionInformationSpecification<T>(name));

                return list;
            }
        }
        
    }
}
