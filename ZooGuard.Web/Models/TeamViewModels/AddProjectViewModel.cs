using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.TeamViewModels
{
    public class AddProjectViewModel
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

        [Display(Name = "PM")]
        public int PMIds { get; set; }
        public IEnumerable<SelectListItem> PMs { get; set; }
    }
}
