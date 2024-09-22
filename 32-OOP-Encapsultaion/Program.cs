namespace _32_OOP_Encapsultaion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation: Nesnenin üyelerine yapılan erişimin kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktır. AMAÇ: field'lara dışarıdan erişimi kontrollü bir şekilde yapmak.

            Person person1 = new Person();  //Instance   
            person1.SaatlikUcret = 250;
            person1.Adi = "Hüseyin";
            person1.Soyad = "Çetin";

            Console.WriteLine($"Personel Sicil No: {person1.SicilNo} Adı: {person1.TamAd}");
            person1.MaasHesapla(200);

            Person person2 = new Person();
            person2.SaatlikUcret = 350;
            person2.Adi = "Fatih";
            person2.Soyad = "Alkan";

            Console.WriteLine($"Personel Sicil No: {person2.SicilNo} Adı: {person2.TamAd}");
            person2.MaasHesapla(200);

            //Constructor (Yapıcı Metot)
            //Bir nesne oluşturulduğunda çağrılan özel bir metotur. Genellikli başlangıç verilerini ayarlamak için kullanılır.

            Person person3 = new Person();


        }
    }
}
