namespace _37_OOP_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eğer nesneye bağımlı işlemler gerçekleştirmiyorsanız. - yani amaç sadece belirli bir duruma hizmet eden birden gazla öğeyi bir araya toplamak ise - ilgili sınıfı veya metodu,properties, gibi static olarak işaretleyebilirsiniz.
            //Instance'dan bağımsız olarak ulaşılabilir.

            //Static sınıflar içerisinden yalnızca static öğeler barındırabilirsiniz.

          
            Person.BilgiVer();
            Person.KatSayi = 50;

            Person person1 = new Person();
            person1.Name = "Fatih";
            person1.SurName = "Alkan";
            person1.MaasHesapla(500);


            Person person2 = new Person();
            person2.Name = "Mehmet";
            person2.SurName = "Öz";
            person2.MaasHesapla(1000);

            Console.WriteLine(person2.Count);

            //FizikKutuphanesi fizikKutuphanesi = new FizikKutuphanesi();
            //fizikKutuphanesi.CemberinAlani(200);

            FizikKutuphanesi.CemberinAlani(200);


            #region ExtensionMethod
            //Extension (Genişletme) Metotları, mevcut türlere (sınıflara) yeni metotlar eklemenizi sağlar.

            string sentence = "Hello extension methods in C#";
            //int wordCount = ExtensionMethod.WordCount(sentence);
            int wordCount = sentence.WordCount();
            Console.WriteLine($"Word Count: {wordCount}");

            DateTime birthDate = new DateTime(1987, 03, 31);
            int age = birthDate.CalculateAge();
            Console.WriteLine($"Age: {age}");
            #endregion

        }
    }
}
