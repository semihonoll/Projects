namespace _3_Intro_TipDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Dönüşümleri");

            #region BilinçsizDonusum(ImplictConversion)

            short degisken1 = 23456;
            int degisken2 = degisken1;

            Console.WriteLine("Short Değişkeni: {0}, Int Değişkeni: {1}", degisken1, degisken2);

            #endregion

            #region BilincliDonusum(ExplictConversion)

            int degiskenA = 234567576;
            short degiskenB = (short)degiskenA;

            Console.WriteLine("Int Değişkeni: {0}, Short Değişkeni: {1}", degiskenA, degiskenB);

            #endregion

            #region ConvertSınıfı

            //Convert Sınıf, .NET Framework'te bulunan ve farklı veri tipleri arasında dönüşümleri gerçekleştirmek için kullanılan bir sınıftır.

            string cevrilecekSayi = "123";

            int cevrilmisBir = Convert.ToInt32(cevrilecekSayi);
            byte cevrilmisIki = Convert.ToByte(cevrilecekSayi);
            short cevrilmisUc = Convert.ToInt16(cevrilecekSayi);
            long cevrilmisDort = Convert.ToInt64(cevrilecekSayi);

            float cevrilmisBes = Convert.ToSingle(cevrilecekSayi);

            int deger1 = 1;
            bool sonuc = Convert.ToBoolean(deger1);

            Console.WriteLine(sonuc);

            #endregion

            #region Ornek-1

            Console.Write("Doğum Tarihini Giriniz: ");
            string gelenDeger = Console.ReadLine();
            int yil = Convert.ToInt32(gelenDeger);
            int yas = 2024 - yil;


            Console.WriteLine($"Yaşınız: {yas}");


            #endregion

            #region ToParse

            //Parse metodu yalnızca bir string ifadeyi belirli bir veri tipine dönüştürmek için kullanılır. Convert'e göre daha hızlıdır.

            string sayiDizisi = "123";
            int sayi = int.Parse(sayiDizisi);

            double onalik = double.Parse(sayiDizisi);

            #endregion

            #region ToString()

            int degerX1 = 10;
            double degerX2 = 10.5;

            Console.WriteLine("Deger1: " + degerX1.ToString());

            string degerDouble = degerX2.ToString();


            #endregion

            #region Ornek-2
            Console.WriteLine("Doğum Tarihini Giriniz: ");
            Console.WriteLine("Yaşınız: " + (2024 - int.Parse(Console.ReadLine())));
            #endregion
        }
    }
}
