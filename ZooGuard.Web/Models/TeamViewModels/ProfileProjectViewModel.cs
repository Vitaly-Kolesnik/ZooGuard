using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZooGuard.Web.Models.TeamViewModels;

namespace ZooGuard.Web.Models
{
    public class ProfileProjectViewModel : AddProjectViewModel
    {
        [Display(Name = "Positions")]
        public int PositionIds { get; set; }
        public IEnumerable<SelectListItem> Positions { get; set; }

        [Display(Name = "Places")]
        public int PlaceIds { get; set; }
        public IEnumerable<SelectListItem> Places { get; set; }

        [Display(Name = "Workers")]
        public int WorkerIds { get; set; }
        public IEnumerable<SelectListItem> Workers { get; set; }
    }
}
