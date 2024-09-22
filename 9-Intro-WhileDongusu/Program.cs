namespace _9_Intro_WhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While: Mantıksal bir ifade gerçekleştiği sürece belli bir kod bloğonun tekrarlatılması istenildiği zaman tercih edilir.

            //Syntax
            //While (koşul true ise)
            //{
            //    tekrarlı bir şekilde çalışmasını istediğimiz kodlar.
            //}

            int a = 1;

            while (a < 10) 
            {
                Console.WriteLine("Merhaba KD-21");
                a++;
            }


            string durum = "yes";
            while (durum != "no")
            {
                Console.WriteLine("Döngünün içindesin");
                Console.WriteLine("Devam mı? [yes] [no]");
                durum = Console.ReadLine();
            }

            Console.WriteLine("Döngünün dışındasın");

        }
    }
}
