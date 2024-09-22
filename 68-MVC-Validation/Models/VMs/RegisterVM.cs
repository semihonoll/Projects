using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _68_MVC_Validation.Models.VMs
{
    public class RegisterVM
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ad alanı zorunludur?")]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [Display(Name = "E-Posta Adresi")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DisplayName("Şifre")]
        //[MinLength(6, ErrorMessage = "Şifre en az 6 karakter uzunluğunda olmalıdır.")]
        [StringLength(10,ErrorMessage = "Şifre en az 6 karakter, en fazla 10 karakter uzunluğunda olmalıdır",MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        //............

        [Range(18,99, ErrorMessage = "Yaş Aralığı 18 ile 99 arasında olmalıdır.")]
        public int Age { get; set; }

        [RegularExpression(@"^\d{5}$", ErrorMessage = "Posta kodu 5 rakamdan oluşmalı.")]
        public string PostaCode { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Editable(false)] //Read Only
        public string Name { get; set; }
    }
}
