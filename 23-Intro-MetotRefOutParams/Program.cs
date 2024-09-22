using System.Xml;

namespace _23_Intro_MetotRefOutParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ref - Out - Params Keywords

            //Out Anahtar Kelimesi

            int Kalan;
            int sonuc = Bolme(3, 2, out Kalan);

            Console.WriteLine("3/2 = " + sonuc + " Kalanı = " + Kalan);

            int Q, P;
            Toplam(out P, out Q);
            Console.WriteLine("Q: " + Q + "P: " + P);

            //Params Anahtar Kelimesi

            Carp(2, 3, 5, 7);

            //Ref Anahtar Kelimesi

            int degisecekSayi = 5;

            Degistir(ref degisecekSayi);

            Console.WriteLine(degisecekSayi);

            Console.WriteLine("3 Faktoriel: " + Factoriel(3));
        }

        #region Out Keyword
        //out anahtar kelimesi, bir metottan birden fazla değer döndürmek için kullanılır.

        public static int Bolme(int bolunen, int bolen, out int kalan)
        {
            int bolum = bolunen / bolen;
            kalan = bolunen % bolen;
            return bolum;
        }

        static void Toplam(out int p, out int q)
        {
            p = 30;
            q = 50;
        }

        #endregion

        #region Params Keyword
        //Params anahtar kelimesi, bir metoda n sayıda paremtre geçmenizi sağlar. Bu parametreler aynı türden olmalıdır. Metot imzasında son parametre olarak kullanılmalıdır.

        public static void Carp(double x, params int[] sayilar)
        {
            int carp = 1;
            foreach (int sayi in sayilar)
            {
                carp *= sayi;
            }

            Console.WriteLine("Carpim : {0}", carp);
        }

        #endregion

        #region Ref Keyword
        //Ref anahtar kelimesi, bir parametrenin referans olarak geçilmesini sağlar. Bir parametrenin değerinin metot içinde değişebilir olmasını sağlar. ref anahtar kelimesiyle belirtilen parametre metot içinde başka bir değer değiştirilebilir.

        public static void Degistir(ref int sayi)
        {
            sayi = 10;
        }

        #endregion


        #region Recursive Meto (Özyinelemeli)

        //Recursive metotlar, kendi kendini çağıran metotlardır.
        //5! => 5.4.3.2.1 0! = 1

        public static int Factoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factoriel(n-1);
            }
        }

        #endregion

    }
}
