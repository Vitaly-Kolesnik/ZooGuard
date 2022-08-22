using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.TeamViewModels
{
    public class AddCompanyViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Display(Name = "Ogr form")]
        [Required, MaxLength(5)]
        public string OrgForm { get; set; }

        [Display(Name = "Name Company")]
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "UNP")]
        [Required]
        public int UNP { get; set; }

        [Display(Name = "Adress")]
        [Required, MaxLength(512)]
        public string Adress { get; set; }

        [Display(Name = "Characteristic")]
        [Required, MaxLength(512)]
        public string Characteristic { get; set; }
    }
}
