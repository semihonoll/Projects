namespace _24_Intro_LocalFunction
{
    internal class Program
    {
        //C# 7.0 Local Metot veya Function bir bir metot içerisinde yeni bir metot tanımlamamıza izin verildi.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int sonuc1 = Add(10, 5);
            Console.WriteLine(sonuc1);

            //Local Function
            int Add(int x, int y)
            { 
                return x + y;
            }

            int sonuc2 = Add(10, 50);
            Console.WriteLine(sonuc2);

            Topla(2, 5);
        }

        public static int Topla(int sayi1, int sayi2)
        { 
            int Carp(int x, int y) 
            {
                return x * y;
            }

            return sayi1 + Carp(sayi1, sayi2);
        }
    }
}
