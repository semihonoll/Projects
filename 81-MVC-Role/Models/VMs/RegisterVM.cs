using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace _81_MVC_Role.Models.VMs
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre alanız zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler tutarsız")]
        [DataType(dataType: DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
