namespace _31_OOP_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sınıf: nesneler için bir şablondur (blueprint).
            //Nesne ise bir sınıfın örneğidir (üretimi).

            //Sınıf Üyeleri
            //Fields (Alanlar): Class içerisinde tanımlanan dışarıya kapalı değişkendir. Nesne oluşturulduğunda bu alanlar her bir nesnein örneği ayrı ayrı tutulur.
            //Properties (Özellikler):
            //Method (Metot):
            //Constructor (Yapıcı Metot):

            //Events
            //Destructor

            Araba x1001 = new Araba(); //Instance alma işlemi
            x1001.Marka = "TESLA";
            x1001.Model = "101";
            x1001.Renk = "Kırmızı";
            x1001.Hız = 80;

            Console.WriteLine($"Üretilen Araba Markası: {x1001.Marka} Modeli: {x1001.Model} Rengi: {x1001.Renk} Hızı: {x1001.Hız}");
            x1001.GazVer();

            Araba tr1001 = new Araba();
            tr1001.Marka = "TOGG";
            tr1001.Model = "T10x";
            tr1001.Renk = "Mavi";
            tr1001.Hız = 70;

            Console.WriteLine($"Üretilen Araba Markası: {tr1001.Marka} Modeli: {tr1001.Model} Rengi: {tr1001.Renk} Hızı: {tr1001.Hız}");

            tr1001.GazVer();
            tr1001.GazVer();
            tr1001.GazVer();
            tr1001.FrenYap();

            Person person1 = new Person();
            person1.Name = "Fatih";
            person1.SaatlikUcreti = -50;

            Console.WriteLine("Personelin Adı: " + person1.Name);
            Console.WriteLine("Personelin Saatlik Ücret: " + person1.SaatlikUcreti);

        }
    }

    public class Deneme { 
    
    }
}
