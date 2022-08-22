using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.WorkerViewModels
{
    public class ProfileWorkerViewModel : AddWorkerViewModel
    {
        [Display(Name = "Storage")]
        public int[] StorageIds { get; set; }
        public IEnumerable<SelectListItem> Storagies { get; set; }

        [Display(Name = "Projects")]
        public int[] ProjectIds { get; set; }
        public IEnumerable<SelectListItem> Projects { get; set; }

        [Display(Name = "Server Rooms")]
        public int[] ServerRoomsIds { get; set; }
        public IEnumerable<SelectListItem> ServerRooms { get; set; }

        [Display(Name = "Company")]
        public int[] CompanyIds { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
    }
}
