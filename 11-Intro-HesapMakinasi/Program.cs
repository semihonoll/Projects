namespace _11_Intro_HesapMakinasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler, Operatörler ve Tip Dönüşümü
            #region Proje-1
            //Kullanıcıdan iki sayı isteyeceksniz bu sayıların Toplamını, Farkını, Carpimini ve Bölümünü ekrana yazdıracaksın.

            //Console.WriteLine("Basit Bir Hesap Makinası Programı");

            //double firstNum, secondNum, result;

            //Console.WriteLine("Lütfen Sayı 1 Giriniz: ");
            //firstNum = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen Sayı 2 Giriniz: ");
            //secondNum = Convert.ToDouble(Console.ReadLine());

            //result = firstNum + secondNum;
            //Console.WriteLine($"Toplamı: {result}");

            //result = firstNum - secondNum;
            //Console.WriteLine("Farkı: {0}", result);

            //result = firstNum * secondNum;
            //Console.WriteLine("Çarpımı: " + result);

            //Console.WriteLine("Bölümü: " + (firstNum/secondNum).ToString());

            #endregion

            //Karar Yapıları
            //+ Toplama, - Fark, * Carpım, / Bölme
            #region Proje-2

            //Console.WriteLine("Basit Bir C# Hesap Makinası");
            //Console.WriteLine("İşlem Seçimleri: [ + | - | * | / ] Çıkış yapmak için boş geçiniz.");

            //double firstNum, seconNum, result = 0;
            //string mathOp;

            //Console.WriteLine("Sayı 1: ");
            //firstNum = double.Parse(Console.ReadLine());

            //Console.WriteLine("Sayı 2: ");
            //seconNum = double.Parse(Console.ReadLine());

            //Console.WriteLine("Islem: ");
            //mathOp = Console.ReadLine();

            //if (mathOp != string.Empty)
            //{
            //    switch (mathOp) 
            //    {
            //        case "+":
            //            result = firstNum + seconNum;
            //            Console.WriteLine("Toplamı: " + result);
            //            break;
            //        case "-":
            //            result = firstNum - seconNum;
            //            Console.WriteLine("Farkı: " + result);
            //            break;
            //        case "*":
            //            result = firstNum * seconNum;
            //            Console.WriteLine("Carpimi: " + result);
            //            break;
            //        case "/":
            //            result = firstNum / seconNum;
            //            Console.WriteLine("Bölüm: " + result);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Islem Yapılamadı!");
            //}

            #endregion

            //Try-Catch ve Döngüler
            #region Proje-3

            Console.WriteLine("Basit Bir C# Hesap Makinası");
            Console.WriteLine("Işlemler: [ + | - | * | / ] Çıkış yapmak için boş geçiniz.");

            double firstNum=0, secondNum=0, result = 0;
            string mathOp="+";

            while (mathOp != string.Empty)
            {
                try
                {
                    Console.WriteLine("Say 1: ");
                    firstNum = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Say 2: ");
                    secondNum = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Islem: ");
                    mathOp = Console.ReadLine();
                }
                catch (Exception)
                {
                    //Console.WriteLine("Yanlış bir giriş yaptınız tekrar deneyiniz.");
                    Console.WriteLine("Üzgünüm yanlış giriş yaptınız.");
                    mathOp = string.Empty;
                }

                //Dört İşlem...
                switch (mathOp)
                {
                    case "+":
                        result = firstNum + secondNum;
                        Console.WriteLine("Toplamı: " + result);
                        break;
                    case "-":
                        result = firstNum - secondNum;
                        Console.WriteLine("Farkı: " + result);
                        break;
                    case "*":
                        result = firstNum * secondNum;
                        Console.WriteLine("Carpimi: " + result);
                        break;
                    case "/":
                        result = firstNum / secondNum;
                        Console.WriteLine("Bölüm: " + result);
                        break;
                    default:
                        Console.WriteLine("Üzgünüm yanlış giriş");
                        mathOp = string.Empty;
                        break;
                }
            }

            Console.WriteLine("Program Kapandı.");
            #endregion
        }
    }
}
