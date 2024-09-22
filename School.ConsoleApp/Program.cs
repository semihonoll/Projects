using School.Manager.Entities;
using School.Manager.Enums;
using School.Manager.Services;

namespace School.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService();
            var personService = new PersonService();

            var student1 = new Student { Id = 0, FirstName = "Onur", LastName = "Anatça", Age = 38, Class = "YZL101" };

            var student2 = new Student { Id = 1, FirstName = "Mustafa", LastName = "Gökdemir", Age = 24, Class = "YZL101" };

            var student3 = new Student { Id = 2, FirstName = "Yunus", LastName = "Bulut", Age = 24, Class = "YZL101" };

            var person1 = new Person { Id = 0, FirstName = "Fatih", LastName = "Alkan", Age = 37, Position = Position.Manager };

            var person2 = new Person { Id = 1, FirstName = "Berkay", LastName = "Arslan", Age = 25, Position = Position.Security };

            //Öğrenci Ekleme
            studentService.Add(student1);
            studentService.Add(student2);
            studentService.Add(student3);
            Console.WriteLine("Öğrenciler eklendi...");

            //Öğrenci Listeleme
            Console.WriteLine("Tüm Öğrenciler");
            foreach (var item in studentService.GetAll())
            {
                Console.WriteLine(item.GetInformation());
            }

            //Oğrenci Silme
            Console.WriteLine("\n*********************\n");
            studentService.Delete(1);
            foreach (var item in studentService.GetAll())
            {
                Console.WriteLine(item.GetInformation());
            }

            //Öğrenci Güncelleme
            Console.WriteLine("\n**********************\n");
            Student newStudent = new Student() { FirstName = "Yunus Emre", LastName = "Bulut", Age = 24, Class = "YZL101" };
            studentService.Update(newStudent, 5);
            foreach (var item in studentService.GetAll())
            {
                Console.WriteLine(item.GetInformation());
            }
        }
    }
}
