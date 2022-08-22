using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.StoragiesViewModel
{
    public class AddPlaceViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display (Name = "Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Adress in office")]
        [Required]
        public string ActualAddress { get; set; }

        [Display (Name = "Characteristic")]
        [Required]
        public string Characteristic { get; set; }

        [Required]
        public int CompanyIds { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
    }
}
