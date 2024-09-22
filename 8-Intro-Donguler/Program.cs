namespace _8_Intro_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: Belirli bir kod bloğunu tekrarlı bir şekilde çalıştırma.
            //-While-DoWhile-For ve -Foreach (Diziler)

            //For Döngüsü: 
            //Belirli bir koşul sağlandığı sürece belirli bir kod bloğunu tekrar eder. Buradaki koşul genellikle belirli bir aralıktaki değerler üzerinden işlem yapmak veya belirli bir sayıda tekralanan işlemleri yapmak için kullanılır.

            //For Döngüsü Syntax
            /*
                for (baslangiDegeri; kosul; artisdegisimDegeri)
                {
                    //Döngü Bloğu
                    //Her döngüde çalıştırılcak kodlar. (Tekrar edilmesini istediğimiz kodları yazdığımız alan)
                }
            */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }

            //Iterasyon Kavarımı: Bir işlemin belirli adımlar halinde tekranalara gerçekleştirilmesidir.

            #region Ornek1
            for (int deger = 0; deger <= 100; deger += 2)
            {
                Console.WriteLine(deger);
            }

            for (int deger = 100; deger > 0; deger--)
            {
                Console.WriteLine(deger);
            }

            //for ( ; ; )
            //{
            //    Console.WriteLine("KD-21");
            //}

            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c + " - ASCI Kodu: " + Convert.ToInt32(c) );
            }
            #endregion

            #region Ornek2
            //1-100 arasındaki çift sayıların toplami ile tek sayıların toplamanın farklarının karesi kaçtır.

            int ciftlerinToplami=0, teklerinToplami=0;

            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlerinToplami += i;
                }
                else
                {
                    teklerinToplami += i;
                }
            }

            int sonuc = (ciftlerinToplami - teklerinToplami) * (ciftlerinToplami - teklerinToplami);

            Console.WriteLine("Sonuç: {0}", sonuc);
            #endregion

            // 1 x 1 = 1
            // 1 x 2 = 2
            // 1 x 3 = 3
            //....
            // 1 x 9 = 9

            // 2 x 1 = 1

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i*j}");
                }
            }
        }
    }
}
