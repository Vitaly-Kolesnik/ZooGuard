using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.WorkerViewModels
{
    public class ProfileWorkerSpecialityViewModel : AddWorkerSpecialityViewModel
    {
        [Display(Name = "Storagies")]
        public int[] WorkersIds { get; set; }
        public IEnumerable<SelectListItem> Workers { get; set; }
    }
}
