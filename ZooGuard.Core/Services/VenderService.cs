using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class VenderService : IVenderService
    {
        private readonly IUnitOfWork unitOfWork;
        public VenderService (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        
        public async Task<bool> AddAsync(Vender vender)
        {
            using(unitOfWork)
            {
                await unitOfWork.VenderRepository.AddAsync(vender);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.VenderRepository.DeleteAsync(new Vender { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(Vender vender)
        {
            using (unitOfWork)
            {
                await unitOfWork.VenderRepository.UpdateAsync(vender);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task <Vender> GetAsync(int id)
        {
            using (unitOfWork)
            {
                var entity = await unitOfWork.VenderRepository.GetAsync(id);

                return entity;
            }
        }
        public async Task<IList<Vender>> GetAllAsync()
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.VenderRepository.ListAsync();

                return list;
            }
        }
        public async Task<IList<Vender>> ListAsync(string name)
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.VenderRepository.ListAsync(new VenderSpecification(name));

                return list;
            }
        }
    }
}
