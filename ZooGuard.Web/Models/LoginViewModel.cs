﻿using System.ComponentModel.DataAnnotations;

namespace ZooGuard.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
