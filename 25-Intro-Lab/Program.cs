namespace _25_Intro_Lab
{
    internal class Program
    {
        static List<string> urunAdlari = new List<string>();
        static List<double> urunFiyatlari = new List<double>();
        static List<double> urunMiktarlari = new List<double>();
        static double kdv = 0.20;
        
        static void Main(string[] args)
        {
            bool devamMi = true;
            while (devamMi)
            {
                Sepet(out devamMi);
            }

            Console.WriteLine("Program Kapandı...");
        }

        static void Sepet(out bool devaMi)
        {
            Console.WriteLine("Hoş Geldiniz! Lütfen Yapmak istediğiniz işlemi seçiniz: ");
            Console.WriteLine("1. Ürün Ekle");
            Console.WriteLine("2. Ürün Listele");
            Console.WriteLine("3. Ürün Çıkar");
            Console.WriteLine("4. Toplam Tutarı Görüntüle");
            Console.WriteLine("5. Çıkış");

            Console.Write("\nSeçim: ");
            string secim = Console.ReadLine();
            devaMi = true;

            switch (secim)
            {
                case "1":
                    UrunEkle();
                    break;
                case "2":
                    UrunListele();
                    break;
                case "3":
                    UrunCikar();
                    break;
                case "4":
                    Console.WriteLine($"Sepet Toplam: {ToplamTutar()} TL (Kdv Dahil)");
                    break;
                case "5":
                    devaMi = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyiniz.");
                    break;
            }
        }
        static void UrunEkle()
        {
            Console.WriteLine("Ürün eklemek için bilgileri girin: ");
            Console.Write("Ürün Adı: ");
            string ad = Console.ReadLine();

            Console.Write("Ürün Fiyatı: ");
            double fiyat;
            while (!double.TryParse(Console.ReadLine(), out fiyat))
            {
                Console.WriteLine("Geçersiz Fiyat. Lütfen tekrar deneyiniz.");
                Console.Write("Ürün Fiyatı: ");
            }

            Console.Write("Ürün Miktarı: ");
            double miktar;
            while (!double.TryParse(Console.ReadLine(), out miktar) || miktar <= 0)
            {
                Console.WriteLine("Geçersiz Miktar. Lütfen tekrar deneyiniz.");
                Console.Write("Ürün Miktari: ");
            }

            UrunListeyeEkle(ad, fiyat, miktar);

            void UrunListeyeEkle(string urunAdi, double urunFiyati, double urunMiktar)
            {
                try
                {
                    urunAdlari.Add(urunAdi.ToLower());
                    urunFiyatlari.Add(urunFiyati);
                    urunMiktarlari.Add(urunMiktar);

                    Console.WriteLine($"Sepete {urunAdi} : {urunFiyati} x {urunMiktar} = {urunFiyati * urunMiktar} Eklendi.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ürün eklerken hata gerçekleşti: " + ex.Message.ToString());
                }
            }
        }
        static void UrunListele()
        {
            Console.WriteLine("Sepette Bulunan Ürünler");

            if (urunAdlari.Count == 0)
            {
                Console.WriteLine("Sepette hiç bir ürün bulunmuyor.");
                Console.WriteLine("");
                return;
            }

            for (int i = 0; i < urunAdlari.Count; i++)
            {
                Console.WriteLine($"{i+1}) Urun: {urunAdlari[i]} - {urunFiyatlari[i]} x {urunMiktarlari[i]} = {urunFiyatlari[i] * urunMiktarlari[i]} TL. ");
            }

            Console.WriteLine("");
        }
        static void UrunCikar()
        {
            //Kullanıcı ürün eklemeden seçim yaparsa kontrol et liste boş ise bilgilendir.
            if (urunAdlari.Count == 0)
            {
                Console.WriteLine("Sepette hiç ürün bulunmuyor\n");
            }
            else
            {
                Console.Write("Çıkarmak istediğiniz ürünün adını girin: ");
                string ad = Console.ReadLine().ToLower();

                if (urunAdlari.Contains(ad))
                {
                    int index = urunAdlari.IndexOf(ad);

                    urunAdlari.RemoveAt(index);
                    urunFiyatlari.RemoveAt(index);
                    urunMiktarlari.RemoveAt(index);

                    Console.WriteLine($"{ad} ürünü sepetten çıkarıldı.");
                }
                else
                {
                    Console.WriteLine("Belirtilen isimde bir ürün sepette bulunamadı");
                }
            }
        }
        static double ToplamTutar()
        {
            double toplam = 0;
            for (int i = 0; i < urunAdlari.Count; i++)
            {
                toplam += (urunFiyatlari[i] * urunMiktarlari[i]) * kdv;
            }

            return toplam;
        }
    }
}
