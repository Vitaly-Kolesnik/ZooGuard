using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class PositionViewModel
    {
        [HiddenInput] //Генерирование скрытого поля ввода
        public int? Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string RegistrationDocument { get; set; }

        [Required, MinLength(1)]
        public int AccountingNumber { get; set; }

        [HiddenInput]
        public bool RealityFlag { get; set; }

        [Required, MaxLength(500)]
        public string Information { get; set; }

        [HiddenInput]
        public int IdOwnerPosition { get; set; }

        [Required, MaxLength(200)]
        public string NameOwnerPosition { get; set; }

        [HiddenInput]
        public int IdFormOfOccurence { get; set; }

        [Required, MaxLength(200)]
        public string NameFormOfOccurence { get; set; }

        [HiddenInput]
        public int IdUser { get; set; }

        [Required, MaxLength(200)]
        public string NameUser { get; set; }

        [HiddenInput]
        public int IdStatusLabel { get; set; }

        [Required, MaxLength(200)]
        public int NameStatusLabel { get; set; }

        [Display(Name = "oldPositions")]
        [Required, MinLength(1)]
        public int[] OldPositionsIds { get; set; }
        public IEnumerable<SelectListItem> OldPositions { get; set; }
    }
}
