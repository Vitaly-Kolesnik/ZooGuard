using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.WorkerViewModels
{
    public class AddWorkerSpecialityViewModel
    {
        [HiddenInput]
        public int WorkerSpecialityId { get; set; }

        [Display(Name = "Name")]
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required, MaxLength(1000)]
        public string Description { get; set; }
    }
}
