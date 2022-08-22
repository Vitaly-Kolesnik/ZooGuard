using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.StoragiesViewModel
{
    public class ProfilePlaceViewModel : AddPlaceViewModel
    {
        public int[] PositionIds { get; set; }
        public IEnumerable<SelectListItem> Positions { get; set; }

        public int WorkerId { get; set; }
        public IEnumerable<SelectListItem> Workers { get; set; }
    }
}
