using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace _2_Intro_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             DEĞİŞKENLER (Önceden tanımlı değişkenler, ilkel değişkenler)
            -- Değişkenler, değerleri saklamak ve işlemek için kullanılan adlandırılmış bellek alanlarıdır.
            -- Gereksiz değişken tanımlamaktan kaçının. Kullanmayacağınız bir değişkeni asla tanımlamayınız.
             */

            #region DegiskenKonuAnlatim

            //Ornek-1
            int a = 5;
            int b = 10;
            int c = a + b;

            Console.WriteLine(c);

            //Ornek-2
            int sayi1, sayi2, sonuc;

            sayi1 = 50;
            sayi2 = 40;
            sonuc = sayi1 + sayi2;

            Console.WriteLine(sonuc);

            //Temel Veri Tipleri

            //Tam Sayılar (int, long, short, byte, uint, ulong, ushort)
            int number = 42;

            //Ondalıklı Sayılar(Floot, Double Decimal)
            double pi = 3.14;

            //Karekterler (char)
            char letter = 'A';

            //Metin (string)
            string message = "Merahaba Dünya";

            //Mantıksal Değer (bool)
            bool isTrue = false;

            bool kayitVarMi = true;

            bool buyukMu = 10 > 2;

            //Değişken Gösterimi

            string adi = "Ismail";
            Console.WriteLine(adi);

            //(+) Birleştirme Operatorü
            Console.WriteLine("Merhaba " + adi);

            //(Place Holder) Yer Tutucu
            Console.WriteLine("Benim adım {0} dır. ",adi);

            string firstName = "Fatih";
            string lastName = "Alkan";
            Console.WriteLine("Benim adım {0} soyadım {1} yaşım {2} dır",firstName,lastName,37);

            Console.WriteLine("Benim adım " + firstName + " soyadım " + lastName + " yaşım " + 37 + " dir.");

            //String Interpolation (Girintileme)
            firstName = "Ismail";
            lastName = "Arı";
            Console.WriteLine($"Benim Adım {firstName} soyadım {lastName} yaşım {37} dir");

            #endregion

            #region Degisken-SayısalDegerler

            //Sayısayl Veri Tipleri

            //8 byte
            //Max 127, Min = -128
            sbyte degiskenBir = 24;

            //8 byte
            //Max 255, Min = 0
            byte degisken_iki = 45;

            //16 byte
            //Max 32767, Min -32767
            short degiskenUc = -2344;

            //Max 65535, Min 0
            ushort degiskenDort = 1231;

            //32 byte
            //Max 2.1 Milyar, Min -2.1 Milyar
            int degiskenBes = 12321321;

            //Max 4.2 Milyar, Min 0 Milyar
            uint degiskenAlti = 2131242443;

            //64 byte
            //Max 9.2 Kattrilyon, Min -9.2
            long degiskenYedi = -1231232136;

            //Max 18.4 Kattrilyon
            ulong degiskenSekiz = 123213213123;


            #endregion

            #region Degisken-Ondalikli

            // .dan sonra 7 hane desteği
            float ondalikBir = 2.4455F;

            // .dan sonra 14 hane desteği
            double ondalikIki = 2.3432432;

            decimal ondalikUc = 2.123123213123M;

            #endregion

            #region Object

            //Object herhangi bir türden nesnelerin temelini oluşturan genel bir türdür. C#'da herşey object türünden türemiştir.

            object degiskenA = 10;
            object degiskenB = "Alkan";
            object degiskenC = 'C';
            object degiskenD = 12.9F;

            //Console.WriteLine("Toplam: " + degiskenA * 2);

            #endregion

            #region Var

            //C# 3.0 ile birlikte tanıtıldı derleme zamanında atandığı tipe bürünür.

            var age = 35;
            var name = "fatih";

            Console.WriteLine("Toplam: " + age + 5);

            #endregion

            //Derleme Zamanı (Compile Time) ve Çalışma Zamanı (Runtime)
        }
    }
}
