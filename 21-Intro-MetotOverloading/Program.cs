namespace _21_Intro_MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default Parametreli
            SelamVer("Fatih Alkan");
            SelamVer();

            BilgiGoster("Fatih", "36");
            BilgiGoster("Beyazıt", "5");

            //Metot Overloading

            Console.WriteLine();
            Console.WriteLine(true);
            Console.WriteLine('a');

            int result1 = Topla(10, 6, 20);
        }

        #region DefaultParametre
        //Default (Varsayılan) parametreli metotlar.
        public static void SelamVer(string isim = "Dünya")
        {
            Console.WriteLine("Merhaba: " + isim + "!");
        }

        //Default parametre kullanımı, default değeri olmayana parmetrelerle birlik kullanılması durumunda opsiyonel özelliğini kaybetmemek için en sona yazılır.
        public static void BilgiGoster(string ad, string yas, string meslek = "Mühendis")
        {
            Console.WriteLine("Adı: " + ad + " Yaşı: " + yas + " Meslek: " + meslek);
        }
        #endregion

        #region MetotOverloading
        //Metot Overloading (Metot Aşırı yükleme)

        /// <summary>
        /// Bu metot bir toplama işlemi yapar.
        /// </summary>
        /// <param name="sayi1">Int tipinde bir sayi</param>
        /// <param name="sayi2">Int tipinde bir sayi</param>
        /// <returns>Toplam değer</returns>
        private static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        //Paremetre = Metot imzası farklı
        /// <summary>
        /// Bu metot bir toplama işlemi yapar.
        /// </summary>
        /// <param name="sayi1">Int tipinde bir sayi</param>
        /// <param name="sayi2">Int tipinde bir sayi</param>
        /// <param name="sayi3">Int tipinde bir sayi</param>
        /// <returns>Toplam değer</returns>
        private static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        /// <summary>
        /// Bu metot bir toplama işlemi yapar.
        /// </summary>
        /// <param name="sayi1">Int tipinde bir sayi</param>
        /// <param name="sayi2">Int tipinde bir sayi</param>
        /// <param name="sayi3">Int tipinde bir sayi</param>
        /// <param name="sayi4">Int tipinde bir sayi</param>
        /// <returns>Toplam değer</returns>
        private static int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        {
            return sayi1 + sayi2 + sayi3 + sayi4;
        }


        #endregion
    }
}
