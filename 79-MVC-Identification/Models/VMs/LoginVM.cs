using System.ComponentModel.DataAnnotations;

namespace _79_MVC_Identification.Models.VMs
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail: ")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre: ")]
        public string Password { get; set; }
    }
}
