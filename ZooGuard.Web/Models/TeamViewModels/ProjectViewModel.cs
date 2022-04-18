using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class ProjectViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Display(Name = "Project")]
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Company")]
        [Required]
        public int CompanyId { get; set; }
        public IEnumerable<SelectListItem> Companies { get; set; }

        [Display(Name = "Positions")]
        public int PositionIds { get; set; }
        public IEnumerable<SelectListItem> Positions { get; set; }

        [Display(Name = "Places")]
        public int PlaceIds { get; set; }
        public IEnumerable<SelectListItem> Places { get; set; }
    }
}
