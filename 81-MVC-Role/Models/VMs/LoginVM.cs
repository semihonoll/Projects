﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace _81_MVC_Role.Models.VMs
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre alanız zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}
