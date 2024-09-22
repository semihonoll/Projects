using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _67_MVC_ViewModel.Models.VMs
{
    public class CreateStudentVM
    {
        public IList<Course> Courses { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [DisplayName("Adınız: ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [DisplayName("Soyadınız: ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Yaş alanı zorunludur.")]
        [DisplayName("Yaşınız: ")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Kurs seçimi zorunludur.")]
        [DisplayName("Kurs Seçiniz: ")]
        public int CourseId { get; set; }
    }
}
