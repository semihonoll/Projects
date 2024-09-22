namespace _70_MVC_Area.Services
{
    public class Product
    {
        private static int _count;
        public Product()
        {
            ++_count;
        }
        public int Id { get; set; } = _count;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
