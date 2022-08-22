using AutoMapper;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Web.Interfaces.InterfacesForStorageViewModelServices;
using ZooGuard.Web.Models.StoragiesViewModel.PlaceViewModels;

namespace ZooGuard.Web.Services.StoragiesViewModelServicies
{
    public class PlaceViewModelService : IPlaceViewModelService
    {
        private readonly IMapper mapper;

        public PlaceViewModelService(IMapper mapper)
        {
            this.mapper  = mapper;
        }

        public AddPlaceWithCompanyViewModelEmpty GetEmpty()
        {
           return  mapper.Map<AddPlaceWithCompanyViewModelEmpty>(new Place());
        }
    }
}
