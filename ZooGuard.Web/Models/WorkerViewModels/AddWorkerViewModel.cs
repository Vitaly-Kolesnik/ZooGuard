using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models.WorkerViewModels
{
    public class AddWorkerViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Display(Name = "Patronymic")]
        [Required, MaxLength(100)]
        public string Patronymic { get; set; }

        [Display(Name = "Responsibility Storage")]
        [Required]
        public bool IsResponsibilityStorage { get; set; }

        [Required]
        public bool IsResponsibilityServerRoom { get; set; }

        [Display(Name = "Worker")]
        [Required]
        public int[] SpecialitiesOfWorkersIds { get; set; }
        public IEnumerable<SelectListItem> SpecialitiesOfWorkers { get; set; }

        [Display(Name = "Place")]
        [Required]
        public int PlaceIds { get; set; }
        public IEnumerable<SelectListItem> Place { get; set; }
    }
}
