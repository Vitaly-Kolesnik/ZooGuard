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
            await unitOfWork.VenderRepository.AddAsync(vender);

            await unitOfWork.SaveAsync();

            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            await unitOfWork.VenderRepository.DeleteAsync(new Vender { Id = id });

            await unitOfWork.SaveAsync();

            return true;
        }
        public async Task <Vender> GetAsync(int id)
        {
            return await unitOfWork.VenderRepository.GetAsync(id);
        }
        public async Task<IList<Vender>> GetAllAsync()
        {
            return await unitOfWork.VenderRepository.ListAsync();
        }
        public async Task<IList<Vender>> ListAsync(string name)
        {
            return await unitOfWork.VenderRepository.ListAsync(new VenderSpecification(name));
        }
        public async Task<bool> UpdateAsync(Vender vender)
        {
            await unitOfWork.VenderRepository.UpdateAsync(vender);

            await unitOfWork.SaveAsync();

            return true;
        }
    }
}
