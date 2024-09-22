namespace _14_Intro_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Syntax veriTipi[] diziAdi = new veriTipi[diziBoyutu];

            //Bir dizi tanımlanırken ya eleman sayısını yada datasını vermek zorundasın.
            //Diziler Referans tiplidir.

            //1. Yontem
            string[] ogrenciler = { "fatih", "onur", "sezin", "yasin", "mehmet" };
            Console.WriteLine(ogrenciler[2]);


            //2. Yontem
            string[] students = new string[4];
            students[0] = "Hüseyin";
            students[1] = "Gülderen";
            students[2] = "Sefa";
            students[3] = "Melih";

            //3. Yontem
            int[] ages = new int[4] { 36, 24, 18, 23 };

            #region Ornek
            //Dizinin elemanlarına erişmek

            //string[] arabalar = { "Mercedes", "Ferrari", "Audi", "TOGG", "Tesla" };
            //Console.WriteLine(arabalar[2]);

            //for (int i = 0; i < arabalar.Length; i++)
            //{
            //    Console.WriteLine(arabalar[i]);
            //}

            //int[] fiyatlar = new int[4];
            //fiyatlar[0] = 360;
            //fiyatlar[1] = 240;
            //fiyatlar[2] = 270;
            //fiyatlar[3] = 290;

            //for (int i = 0; i < fiyatlar.Length; i++)
            //{
            //    Console.WriteLine("Eski Fiyat: " + fiyatlar[i] + " Yeni Fiyat " + (fiyatlar[i] * 1.10));
            //}

            #endregion

            #region ForEach

            //char[] mesaj = { 'M', 'e', 'r', 'h', 'a', 'b', 'a' };

            //for (int i = 0; i < mesaj.Length; i++)
            //{
            //    char item = mesaj[i];
            //    Console.WriteLine(item);
            //}

            //foreach (char eleman in mesaj)
            //{
            //    Console.Write(eleman);
            //}

            #endregion

            // 123, 54, 76, 786, 5432, 23, 77, 83, 654, 190 
            //Bu elemenaların kaçtanesi hem ikiye hemde üçe bölünebilen olduğunu yazınız.

            #region Ornek2
            // 123, 54, 76, 786, 5432, 23, 77, 83, 654, 190 
            //Bu elemenaların kaçtanesi hem ikiye hemde üçe bölünebilen olduğunu yazınız.

            //Console.WriteLine("Kaç adet rakam gireceksiniz: ");
            //int adet = int.Parse(Console.ReadLine());

            //int[] sayilar = new int[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine("Sayı: " + i);
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}

            //foreach (int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0 && sayi % 3 == 0)
            //    {
            //        Console.WriteLine("Hem ikiye Hem üçe bölünebilen sayı: " + sayi);
            //    }
            //}

            #endregion

            #region Ornek3

            //Console.WriteLine("Öğrenci Not Giriş Sistemi: ");
            //Console.Write("Kaç Adet Giriş Yapmak İstiyorsunuz: ");
            //int adet = int.Parse(Console.ReadLine());

            //string[] isimler = new string[adet];
            //double[] vizeler = new double[adet];
            //double[] finaller = new double[adet];

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.Write("Ogrenci Ismi: ");
            //    isimler[i] = Console.ReadLine();

            //    Console.Write("Vize Notu: ");
            //    vizeler[i] = Convert.ToDouble(Console.ReadLine());

            //    Console.Write("Final Notu: ");
            //    finaller[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //    double ortalama = (vizeler[i] * 0.3) + (finaller[i] * 0.70);
            //    string mesaj = ortalama > 50 ? "Geçtiniz" : "Kaldınız";
            //    Console.WriteLine($"Notunuz: {ortalama} Durum: {mesaj}");
            //}

            #endregion

            #region CokBoyutluDizi

            //object[] hersey = { 12, "deneme", 'a', true };
            //Console.WriteLine(hersey[0].ToString());

            int[] vizeler = { 30, 65, 75, 85 };
            int[] finaller = { 65, 35, 60, 70 };

            int[,] notlar = new int[,] { {30,65}, {65,35}, {75,60}, {85,70} };

            Console.WriteLine(notlar.Length);

            Console.WriteLine(notlar[2,1]);

            //Dizi içinde dizi

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 4 };
            jaggedArray[1] = new int[] { 2, 3 };
            jaggedArray[2] = new int[] { 3, 4, 5 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine("");
            }

            #endregion
        }
    }
}
