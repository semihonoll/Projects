namespace _6_Intro_TernaryIFSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TernayIf

            //TernaryIF: If ifadesinin daha basit ve kısa sözdizimini temsil eder. *Genellikle bir koşulun sonucuna bağlı olara bir değişkene bir değer ataması yapmak istediğimizde kullanılır.

            //Syntax = Koşul ? doğruDurum : yanlisDurum
            int sayi = 3 > 2 ? 10 : 5;

            //Ornek Klasik If - Girilen değerin pozitif veya negatif olması
            //int deger1 = 10;
            //string sonuc1;

            //if (deger1 > 0) 
            //{
            //    sonuc1 = "Pozitif";
            //}
            //else
            //{
            //    sonuc1 = "Negatif";
            //}

            //Console.WriteLine(sonuc1);

            //TernaryIf 

            //sonuc1 = deger1 > 0 ? "Pozitif" : "Negatif";

            #endregion

            #region OrnekTernaryIf

            //Console.Write("Kullanici Adı: ");
            //string girilenDeger = Console.ReadLine();

            ////string sonuc2 = girilenDeger == "bilgeadam" ? "Doğru Giriş" : "Yanlış Giriş";
            //Console.WriteLine(girilenDeger == "bilgeadam" ? "Doğru Giriş" : "Yanlış Giriş");

            #endregion

            #region Switch - Case
            //IF-Else mantığıyla çalışan bir kontrol mekanizmasıdır. Aradaki fark ise if-else yapısı büyüklük-küçüklük gibi durumları kontrol ederken switch-case yalnızca eşitlik kontorül yapan durumulada kullanılabilir. 

            //Kendisine ait bir indez mekanizması ile koşulu algılar sıraya koyar ve otomatik olarak yüzlerce koşulunuz olsa bile her birine tek tek bakmadan doğru koşula gider.

            Console.WriteLine("1 [C#], 2 [VB], 3 [JAVA], 4 [HTML], 5 [CSS], 6 [Script]");
            Console.WriteLine("Lütfen bir dil seçiniz: ");
            int dil = int.Parse(Console.ReadLine());

            switch (dil) 
            {
                case 1:
                    Console.WriteLine("Seçim C#");
                    break;
                case 2:
                    Console.WriteLine("Seçim VB");
                    break;
                case 3:
                    Console.WriteLine("Seçim Java");
                    break;
                case 4:
                    Console.WriteLine("Seçim HTML");
                    break;
                case 5:
                    Console.WriteLine("Seçim CSS");
                    break;
                case 6:
                    Console.WriteLine("Seçim Script");
                    break;
                default:
                    Console.WriteLine("Senin seçimin...");
                    break;

            }

            #endregion

            #region SwitchCaseOrnek1
            Console.Write("Mevsim: ");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kis":
                    Console.WriteLine("Aralık-Ocak-Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("Mart-Nisan-Mayıs");
                    break;
                case "yaz":
                    Console.WriteLine("Haziran-Temmuz-Agustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Eylül-Ekim-Kasım");
                    break;
                default:
                    break;
            }

            #endregion

            #region Ornek3
            //Eğer Kullanıcı: Admin, Yonetici, CEO, Baskan gibi degerlere girerse Yönetimi Paneline Yönlendiriliyorsunuz...
            //Üye girilirse Ana sayfaya yönlendiriliyorsunuz.
            //HArici durumda ise bu siteye giriş yetkiniz yok.

            Console.WriteLine("Rol: ");
            string rol = Console.ReadLine();

            switch (rol)
            {
                case "admin":
                case "yonetici":
                case "ceo":
                case "baskan":
                    Console.WriteLine("Yönetim Paneline yönlendiriliyorsunuz");
                    break;
                case "uye":
                    Console.WriteLine("Ana sayfaya yönlendirliyorsunuz");
                    break;
                default:
                    Console.WriteLine("Sisteme giriş yetkiniz yok");
                    break;
            }

            #endregion
        }
    }
}
