namespace _78_AsenkronProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartSchool();
            TeachClass12();
            TeachClass11();

            //var task = new Task(()=>GetRandomNumber());
            //task.Start();

            //Task.Run(() => GetRandomNumber());

            //Task.Factory.StartNew(() => GetRandomNumber());

            Console.ReadLine();

        }

        public static async Task StartSchool()
        {
            Console.WriteLine("Okul Başladı");
            await Task.Delay(8000);
            Console.WriteLine("Okul Bitti");
        }

        public static async Task TeachClass12()
        {
            Console.WriteLine("12. Sınıf Eğitime Başladı");
            await Task.Delay(3000);
            Console.WriteLine("12. Sınıf Eğitimi Bitti");
        }

        public static async Task TeachClass11()
        {
            Console.WriteLine("11. Sınıf Eğitime Başladı");
            await Task.Delay(2000);
            Console.WriteLine("11. Sınıf Eğitimi Bitti");
        }

        static int GetRandomNumber()
        {
            Thread.Sleep(1000);
            int randomNumber = (new Random()).Next(1,100);
            Console.WriteLine($"Rastgele Sayı: {randomNumber}");
            return randomNumber;
        }
    }
}
