using CSProje2;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

            var persons = ReadJSon.Read("C:\\Users\\fatih.alkan\\source\\repos\\KD-21\\CSProje2\\persons.json");
            foreach (var person in persons)
            {
                Console.WriteLine($"Maaşı Hesaplanan Personel Ismi: {person.Name}");
                Console.WriteLine("Saatlik Ücreti: ");
                double saatlikUcret = double.Parse(Console.ReadLine());
                Console.WriteLine("Çalışma Süresi: ");
                int calismaSuresi = int.Parse(Console.ReadLine());

                if (person.Title == "Manager")
                {
                    Console.WriteLine("Bonus: ");
                    double bonus = double.Parse(Console.ReadLine());


                    listPerson.Add(new Manager(person.Name, bonus) { HourlyWages = saatlikUcret, WorkingTime = calismaSuresi });
                }
                else if (person.Title == "Officer")
                {
                    Console.WriteLine("Derece [1-Junior, 2-Mid, 3-Senior]: ");
                    int getLevel = int.Parse(Console.ReadLine());
                    listPerson.Add(new Officer(person.Name, ((OfficerLevel)getLevel)) { HourlyWages = saatlikUcret, WorkingTime = calismaSuresi });
                }
            }

            //...

            foreach (var item in listPerson)
            {
                if (item is Manager)
                {
                    var deneme = item as Manager;
                    deneme.CalculateSalary();
                    Console.WriteLine(deneme.ToString());
                }
                else
                {
                    var deneme = item as Officer;
                    deneme.CalculateSalary();
                    Console.WriteLine(deneme.ToString());
                }

            }
        }
    }
}
