using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.StoragiesViewModel.PlaceViewModels
{
    public class AddPlaceWithCompanyViewModelEmpty
    {
        [HiddenInput]
        public int? Id { get; set; } = null;

        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; } = null;

        [Display(Name = "Adress in office")]
        [Required]
        public string ActualAddress { get; set; } = null;

        [Display(Name = "Characteristic")]
        [Required]
        public string Characteristic { get; set; } = null;

        [Required]
        public int CompanyId { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }
    }
}
