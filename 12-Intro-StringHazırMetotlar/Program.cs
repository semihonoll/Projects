namespace _12_Intro_StringHazırMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hazır Metotlar (built in function): .NET Framework içerisinde System namespace altında bulunan hazır komutlardır.
            //String Fonksiyonlar
            //Math Fonksiyonlar
            //DateTime Fonksiyonlar

            //String Fonksiyonlar: metin işleme, biçimlendirme ve manipülasyon gibi işlemleri kolaylaştırır.

            //Length: Bir dizinin (metin) uzunluğunu (karakter sayısını);
            string metin = "Merhaba Dünya";
            int uzunluk = metin.Length;

            Console.Write("Ornek Metin: ");
            string ornekMetin = Console.ReadLine();

            #region CompareTo
            //Kullandığınız string değerle metoda verdiğiniz parametredeki string değeri sözlük mantığıyla karşılaştırır. Eğer sözlükte aynı lokasyonda yer alıyorlarsa 0, önce -1, sonra 1 değeri döndürür.

            //int sonuc = ornekMetin.CompareTo("bilgeadam");
            //Console.WriteLine(sonuc);

            //switch (sonuc)
            //{
            //    case -1:
            //        Console.WriteLine("Kelime diğer kelime ile eleşmemektedir. Eksik karakter vardır");
            //        break;
            //    case 0:
            //        Console.WriteLine("Kelimeler eşleşmektedir. Tebrikler");
            //        break;
            //    case 1:
            //        Console.WriteLine("Kelime diğer kelime ile eşleşmemektedir. Fazla karakter");
            //        break;
            //    default:
            //        break;
            //}

            #endregion

            #region Contains

            //bool varMi = ornekMetin.Contains("adam");
            //Console.WriteLine("Aradığınız Deger (adam) " + (varMi ? "bulunmaktadır" : "bulunmamaktadır"));

            #endregion

            #region StartsWith
            //Kelimenizin verilan parametre ile başlayıp başlamadığını bizlere bildirir.

            //Console.WriteLine(ornekMetin.StartsWith("bil") ? "Kelime \"bil\" ile başlıyor" : "kelime \"bil\" ile başlamıyor");

            #endregion

            #region EndsWith
            //Kelimenizin verilan parametre ile bitip bitmediği bizlere bildirir.

            //bool result = ornekMetin.EndsWith("dam");

            //Console.WriteLine( result ? "Kelime \"dam\" ile bitiyor" : "kelime \"dam\" ile bitmiyor");

            #endregion

            #region IndexOf

            // F  A  T  I  H
            //[0][1][2][3][4]

            //Eğer harf varsa harfin indixini, yoksa -1 değerini döndürür. Harf bir den fazla ise ilk harfin indexini döndürür...

            //int index = ornekMetin.IndexOf('a');
            //Console.WriteLine(index);
            //int index2 = ornekMetin.IndexOf('a', index + 1);
            //Console.WriteLine(index2 != -1 ? "Birden Fazla" : "Birden Fazla Yok");

            #endregion

            #region LastIndexOf

            //int index = ornekMetin.LastIndexOf('a');
            //Console.WriteLine(index);

            //if(ornekMetin.IndexOf('a') == ornekMetin.LastIndexOf('a'))
            //    Console.WriteLine("Birden fazla yok");
            //else
            //    Console.WriteLine("Birden fazla var");

            #endregion

            #region Remove
            //Belirli bir indexten sonrasını siler kalanı size yeni bir string olarak döndürür.

            //string metin2 = "BilgeAdam";
            //metin2 = metin2.Remove(5);
            ////Console.WriteLine(kalanMetin);
            //Console.WriteLine(metin2);

            //Console.WriteLine(ornekMetin.Remove(3, 2));
            #endregion

            #region Replace
            //Metin içindeki bir karakteri yada bir bölümü yeni bir karakter ile değiştirir.
            //Console.WriteLine(ornekMetin.Replace("adam","kadın"));

            #endregion

            #region Split
            //Bir metni özel bir karakterden birden fazla parçaya ayırmanıza olanak sağlar.
            //To: alkan@mail.com;fatih@mail.com,info@mail.com

            //string emailAdresleri = "alkan@mail.com;fatih@mail.com,info@mail.com,admin@mail.com;about@mail.com";
            //string[] adresler = emailAdresleri.Split(';', ',');

            //for (int i = 0; i < adresler.Length; i++)
            //{
            //    Console.WriteLine("Mail Gonderildi: " + adresler[i]);
            //}

            #endregion

            #region Insert
            //Bir metnin belirli bir pozisyonuna eleman eklemek için kullanılır.
            //string yeniMetin = ornekMetin.Insert(5, "cik");
            //Console.WriteLine(yeniMetin);
            #endregion

            #region ToLowerToUpper

            //Console.WriteLine(ornekMetin.ToLower());
            //Console.WriteLine(ornekMetin.ToUpper());
            #endregion

            #region SubString
            //Metininize gönderdiğiniz indexten başlayarak geri kalan kısmı çekip almanıza olanak sağlar.

            //string yeniMetin = ornekMetin.Substring(5);
            string yeniMetin = ornekMetin.Substring(3, 2);
            Console.WriteLine(yeniMetin);

            #endregion
        }
    }
}
