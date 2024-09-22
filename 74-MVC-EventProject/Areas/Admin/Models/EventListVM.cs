using System.ComponentModel;

namespace _74_MVC_EventProject.Areas.Admin.Models
{
    public class EventListVM
    {
        [DisplayName("No")]
        public int Id { get; set; }
        [DisplayName("Etkinlik Adı")]
        public string Name { get; set; }
        [DisplayName("Etkinlik Özeti")]
        public string Summary { get; set; }
        [DisplayName("Etkinlik Kategorisi")]
        public string CategoryName { get; set; }
        [DisplayName("Etkinlik Durumu")]
        public bool IsActive { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime CreateDate { get; set; }
    }
}
