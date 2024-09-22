namespace _13_Intro_MathVeDateSınıf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Math Sınıfı
            ////Mutlak Değer
            //int mutlakDeger = Math.Abs(-45);
            //Console.WriteLine(mutlakDeger.ToString());

            ////Floor -> verilen ondalıklı değeri bir alt tam değere tamamlar.
            //double deger = Math.Floor(12.98);
            //Console.WriteLine(deger.ToString());

            ////Ceiling => Verilen ondalıklı değeri bir üst tam değere tamamlar.
            //Console.WriteLine(Math.Ceiling(12.98).ToString());

            ////Round => Sayının yarısından fazlasını bir üste yarısından azını ise bir alttaki tam sayıya yuvarlar. (Çift sayıya yuvarlar.)
            //Console.WriteLine(Math.Round(11.50).ToString());

            ////Truncate => Sayının ondalıklı kısmına bakmaz yalnızca tam kısmını size teslim eder.
            //Console.WriteLine(Math.Truncate(12.98));

            ////Max-Min Value
            //Console.WriteLine(Math.Max(45, 65));
            //Console.WriteLine(Math.Min(45, 65));

            //// 45, 55, 75 üç sayının en büyüğünü bul
            //Console.WriteLine(Math.Max(Math.Max(45, 55), 75));

            ////Pow => Kuvvet Alma
            //Console.WriteLine(Math.Pow(3,4));

            ////Sqrt => Karakök
            //Console.WriteLine(Math.Sqrt(16));

            ////Sign=> bir sayının negatif, pozitif veya 0 eşit olup olmadığını

            //Console.WriteLine(Math.Sign(-25));

            ////Trigonemetrik Fonksiyonlar

            //double derece = 30;
            //double radyan = derece * Math.PI / 180;
            //double sinDeger = Math.Sin(radyan);
            #endregion

            #region DateTime

            DateTime dateTime = DateTime.Now; //Şuanın tarih ve saat bilgisi
            Console.WriteLine(dateTime);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            DateTime bugun = DateTime.Today; //Şuanın tarih bilgisi.
            Console.WriteLine(bugun);

            DateTime belirliTarih = new DateTime(2024, 4, 1);
            Console.WriteLine(belirliTarih);

            DateTime belirliSaat = new DateTime(2024, 4, 1, 12, 30, 0);
            Console.WriteLine(belirliSaat);

            Console.WriteLine("*************************");
            int yil = DateTime.Now.Year;
            int ay = DateTime.Now.Month;
            int gun = DateTime.Now.Day;
            int saat = belirliSaat.Second;
            DayOfWeek haftaninGunun = DateTime.Now.DayOfWeek;

            Console.WriteLine("**************************");
            DateTime yeniZaman = new DateTime(1987, 03, 31, 22, 30, 0);
            DateTime bugun2 = DateTime.Now;

            TimeSpan zamanFarki = bugun2 - yeniZaman;
            double sonuc = zamanFarki.TotalHours;

            Console.WriteLine("Şu kadar saattir yaşıyorum: " + sonuc);
            #endregion
        }
    }
}
