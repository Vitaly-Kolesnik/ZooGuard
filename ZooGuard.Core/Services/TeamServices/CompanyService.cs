using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Core.Specifications.TeamSpecifications;

namespace ZooGuard.Core.Services.TeamServices
{
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork unitOfWork;
        public CompanyService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAsync(Company company)
        {
            using (unitOfWork)
            {
                await unitOfWork.CompanyRepository.AddAsync(company);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.CompanyRepository.UpdateAsync(new Company { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(Company company)
        {
            using (unitOfWork)
            {
                await unitOfWork.CompanyRepository.UpdateAsync(company);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<IList<Company>> GetAllAsync()
        {
            using (unitOfWork)
            {
                return await unitOfWork.CompanyRepository.ListAsync(new AllCompanySpecification());
            }
        }
        public Task<Company> GetAsync(int id)
        {
            using (unitOfWork)
            {
                return unitOfWork.CompanyRepository.GetAsync(id);
            }
        }
    }
}
