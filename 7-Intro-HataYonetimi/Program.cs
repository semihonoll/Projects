namespace _7_Intro_HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Istisna Tipleri
             1-Derleme Zamanı: Tamemen yazılımcı kaynaklıdır. Kod yazımından (syntaxt) kaynaklanır. En kolay çözülen hata tipidir. Visual Studio kullanıyorsanız sizi detaylı bir şekilde bilgilendirecektir.

             2-Mantıksal Hatalar: Tamamen yazılımcı kaynaklıdır. Uygulamanın algoritmasından kaynaklı hatalar.

             3-Çalışma Zamanı Hataları: Çoğunlukla kullanıcı kaynaklı hatalardır. Çözüm yolu try-catch mekanizmasından geçer.
             */

            #region Ornek1
            //Kullanım-1
            //try
            //{
            //    //Bu alana hata riski olan kodlarınız yazılır.
            //    Console.WriteLine("Doğum Tarihini Giriniz: ");
            //    int dogumTarih = int.Parse(Console.ReadLine());
            //    int yas = 2024 - dogumTarih;
            //    Console.WriteLine("Yaşınız: {0}", yas);
            //}
            //catch
            //{
            //    //Try bloğunun içerisinde yazmış olduğumuz kodlarda herhangi bir hata meydana gelirse çalışır.
            //    Console.WriteLine("Doğum tarihinizi yanlış girdiniz. Lütfen tekrar deneyiniz.");
            //}

            //Kullanım-2
            //try
            //{
            //    //Bu alana hata riski olan kodlarınız yazılır.
            //    Console.WriteLine("Doğum Tarihini Giriniz: ");
            //    int dogumTarih = int.Parse(Console.ReadLine());
            //    int yas = 2024 - dogumTarih;
            //    Console.WriteLine("Yaşınız: {0}", yas);
            //}
            //catch (Exception hata)
            //{
            //    //Try bloğunun içerisinde yazmış olduğumuz kodlarda herhangi bir hata meydana gelirse çalışır.
            //    Console.WriteLine($"Tarih: {DateTime.Now} Hata Tipi: {hata.Message} Bir Hata Gerçekleşti");
            //    Console.WriteLine("Doğum tarihinizi yanlış girdiniz. Lütfen tekrar deneyiniz.");
            //}
            #endregion

            #region Ornek2
            try
            {
                Console.WriteLine("Karesi Alınacak Sayıyı Giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                int sonuc = sayi * sayi;
                Console.WriteLine("{0} Sayısının Karesi {1} dir", sayi, sonuc);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Doğru Formatta Giriş Yapmadın Lütfen Bir Sayı Giriniz.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Çüş biraz ufak at");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Diğer Hataları");
            }
            //Kullanmak zorunlu değil
            finally
            {
                Console.WriteLine("Ben ne olursa olsun hata gelsede/gelmesede çalışırım.");
            }
            #endregion

            #region ThrowAnahtarKelimesi
            //Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
            //int yas = Convert.ToInt32(Console.ReadLine());

            //if (yas>18) 
            //{
            //    Console.WriteLine("Geçerli Yaş: " + yas);
            //}
            //else
            //{
            //    throw new Exception("Yaş değeri 18 den büyük olmalıdır.");
            //}
            #endregion

            #region TryParse

            string userInput = "123";
            int number;

            //number = int.Parse(userInput);

            bool success = int.TryParse(userInput, out number);

            if (success) 
                Console.WriteLine("Dönüşüm Başarılı. Sayı: " + number);
            else
                Console.WriteLine("Dönüşüm Başarısız.");

            #endregion
        }
    }
}
