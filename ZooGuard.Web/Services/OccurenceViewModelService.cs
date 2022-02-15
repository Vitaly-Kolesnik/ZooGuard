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

        public int Add(OccurenceViewModel occurenceViewModel)
        {
            return positionInformationService.Add(ConvertToModel(occurenceViewModel));
        }

        public void Edit(OccurenceViewModel occurence)
        {
            throw new System.NotImplementedException();
        }

        public OccurenceViewModel GetById(int id)
        {
            var occurence = positionInformationService.Get(id);
            return occurence != null ? ConvertToViewModel(occurence) : null;
        }

        public OccurenceViewModel GetEmpty()
        {
            throw new System.NotImplementedException();
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
