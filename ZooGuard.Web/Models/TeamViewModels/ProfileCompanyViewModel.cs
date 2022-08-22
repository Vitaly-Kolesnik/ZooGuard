using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZooGuard.Web.Models.TeamViewModels;

namespace ZooGuard.Web.Models
{
    public class ProfileCompanyViewModel : AddCompanyViewModel
    {
        [Display(Name = "Worker")]
        public int[] WorkerIds { get; set; }
        public IEnumerable<SelectListItem> Workers { get; set; }

        [Display(Name = "Projects")]
        public int[] ProjectIds { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }

        [Display(Name = "Positions")]
        public int[] PositionIds { get; set; }
        public IEnumerable<SelectListItem> Positions { get; set; }

        [Display(Name = "Places")]
        public int[] PlaceIds { get; set; }
        public IEnumerable<SelectListItem> Places { get; set; }

        [Display(Name = "Storagies")]
        public int[] StorageIds { get; set; }
        public IEnumerable<SelectListItem> Storagies { get; set; }

        [Display(Name = "Server Rooms")]
        public int[] ServerRoomIds { get; set; }
        public IEnumerable<SelectListItem> ServerRooms { get; set; } 
    }
}
