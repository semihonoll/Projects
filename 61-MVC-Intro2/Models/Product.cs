using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _61_MVC_Intro2.Models
{
    public class Product
    {
        public int Id { get; set; }

  
        [MaxLength(100)]
        [DisplayName("Ürün Adı: ")]
        public string Name { get; set; }

        [DisplayName("Ürün Fiyatı: ")]
        public double Price { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
