using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class OccurenceViewModel
    {
        [HiddenInput] //Генерирование скрытого поля ввода
        public int? Id { get; set; }

        [Required, MaxLength(50), Display(Name = "Types of property")]
        public string Name { get; set; }
    }
}
