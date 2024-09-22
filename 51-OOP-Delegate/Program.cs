namespace _51_OOP_Delegate
{
    internal class Program
    {
        //Delegate: bir metoda atıfta bulunan bir nesnedir. Metotlara referans oluşturabilen bir değişkent.

        public delegate void CalculateDelegate(int x, int y);
        

        static void Main(string[] args)
        {
            CalculateDelegate calculateDelegate = new CalculateDelegate(Alan);
            calculateDelegate += Cevre;

            calculateDelegate(50, 20);

            //Predicate

            Func<int, int, int> func = Sum;
            int result = func(50, 20);

            Action<string> action = Print;
            action("Merhaba");

            calculateDelegate -= Alan;
            calculateDelegate(50, 20);
        }

        public static void Alan(int taban, int yukseklik)
        {
            Console.WriteLine($"Alan: {taban*yukseklik}");
        }

        public static void Cevre(int taban, int yukseklik)
        {
            Console.WriteLine($"Çevre: {2 * (taban+yukseklik)}");
        }

        public static int Sum(int x, int y) 
        {
            return x + y;
        }

        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
