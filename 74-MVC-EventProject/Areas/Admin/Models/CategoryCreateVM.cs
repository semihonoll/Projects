using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _74_MVC_EventProject.Areas.Admin.Models
{
    public class CategoryCreateVM
    {
        [Required(ErrorMessage = "Ad alanı zorunludur!")]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
    }
}
