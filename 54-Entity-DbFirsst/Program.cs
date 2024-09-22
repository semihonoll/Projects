using _54_Entity_DbFirsst.AppContext;
using _54_Entity_DbFirsst.Models;

namespace _54_Entity_DbFirsst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();

            var categories = db.Categories.Where(x => x.CategoryId>5).ToList();

            foreach (var category in categories) 
            {
                Console.WriteLine($"Id: {category.CategoryId} Adı: {category.CategoryName}");
            }


            //Category  category1 = new Category() 
            //{ 
            //    CategoryId =1, 
            //    CategoryName="Kırtasiye", 
            //    Description="Yeni Ürünler", 
            //    Products = new List<Product>() 
            //    { 
            //        new Product() { ProductName = "Kalem"},
            //        new Product() { ProductName = "Kitap"}
            //    } 
            //};

            Product product1 = new Product()
            {
                ProductId = 1,
                ProductName = "Kırmızı Kalem",
                UnitPrice = 50,
                UnitsInStock = 100,
                Category = new Category() { CategoryId = 1, CategoryName = "Kırtasiye" }
            };
        }
    }
}
