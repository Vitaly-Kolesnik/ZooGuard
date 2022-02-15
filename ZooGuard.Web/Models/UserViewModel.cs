using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput] //Генерирование скрытого поля ввода
        public int? Id { get; set; }

        [Required, MaxLength(100)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Name { get; set; }

        [Required, MaxLength(100)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string LastName { get; set; }

        [Required, MaxLength(50)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Phone { get; set; }

        [Required, MaxLength(50)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Project { get; set; }

        [Required, MaxLength(50)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Email { get; set; }

        [Required, MaxLength(50)] //Обязательное поле для заполнения, длинной не более 50 символов
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Roles")]
        [Required]
        public int[] RoleIds { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}
