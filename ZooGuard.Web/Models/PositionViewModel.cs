using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class PositionViewModel
    {
        [HiddenInput]
        public int? Id { get; set; }

        [Required, MaxLength(200)] 
        public string Name { get; set; }

        [Required, DataType(DataType.Date)] 
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Document")]
        public string RegistrationDocument { get; set; }

        [Required, MaxLength(50)]
        [Display(Name = "ID number")]
        public string AccountingNumber { get; set; }

        [Required, MaxLength(100)]
        [Display(Name = "Information")]
        public string Information { get; set; }

        [Display(Name = "Venders")]
        [Required]
        public int VenderId { get; set; }
        public IEnumerable<SelectListItem> Venders { get; set; }

        [Display(Name = "Storages")]
        [Required]
        public int StorageId { get; set; }
        public IEnumerable<SelectListItem> Storages { get; set; }

        [Display(Name = "Property")]
        [Required]
        public int FormOfOccurenceId { get; set; }
        public IEnumerable<SelectListItem> FormOfOccurences { get; set; }

        [Display(Name = "Status label")]
        [Required]
        public int StatusLabelId { get; set; }
        public IEnumerable<SelectListItem> StatusLabels { get; set; }

        [Display(Name = "User")]
        [Required]
        public int UserId { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
