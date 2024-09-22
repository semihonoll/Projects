namespace _20_Intro_MetotLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //alkan@mail.com;fatih@mail.com,beyazit@mail.com;
            EkranaYaz(mail("alkan@mail.com;fatih@mail.com,beyazit@mail.com;senay@mail.com"));

            foreach (var item in mail2("alkan@mail.com;fatih@mail.com,beyazit@mail.com;senay@mail.com"))
            {
                Console.WriteLine(item);
            }

            //Kullanıcın girdiği bir metin içinde belirli bir kelimenin kaç kez geçtiğini bulan bir metot yapınız. cümle: Ali topu tututu ve ali topu attı. aranan kelime: ali sonuc:2

            Console.Write("Metin giriniz: ");
            string metin = Console.ReadLine();

            Console.Write("Aranacak Kelime: ");
            string arananKelime = Console.ReadLine();

            int sayac = KelimeSay(metin, arananKelime);
            Console.WriteLine($"{arananKelime} metnin için {sayac} kez var");
        }

        static string[] mail (string text) 
        {
            return text.Split(';', ',');
        }

        //Expression-Body Metot
        static string[] mail2(string text) => text.Split(';', ','); 

        static void EkranaYaz(string[] mailler)
        {
            foreach (string mail in mailler)
            {
                Console.WriteLine(mail);
            }
        }

        static int KelimeSay(string metin, string arananKelime)
        {
            int sayac = 0;
            int index = metin.IndexOf(arananKelime);

            while (index != -1) 
            {
                sayac++;
                index = metin.IndexOf(arananKelime, index + 1);
            }

            return sayac;
        }
    }
}
