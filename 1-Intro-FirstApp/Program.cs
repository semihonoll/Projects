using System.Reflection.PortableExecutable;

namespace _1_Intro_FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Ilk Projem";

            //Console.Write("Merhaba ");
            //Console.WriteLine("Dünya");

            //Console.ForegroundColor = ConsoleColor.Red;

            //Console.Write("Isminiz Giriniz: ");

            //string isim = Console.ReadLine();

            //Console.BackgroundColor = ConsoleColor.Blue;

            //Console.Write("Hoşgeldin: ");
            //Console.WriteLine(isim);

            Person person1 = new Person() { FirstName = "Fatih", LastName = "Alkan", Age = 37 };
            Console.WriteLine(person1.GetHashCode());
            Person person2 = new Person() { FirstName = "Fatih", LastName = "Alkan", Age = 37 };
            Console.WriteLine(person1.GetHashCode());

            Console.WriteLine(person1.Equals(person2));

            //if (person1 == person2)
            //{
            //    Console.WriteLine("Aynı");
            //    Console.WriteLine("Person-1: " + person1.GetHashCode());
            //    Console.WriteLine("Person-3: " + person2.GetHashCode());
            //}
            //else
            //{
            //    Console.WriteLine("Aynı Değil");
            //    Console.WriteLine("Person-1: " + person1.GetHashCode());
            //    Console.WriteLine("Person-3: " + person2.GetHashCode());
            //}
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person other = (Person)obj;
            return FirstName == other.FirstName && LastName == other.LastName && Age == other.Age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, Age);
        }

    }
}
