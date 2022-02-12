﻿using Microsoft.AspNetCore.Mvc;
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

        [Required, MaxLength(15)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Phone { get; set; }

        [Required, MaxLength(10)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Project { get; set; }

        [Required, MaxLength(20)] //Обязательное поле для заполнения, длинной не более 100 символов
        public string Email { get; set; }

        [Required, MaxLength(50)] //Обязательное поле для заполнения, длинной не более 50 символов
        public string Login { get; set; }

        [Required, DataType(DataType.Password)] 
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public int[] RoleIds { get; set; } //размер массива данных ролей к которым относится пользователь
        public IList<string> Roles { get; set; } //доступ к массиву ролей

        [Display(Name = "Positions")]
        [Required, MinLength(1)]
        public int[] PositionsIds { get; set; } //размер массива данных позиций
        public IEnumerable<SelectListItem> Positions { get; set; } //доступ к массиву позиций
    }
}
