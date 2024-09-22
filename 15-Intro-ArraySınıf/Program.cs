namespace _15_Intro_ArraySınıf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi üzerinde yeniden boyutlama, temizleme, sıralama, tersine cevirme gibi benzeri temel işlemleri yapmak için System.Array Sınıfı kullanılır.

            string[] ornekDizi = { "Istanbul", "Ankara", "Izmir", "Bursa", "Eskisehir", "Konya", "Trabzon", "Sivas", "Eskisehir" };

            #region Clear
            ////Diziden eleman silmek için kullanılır.
            //Array.Clear(ornekDizi, 2, 3);

            ////Dizinin tamamını temizleme
            //Array.Clear(ornekDizi);
            #endregion

            #region Copy
            //Bir diziden, başka bir diye eleman kopyalamak için kullanılır.
            //string[] yeniSehirler = new string[4];

            ////Array.Copy(ornekDizi, yeniSehirler, 4);

            //Array.Copy(ornekDizi, 3, yeniSehirler, 1, 2);

            #endregion

            #region IndexOf
            //Dizide aradığımız elemanın index numarasını bizde döndüren metotdır. Mevcut değilse -1, Eğer birden fazla varsa ilk bulduğunu.

            //Console.WriteLine("Sehir Girin: ");
            //string gelenDeger = Console.ReadLine();
            //int index = Array.IndexOf(ornekDizi, gelenDeger);

            //Console.WriteLine(index > 0 ? "Aradığınız şehir var " + index : " yok ");

            //index = Array.IndexOf(ornekDizi, "Eskisehir", 5);
            //Console.WriteLine(index);

            //index = Array.IndexOf(ornekDizi, "Eskisehir", 5, 2);
            #endregion

            #region LastIndexOf
            ////Dizide aradığımız elemanın index numarasını bize döndürür. Aramaya sondan başlar. 
            //index = Array.LastIndexOf(ornekDizi, "Eskisehir");
            //Console.WriteLine(index);
            #endregion

            #region Sort
            //Dizinizi sıralamak için kullanılır. A-Z doğru yapar.

            //Array.Sort(ornekDizi);

            //foreach (string sehir in ornekDizi)
            //{
            //    Console.WriteLine(sehir);
            //}

            #endregion

            #region Reverse
            //Dizinin elemanlarını tersine çevirmek için kullanılır.

            //Array.Reverse(ornekDizi);

            //foreach (string sehir in ornekDizi)
            //{
            //    Console.WriteLine(sehir);
            //}

            #endregion

            #region Resize()
            //ilkel dizinin eleman sayısını artırmak veya azaltmak için kullandığımı metottur.

            Array.Resize<string>(ref ornekDizi, 23);

            #endregion

            Console.WriteLine("");

            #region Ornek-1
            //Iceriğine sizin karar vereceğiniz bir sayısal dizi oluşturun ve bu dizinin en küçük ve en büyük elemanını ekrana yazdırınız.

            int[] sayilar = new int[10] { 20, 32, 12, 6, 48, 67, 13, 87, 9, 2 };
            Array.Sort(sayilar);
            int enKucukEleman = sayilar[0];
            int enBuyukEleman = sayilar[sayilar.Length-1];

            Console.WriteLine("En Küçük Eleman: {0} En Büyük Eleman: {1}", enKucukEleman, enBuyukEleman);

            #endregion

            #region Ornek-2
            //Kullanicidan alınan veri "kayıtlar" adlı diziye eklensin. Her yeni kayıtta dizinin boyutu bir arttırılsın. eleman eklendikten sonrada bilgi verilsin.

            bool devaMi = true;
            string[] kayitlar = new string[0];

            while (devaMi)
            {
                Console.Write("Eleman Giriniz: ");
                string veri = Console.ReadLine();

                Array.Resize(ref kayitlar, kayitlar.Length + 1);
                kayitlar[kayitlar.Length - 1] = veri;

                Console.WriteLine("{0}. eleman => {1}", kayitlar.Length - 1, veri);

                Console.WriteLine("Devam Mi? [False]");
                devaMi = Convert.ToBoolean(Console.ReadLine());
            }


            #endregion
        }
    }
}
