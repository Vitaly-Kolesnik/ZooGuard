using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Web.Models.StoragiesViewModel.PlaceViewModels;

namespace ZooGuard.Web.MapProfile
{
    public class AppMappingProfile : Profile
    {
        public ICompanyService CompanyService { get; set; }

        public AppMappingProfile()
        {
            
        }
    }
}
