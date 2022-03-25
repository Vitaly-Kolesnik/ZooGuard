using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class OccurenceViewModelService : IOccurenceViewModelService
    {
        private readonly IPositionInformationService<FormOfOccurence> positionInformationService;

        public OccurenceViewModelService(IPositionInformationService<FormOfOccurence> positionInformationService)
        {
            this.positionInformationService = positionInformationService;
        }

        public async Task<bool> AddAsync(OccurenceViewModel occurenceViewModel)
        {
            return await positionInformationService.AddAsync(ConvertToModel(occurenceViewModel));
        }

        public async Task<OccurenceViewModel> GetByIdAsync(int id)
        {
            var occurence = await positionInformationService.GetAsync(id);
            return occurence != null ? ConvertToViewModel(occurence) : null;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return await positionInformationService.DeleteAsync(id);
        }

        private FormOfOccurence ConvertToModel(OccurenceViewModel occurenceViewModel)
        {
            return new FormOfOccurence
            {
                Id = occurenceViewModel.Id.HasValue ? occurenceViewModel.Id.Value : 0,
                Name = occurenceViewModel.Name,
            };
        }

        private OccurenceViewModel ConvertToViewModel(FormOfOccurence formOfOccurence)
        {
            return new OccurenceViewModel
            {
                Id = formOfOccurence.Id,
                Name = formOfOccurence.Name,
            };
        }
    }
}
