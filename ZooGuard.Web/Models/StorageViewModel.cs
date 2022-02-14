using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class StorageViewModel
    {
        [HiddenInput] //Генерирование скрытого поля ввода
        public int? Id { get; set; }

        [Required, MaxLength(50), Display(Name = "Name")]
        public string Name { get; set; }

        [Required, MaxLength(50), Display(Name = "Addres")]
        public string ActualAddress { get; set; }

        [Required, MaxLength(50), Display(Name = "Characteristic")]
        public string Characteristic { get; set; }


    }
}
