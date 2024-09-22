using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _70_MVC_Area.Areas.Admin.Models
{
    public class AdminUser
    {
        [Required]
        [DisplayName("Kullanıcı Adı: ")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Şifre: ")]
        public string Password { get; set; }
    }
}
