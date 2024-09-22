using _68_MVC_Validation.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _68_MVC_Validation.Models.VMs
{
    public class ProductCreateVM
    {
        [Required(ErrorMessage = "Ad Alanı Zorunludur.")]
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Tarih Alanı Zorunludur.")]
        [DisplayName("Ürün Tarihi: ")]
        [CustomDateValidation(2023,1,1,ErrorMessage = "2023 den geçmiş bir tarih olamaz.")]
        public DateTime ReleaseDate { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    //Araştırma...
        //}
    }
}
