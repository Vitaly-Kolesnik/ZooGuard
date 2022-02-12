using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class VenderViewModel
    {
        [HiddenInput] //Генерирование скрытого поля ввода
        public int? Id { get; set; }

        [Required, MaxLength(50), Display(Name = "Company")]
        public string Name { get; set; } 

        [Required, MaxLength(200), Display(Name = "First Name")]
        public string FirstNameRepresentative { get; set; }

        [Required, MaxLength(200), Display(Name = "Last Name")]
        public string LastNameRepresentative { get; set; }

        [Required, MaxLength(15), Display(Name = "Phone")]
        public string PhoneRepresentative { get; set; }

        [Required, MaxLength(15), Display(Name = "Email")]
        public string EmailRepresentative { get; set; }

        [Required, MaxLength(50), Display(Name = "Adress")]
        public string MailingAddress { get; set; }

        [Required, MaxLength(200), Display(Name = "About vender")]
        public string Сomment { get; set; }
    }
}
