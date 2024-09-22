using _74_MVC_EventProject.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _74_MVC_EventProject.Areas.Admin.Models
{
    public class EventCreateVM
    {
        [DisplayName("Etkinlik Adı")]
        [Required(ErrorMessage = "Etkinlik adı zorunludur.")]
        public string Name { get; set; }

        [DisplayName("Etkinlik Özeti")]
        [Required(ErrorMessage = "Etkinlik özeti zorunludur.")]
        [StringLength(150, ErrorMessage = "Etkinlik özeti maksimum 150 karakter olmalıdır.")]
        public string Summary { get; set; }
        public int CategoryId { get; set; }
        public List<Category>? Categories { get; set; }
    }
}
