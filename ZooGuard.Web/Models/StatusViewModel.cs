using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class StatusViewModel
    {
        [HiddenInput] //Генерирование скрытого поля ввода
        public int? Id { get; set; }

        [Required, MaxLength(50), Display(Name = "StatusLabel")]
        public string Name { get; set; }
    }
}
