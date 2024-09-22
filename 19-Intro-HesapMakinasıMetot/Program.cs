namespace _19_Intro_HesapMakinasıMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baslangic();
        }

        private static void Baslangic()
        {
            BilgiYaz();

            bool devamMi = true;

            while (devamMi)
            {
                Console.Write("Islem: ");
                string mathOp = Console.ReadLine();

                Islem(mathOp, Sayilar());

                Console.WriteLine("Devam Etmek Istiyormusunuz: [true] [false]");
                devamMi = bool.Parse(Console.ReadLine());
            }
            Console.WriteLine("Uygulama kapandı");
        }

        static void BilgiYaz()
        {
            Console.WriteLine("C# Hesap Makinası Programı - Metotlar");
            Console.WriteLine("İşlemler: Topla [+], Fark [-] Çarpım [*] Bölüm [/]");
        }

        static void Islem(string mathOp, double[] sayilar)
        {
            if (mathOp == "+")
            {
                Console.WriteLine("Toplamı: " + Topla(sayilar[0], sayilar[1]));
            }
            else if (mathOp == "-")
            {
                Console.WriteLine("Farkı: " + Fark(sayilar[0], sayilar[1]));
            }
            else if (mathOp == "/")
            {
                Console.WriteLine("Bölüm: " + Bol(sayilar[0], sayilar[1]));
            }
            else if (mathOp == "*")
            {
                Console.WriteLine("Carpim: " + Carp(sayilar[0], sayilar[1]));
            }
        }

        static double[] Sayilar()
        {
            double[] sayilar = new double[2];

            try
            {
                Console.Write("Sayi-1: ");
                sayilar[0] = int.Parse(Console.ReadLine());

                Console.Write("Sayi-2: ");
                sayilar[1] = int.Parse(Console.ReadLine());

                return sayilar;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                throw;
            }

        }

        static double Topla(double x, double y) 
        {
            return x + y;
        }

        static double Fark(double x, double y)
        {
            return x - y;
        }

        static double Bol(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                Console.WriteLine("Sıfıra Bölünemez.");
                return 0;
                //throw new Exception("Sıfıra Bölünemez");
            }
        }

        static double Carp(double x, double y)
        {
            return x * y;
        }
    }
}
