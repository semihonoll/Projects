using System.Linq.Expressions;

namespace _70_MVC_Area.Services
{
    public class AppDbContext
    {
        private static List<Product> Products = new List<Product>()
        {
            new Product { Name="Kalem-1", Price=50, Stock=100 },
            new Product { Name="Kalem-2", Price=150, Stock=100 },
            new Product { Name="Kalem-3", Price=20, Stock=40 },
            new Product { Name="Kalem-4", Price=40, Stock=100 },
            new Product { Name="Kalem-5", Price=250, Stock=120 },
            new Product { Name="Kalem-6", Price=540, Stock=140 },
            new Product { Name="Kalem-7", Price=60, Stock=110 },
        };
        public static void UpdateActive(int id)
        {
            var result = Products.FirstOrDefault(x => x.Id == id);
            if (result.IsActive)
                result.IsActive = false;
            else
                result.IsActive = true;
        }

        public static bool Add(Product product)
        {
            try
            {
                Products.Add(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(Product product)
        {
            try
            {
                Products.Remove(product);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public static Product FirstOrDefault(Func<Product, bool> expression)
        {
            return Products.FirstOrDefault(expression);
        }

        public static List<Product> ToList() 
        { 
            return Products; 
        }

    }
}
