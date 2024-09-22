namespace _33_OOP_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(); //Instance
            product.Name = "Kalem-101";
            product.Price = 100;
            product.Stock = 100;
            product.Status = true;

            Product product1 = new Product() { Name = "Kalem-102", Price = 120, Stock = 100, Status = true };

            Product product2 = new Product() { Name = "Kalem-103", Price = 90, Stock = 50, Status = true };

            Product product3 = new Product() { Name = "Kalem-104", Price = 110, Stock = 50, Status = true };

            Product product4 = new Product() { Name = "Kalem-105", Price = 80, Stock = 150, Status = true };


            List<Product> products = new List<Product>() { product, product1, product2, product3, product4 };

            Console.WriteLine("Stok Takip Sistemi");
            Console.WriteLine("Tüm Ürünler");

            foreach (var item in products)
            {
                Console.WriteLine($"Urun Id: {item.Id} Name: {item.Name} Stock: {item.Stock}");
            }

            Console.WriteLine("\nStok Adeti 50'dan Fazla Olan Ürünler");

            foreach (Product item in products)
            {
                if (item.Stock > 50)
                {
                    Console.WriteLine($"Urun Id: {item.Id} Name: {item.Name} Stock: {item.Stock}");
                }
            }

            Console.WriteLine("\nFiyatı 100'den Fazla Olan Ürünler");
            foreach (var item in products)
            {
                if (item.Price>100)
                {
                    Console.WriteLine($"Urun Id: {item.Id} Name: {item.Name} Stock: {item.Price}");
                }
            }

            Console.WriteLine("\nNe Yapmak İstiyorsun Stok Ekle [E] - Çıkar [C]");
            string result = Console.ReadLine();
            if (result.ToUpper() == "E")
            {
                foreach (var item in products)
                {
                    item.StockAdd(25);
                    Console.WriteLine($"Urun Id: {item.Id} Name: {item.Name} Stock: {item.Stock}");
                }
            }
            else
            {

            }

        }
    }
}
