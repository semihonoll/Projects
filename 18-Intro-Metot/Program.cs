namespace _18_Intro_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Başlıyor");
    
            //Metot Çağırma

            BilgiGoster("Fatih");
            TamIsimYaz("Yasin", "Arı", 46);
            BilgiYaz();

            string bilgi = Merhaba();
            Console.WriteLine(bilgi);
            Console.WriteLine(Merhaba());


            Console.WriteLine("Lütfen 1. Sayıyı Gir: ");
            int girilenSayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 2. Sayıyı Gir: ");
            int girilenSayi2 = int.Parse(Console.ReadLine());

            int sonuc = Topla(girilenSayi1, girilenSayi2);

            Console.WriteLine("Sonuc: " + sonuc);

            Console.WriteLine("Topla 1: " +Topla(2,5));
            Console.WriteLine("Topla 2: " +Topla(34,12));

        }

        //Metot Nedir?
        /*
         * Belirli bir işlevi yerine getirmek için hazırlanmış belirli bir kod bloğunu bir isim altında toplayıp. Kodu çalıştırmak istediğimiz yerde vermiş olduğumuz isimle çağırıp içerisinde ki kodun yeniden kullanılmasına izin veren programlama yapılarıdır.
         */

        //Metot Syntax/Tanımlama
        //[Erişim_Belirleyici] [Niteliyici?] [DonusTipi] [MetoAdi] ([parametreler?])
        //   private/public        static     void/Tip      Isim     (parametre listesi)
        //{
        //    Metot Bloğu: çalışmasını istediğimiz kodlar.
        //}

        //Parametresiz Geriye Değer Döndürmeyen Metot
        private static void BilgiYaz()
        {
            Console.WriteLine("Işlem Seçiniz:");
            Console.WriteLine("Topla [+], Fark [-], Carpim [*], Bolum [/]");
        }

        //1 Parametreli Geriye Değer Döndürmeyen Metot
        public static void BilgiGoster(string isim)
        {
            Console.WriteLine("Hoşgeldin: " + isim);
        }

        //3 Parametreli Geriye Değer Döndürmeyen Metot
        static void TamIsimYaz(string isim, string soyisim, int yas)
        {
            Console.WriteLine("Adınız: " + isim);
            Console.WriteLine("Soyadını: " + soyisim);
            Console.WriteLine("Yaşınız: " + yas);
        }

        //Geriye Değer Döndüren Parametresiz Metot
        static string Merhaba()
        {
            return "Merhaba Dünya!";
        }

        //Geriye Değer Döndüren 2 Paremetreli Metot
        private static int Topla(int sayi1, int sayi2)
        {
            int sonuc;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }
    }
}
