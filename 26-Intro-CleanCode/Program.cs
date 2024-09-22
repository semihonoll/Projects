namespace _26_Intro_CleanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Anlamlı isimlendirme: değişken ve metot isimleriniz açıklayıcı ve anlaşılır olmalı. Değişken tanımlarken ilkHarfKucukDigerBuyuk, Metot isimlendirme yaparken TumHarflerBuyukIleBaslasin

            int toplamFiyat = 0;
            int ToplamFiyatHesapla()
            {
                toplamFiyat = 1;
                return toplamFiyat;
            }

            //2-Girintili Biçimlendirme:Kodunu okunabilirliğini artırmak için doğru girintileme biçimlendirme kullanılmalıdır. Ctrl+K ve Ctrl + D
            if (true)
            {
                Console.WriteLine("Doğru Şartı");
            }
            else
            {
                Console.WriteLine("Yanlış Şartı");
            }

            if (true)
                Console.WriteLine("");
            else
                Console.WriteLine();

            //3-Single Responsibility (Tekil Sorumluluk Ilkesi): Bir metodun tek bir sorumluluğu olmalı. Böl Parçala Yönet

            void UrunEkle()
            {

            }

            void UrunSilme()
            {

            }

            //4-Kod Tekrarı yapamamaya çalış kullanmıyacağın bir değişkeni asla tanımlama
            int sayi1 = 5, sayi2 = 7, sonuc;

            sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplamı: " + sonuc);

            //Toplama işlemi yapar ve sonucu ekrana yazıdırı
            void Toplam(int sayi1, int sayi2)
            {
                int sonuc = sayi1 + sayi2;
                Console.WriteLine("Toplamı: " + sonuc);
            }

            //5-Hata yönetimi: doğru yerde doğru zamanda hata yönetimini gerçekleştirin.

            //6-Kullanıcı Doğru yönlendirmede bulunun:

            //if(kullaniciYetkisi == "Mudur") yerine
            //string yetki = "mudur" -> if (kullaniciYetkisi == yetki)

            //double kdv = 1.20;

            //500 * kdv;

            //7-Ternary If kullanının.

            //8-Metot Overloading


        }
    }
}
