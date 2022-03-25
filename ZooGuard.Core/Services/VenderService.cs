using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class VenderService : IVenderService
    {
        private readonly IRepository<Vender> repositoryVender;

        public VenderService (IRepository<Vender> repository)
        {
            this.repositoryVender = repository;
        }
        
        public async Task<bool> AddAsync(Vender vender)
        {
            return await repositoryVender.AddAsync(vender);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await repositoryVender.DeleteAsync(new Vender { Id = id });
        }

        public async Task <Vender> GetAsync(int id)
        {
            return await repositoryVender.GetAsync(id);
        }

        public async Task<IList<Vender>> GetAllAsync()
        {
            return await repositoryVender.ListAsync();
        }

        public async Task<IList<Vender>> ListAsync(string name)
        {
            return await repositoryVender.ListAsync(new VenderSpecification(name));
        }

        public async Task<bool> UpdateAsync(Vender vender)
        {
            return await repositoryVender.UpdateAsync(vender);
        }
    }
}
