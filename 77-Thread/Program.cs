namespace _77_Thread
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Thread thread = new Thread(UrunListele);

            //Thread (İş Parçarcığı): aynı anda birden fazla iş parçacığını çok görevlerde kullanmak.
            //CPU-Bound

            bool devamMi = true;
            while (devamMi) 
            {
                Console.WriteLine("İşlem Seçiniz:");
                Console.WriteLine("1-Ürünlerli Liste, 2-Rapor Yazdır, 3-Çıkış, 4-Tüm İşlemler");
                string islem = Console.ReadLine();
                if (islem == "1")
                {
                    //Ürün listeleme
                    //Yeni bir thread oluştur: İş parcacığının hangi metodu çağıracağını belirtmek.
                    Thread ThreadUrunListe = new Thread(new ThreadStart(UrunListele));

                    ThreadUrunListe.Start();
                    //UrunListele();
                }
                else if (islem == "2")
                {
                    //Rapor yazdırma
                    RaporYazdır();
                }
                else if (islem == "3")
                {
                    //Çıkış
                    devamMi = false;
                }
                else if (islem == "4") 
                { 
                    Thread ThreadUrunListele = new Thread(new ThreadStart(UrunListele));
                    Thread ThreadRaporYazdir = new Thread(new ThreadStart(RaporYazdır));
                    ThreadUrunListele.Start();
                    ThreadRaporYazdir.Start();
                }
            }
        }

        static void UrunListele()
        {
            Console.WriteLine("Ürün Listeleniyor...");
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Ürünler - " + i.ToString());
                Thread.Sleep(1000);
            }
            Console.WriteLine("Ürünler Listendi! Enter tuşuna basınız...");
            Console.ReadLine();
        }

        static void RaporYazdır()
        {
            Console.WriteLine("Rapor Yazdırılıyor...");
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Rapor - " + i.ToString());
                Thread.Sleep(1000);
            }
            Console.WriteLine("Rapor Yazıldı! Enter tuşuna basınız...");
            Console.ReadLine();
        }
    }
}
