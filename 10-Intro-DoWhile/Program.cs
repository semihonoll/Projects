namespace _10_Intro_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Do-While: tamamen while döngüsü gibi çalışır. Aralarında ki tek fark while döngü deyimi içerisindeki kontrol, döngüye girilmeden önce yapılırken; do while döngüsünde bu kontrol ilk döngü bloğundan çıkıldıktan sonra yapılmaya başlar.

            //string durum = "yes";
            //do
            //{
            //    Console.WriteLine("Döngünün İçindesin");
            //    Console.WriteLine("Devam mı? [yes] [no]");
            //    durum = Console.ReadLine();
            //} while (durum != "no");

            //Ornek

            string userName = "";
            string userPass = "";

            do
            {
                Console.WriteLine("Kullanıcı Adı: ");
                userName = Console.ReadLine();
                Console.WriteLine("Kullanıcı Şifre: ");
                userPass = Console.ReadLine();
            } while (userName != "admin" || userPass != "123");

            Console.WriteLine("Hoş geldin Admin:");
        }
    }
}
