namespace _5_Intro_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else
            //Mantiksal bir ifadenin sonuncuna bağlı olarak iki farklı kod bloğundan birini çalıştırmak istediğimiz zamanda if deyimi kullanılır.

            /*
             == Eşiklik kontrolü
             != Eşitsizlik kontrolü
             < 
             >
             <=
             >=
             */

            //Console.WriteLine("User Name: ");
            //string userName = Console.ReadLine();

            //if (userName == "admin") //Koşul Alanı
            //{
            //    //Koşul Gereçekleşecekse çalışacak kodlarım.
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("Hoşgeldin Sahip");
            //}
            //else
            //{
            //    //Koşul Gerçekleşmediyse çalışacak kodlar.
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Üzgünüm Tanıyamadım.");
            //}

            //Console.WriteLine("Buradayım...");
            #endregion

            #region If-Else2
            //Kullanicidan Vize ve Final Notlarını alın 2 ye bölün ortalama 50 den büyükse "Geçtiniz" küçükse "Kaldınız" yazsın.

            //Console.Write("Vize Notu: ");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Final Notu: ");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (final + vize) / 2;

            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("Tebrikler \n\tGeçtiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Üzgünüm \n\tKaldınız");
            //}

            #endregion

            #region If-ElseIf-Else
            //Programın birden fazla karar vermesi gerektiği durumlarda kullanılır.

            //Console.Write("Not: ");
            //int not = int.Parse(Console.ReadLine());

            //if (not < 0)
            //{
            //    Console.WriteLine("0 dan küçük bir not girişi yapamazsınız.");
            //}
            //else if (not > 100)
            //{
            //    Console.WriteLine("100 den büyük bir not girişi yapamazsınız");
            //}
            //else
            //{
            //    Console.WriteLine("Hatasız not giriş yaptınız...");
            //}

            #endregion

            #region If-ElseIf-Else
            //Console.WriteLine("1 ile 7 arasında haftanın bir günün giriniz: ");
            //int gun = int.Parse(Console.ReadLine());

            //if (gun == 1)
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == 2) 
            //{
            //    Console.WriteLine("Salı");
            //}
            //else if (gun == 3) 
            //{
            //    Console.WriteLine("Çarşamba");
            //}
            //else if (gun == 4)
            //{
            //    Console.WriteLine("Perşembe");
            //}
            //else if (gun == 5)
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == 6)
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == 7)
            //{
            //    Console.WriteLine("Pazar");
            //}

            #endregion

            #region Kullanicidan girilan sayi çift mi tekmi bulan program

            //Console.Write("Bir Sayı Giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı ciddi ciddi çiftir");
            //}
            //else 
            //{ 
            //    Console.WriteLine("sAYI CİDDEN TEKTİR"); 
            //}

            #endregion


            //Manıksal Operatörler
            //&& (VE) (AND)
            //|| (VEYA) (OR)

            #region Ornek1
            //Kullanici Adı: admin Sifre: 123
            //Console.Write("Kullanici Adı: ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.WriteLine("Şifre: ");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi == "admin" && sifre == "123")
            //{
            //    Console.WriteLine("Tebrikler. Hoşgeldiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Email adresiniz veya Şifre Hatalı");
            //}

            //*************************************************************

            //if (kullaniciAdi == "admin")
            //{
            //    if (sifre == "123")
            //    {
            //        Console.WriteLine("Teberkiler. Hoşgeldiniz.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("şifre hatalı");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Kullanici Adı Hatalı");
            //}


            #endregion

            #region Ornek2
            //Girilen Not: 0-30 aralığı ise FF, 30-50 aralığı ise DD, 50-70 aralığı ise BB, 70-100 AA

            //Console.WriteLine("Not: ");
            //int not = Convert.ToInt32(Console.ReadLine());
            //string mesaj = null;

            //if (not >= 0 && not <= 30)
            //{
            //    mesaj = "Harf Notunuz: FF";
            //}
            //else if (not > 30 && not <= 50)
            //{
            //    mesaj = "Harf Notunuz: DD";
            //}
            //else if (not > 50 && not <= 70)
            //{
            //    mesaj = "Harf Notunuz: BB";
            //}
            //else if (not > 70 && not <= 100)
            //{
            //    mesaj = "Harf Notunuz: AA";
            //}
            //else 
            //{
            //    mesaj = "Geçersiz not girişi yaptınız";
            //}

            //Console.WriteLine(mesaj);


            #endregion

            #region Ornek3
            //Dışarıdan ürün adı girilecek makine bize ürünün hangi bölümde olduğunu söylecek.
            //Domates, Biber, Patlican => Sebze Bölümü
            //Parfüm, Şampuan, Sabun => Kozmetik Bölümü
            //Telefon, Kulaklık, Pil => Teknoloji Bölümü
            //Başka bir ürün girilirse => Bu ürün bizde yok

            //Console.Write("Ürün: ");
            //string urun = Console.ReadLine();

            //if (urun == "Domates" || urun == "Biber" || urun == "Patlican")
            //{
            //    Console.WriteLine("Sebze Bolumu");
            //}
            //else if (urun == "Parfüm" || urun == "Şampuan" || urun == "Sabun")
            //{
            //    Console.WriteLine("Kozmetik Bolumu");
            //}
            //else if (urun == "Telefon" || urun == "Kulaklık" || urun == "Pil")
            //{
            //    Console.WriteLine("Teknoloji Bolumu");
            //}
            //else
            //{
            //    Console.WriteLine("Bu ürün bizde yok.");
            //}

            #endregion

            #region Ornek4
            //Dışarıdan sipariş alınacak olan kitap miktarı girilsin. Sipariş sayısı 20 den az ise toplam ücretten %5, 20-50 arasında ise %10, 50-100 arasında ise %15, 100 den büyük ise %25 indirim. yapılsın. Kitap birim fiyatı 20TL Sonrasında Ekrana

            //Satılan Kitap Miktarı: 110

            //Toplam Fiyat: 110 x 20 = 2200
            //Indirim Miktari: 550TL
            //Indirimli Toplam Fiyat: 1650 TL 
  
            for (int i = 0; i < 5; i++) 
            {
                Console.Write(".");
                Console.Beep();
                Thread.Sleep(1000);
            }
            Console.WriteLine("---> Kitap Stok Programına Hoş Geldiniz -->");


            double birimFiyat, toplamFiyat, indirimliFiyat=0, indirimMiktari=0;
            int miktar;

            Console.Write("Kitap Birim Fiyatını Giriniz: ");
            birimFiyat = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kitap Miktarını Giriniz: ");
            miktar = Convert.ToInt32(Console.ReadLine());

            toplamFiyat = birimFiyat * miktar;

            if (miktar>0 && miktar <= 20)
            {
                indirimMiktari = toplamFiyat * 0.05;
                indirimliFiyat = toplamFiyat - indirimMiktari;
            }
            else if (miktar > 20 && miktar <= 50)
            {
                indirimMiktari = toplamFiyat * 0.10;
                indirimliFiyat = toplamFiyat - indirimMiktari;
            }
            else if (miktar > 50 && miktar <= 100)
            {
                indirimMiktari = toplamFiyat * 0.15;
                indirimliFiyat = toplamFiyat - indirimMiktari;
            }
            else if (miktar > 100)
            {
                indirimMiktari = toplamFiyat * 0.25;
                indirimliFiyat = toplamFiyat - indirimMiktari;
            }
            else
            {
                Console.WriteLine("Hatalı bir giriş yaptınız.");
            }

            Console.WriteLine($"Satılan Kitap Miktarı: {miktar} \nToplam Fiyat: {miktar} X {birimFiyat} = {toplamFiyat} \nIndirim Miktari: {indirimMiktari} \nIndirimli Toplam Fiyat: {indirimliFiyat}");


            #endregion
        }
    }
}
