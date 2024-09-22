namespace _17_Intro_ListLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir Öğrenci Otomasyon Sistemi Yazınız
            //1-Oğrenci Ekleme, 2-Öğrenci Silme, 3-Öğrencli Listeleme, 

            List<string> ogrenciler = new List<string>();
            bool devaMi = true;

            Console.WriteLine("Öğrenci Otomasyon Sistemine Hoş Geldiniz...");
            while (devaMi) 
            {
                Console.WriteLine("1. Öğrenci Ekle");
                Console.WriteLine("2. Öğrenci Sil");
                Console.WriteLine("3. Öğrenci Listele");
                Console.WriteLine("4. Öğrenci Çıkış");

                int secim;
                while (!int.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 4)
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                }

                if (secim == 1)
                {
                    Console.Write("Eklemek istediğiniz öğrencinin adını giriniz: ");
                    string yeniOgrenci = Console.ReadLine().ToLower();
                    ogrenciler.Add(yeniOgrenci);
                    Console.WriteLine($"{yeniOgrenci} öğrencisi eklendi.");
                }
                else if (secim == 2)
                {
                    Console.Write("Silmek istediğiniz öğrencinin adını giriniz: ");
                    string silinecekOgrenci = Console.ReadLine().ToLower();
                    if (ogrenciler.Contains(silinecekOgrenci))
                    {
                        ogrenciler.Remove(silinecekOgrenci);
                        Console.WriteLine($"{silinecekOgrenci} öğrencisi silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci bulunamadı.");
                    }
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Öğrenci Listesi: ");
                    foreach (string ogrenci in ogrenciler)
                    {
                        Console.WriteLine(ogrenci);
                    }
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    Thread.Sleep(2000);
                    devaMi = false;
                }
            }
        }
    }
}
