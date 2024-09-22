using _56_Entity_LINQ.Models;
using System.Data.SqlTypes;
using System.Net.Http.Headers;

namespace _56_Entity_LINQ
{
    internal class Program
    {
        static List<Department> departments = new List<Department>()
            {
                new Department() { Id=101, Name="Bilgisayar Mühendisliği" },
                new Department() { Id=102, Name="Makine Mühendisliği" }
            };

        static List<Student> students = new List<Student>()
            {
                new Student() { Id=1, Name="Okan", Age= 20, City="Antalya", DepartmentId=101 },
                new Student() { Id=2, Name="Onur", Age= 25, City="Antalya", DepartmentId=101 },
                new Student() { Id=3, Name="Yasin", Age= 27, City="Istanbul", DepartmentId=102 },
                new Student() { Id=4, Name="Gülderen", Age= 22, City="Istanbul", DepartmentId=102 },
                new Student() { Id=5, Name="Yasin", Age= 27, City="Istanbul", DepartmentId=102 },
                new Student() { Id=6, Name="Gizem", Age= 23, City="Istanbul", DepartmentId=101 }

            };
        static void Main(string[] args)
        {
            #region Select

            //MethodSyntax
            var selectResultMethod = students.Select(x => new { No = x.Id, Adi = x.Name });

            //var selectResultMethod = students.Select(x => new OgrenciDTO { No = x.Id, Adi = x.Name });

            foreach (var item in selectResultMethod)
            {
                Console.WriteLine($"Öğrenci No: {item.No} Öğrenci Adı: {item.Adi}");
            }

            //QuerySyntax
            var selectResult = from s in students select new { No = s.Id, Adi = s.Name };

            //var selectResult = from s in students select new OgrenciDTO { No = s.Id, Adi = s.Name };

            foreach (var item in selectResult)
            {
                Console.WriteLine($"Öğrenci No: {item.No} Öğrenci Adı: {item.Adi}");
            }

            #endregion

            Console.WriteLine("\n*******************************************************\n");

            #region Where
            //Method Syntax
            var filteredStudents = students.Where(x => x.City == "Istanbul" && x.Age > 20).Select(x => new OgrenciDTO { Adi = x.Name, No = x.Id });

            foreach (var item in filteredStudents)
            {
                Console.WriteLine($"Öğrenci No: {item.No} Öğrenci Adı: {item.Adi}");
            }

            //Query syntax
            var filteredStudents2 = from s in students where s.Age > 20 && s.City == "Istanbul" select s;

            #endregion

            Console.WriteLine("\n*******************************************************\n");

            #region OrderBy

            var studentsSorted = students.OrderBy(student => student.Name);
            //var studentsSorted = students.OrderByDescending(student => student.Name);

            foreach (var item in studentsSorted)
            {
                Console.WriteLine($"Öğrenci No: {item.Id} Adı: {item.Name}");
            }

            var studebtsSortedQ = from student in students orderby student.Name descending select student;

            #endregion

            Console.WriteLine("\n*******************************************************\n");

            #region GroupBy

            var groupedResult = students.GroupBy(s => s.City);

            var groupedResultQuery = from s in students group s by s.City;

            #endregion

            Console.WriteLine("\n*******************************************************\n");

            #region Join

            //Method Syntax

            var joinedData = students.Join(
                                        departments,
                                        s => s.DepartmentId,
                                        d => d.Id,
                                        (s, d) => new
                                        {
                                            StudentName = s.Name,
                                            StudentAge = s.Age,
                                            DepartmentName = d.Name
                                        });

            var joinedDataQuery = from s in students
                                  join d in departments
                                  on s.DepartmentId equals d.Id
                                  select new
                                  {
                                      StudentName = s.Name,
                                      StudentAge = s.Age,
                                      DepartmentName = d.Name
                                  };


            #endregion

            Console.WriteLine("\n*******************************************************\n");

            #region Any

            var resultAny = students.Any(x => x.Age > 25);

            Console.WriteLine($"Any: {resultAny}");

            var resultAll = students.All(x => x.Age > 25);

            Console.WriteLine($"All: {resultAll}");

            #endregion

            Console.WriteLine("\n*******************************************************\n");

            #region Contains

            var studentContains = new Student() { Id = 1, Name = "Okan", Age = 20, City = "Antalya", DepartmentId = 101 };
            Console.WriteLine(studentContains.GetHashCode());

            var resultContains = students.Contains(studentContains, new StudenEqualityComparer());

            Console.WriteLine($"Contains: {resultContains}");

            #endregion

            #region Average

            var averageAge = students.Average(x => x.Age);
            Console.WriteLine($"Average: {averageAge}");

            #endregion

            #region Count
            var totalStudents = students.Count();
            var adultStudents = students.Count(x => x.Age > 19);
            #endregion

            #region Max-Min
            var max = students.Max(x => x.Age);
            var min = students.Min(x => x.Age);
            #endregion

            #region Sum
            var sumOfAge = students.Sum(x => x.Age);

            var numOfAdults = students.Sum(s =>
                                                {
                                                    if (s.Age >= 18)
                                                        return 1;
                                                    else
                                                        return 0;
                                                });
            #endregion

            #region ElementElementOrDefault

            var studentElemen = students.ElementAt(2);

            var studentElementDef = students.ElementAtOrDefault(10);

            Console.WriteLine(studentElemen.Name);

            #endregion

            #region FirstFirstOrDefault

            var firsStudent = students.First(x => x.Name == "Yasin");

            var firsStudent2 = students.FirstOrDefault(x => x.Name.Contains("Yasin"));

            Console.WriteLine("");

            #endregion

            #region LastLastOrDefaul

            var lastStudent = students.Last(x => x.Name == "Yasin");
            var lastStudent2 = students.LastOrDefault(x => x.Name == "Yasin");

            #endregion

            #region SingleOrSinleOrDefault

            var singleStuden = students.Single(s => s.Name == "Onur");

            var singleStudent2 = students.SingleOrDefault(s => s.Name == "Mehmet");

            Console.WriteLine("");

            #endregion

            #region SkipSkipWhile

            var afterSkip = students.Skip(2).ToList();

            var afterSkipWhile = students.OrderBy(x => x.Age).SkipWhile(x => x.Age < 25).ToList();

            Console.WriteLine("");

            #endregion

            #region TakeTakeWhile

            var afterTake = students.Take(3).ToList();

            var afterTakeWhile = students.OrderBy(x => x.Age).TakeWhile(x => x.Age < 25).ToList();

            Console.WriteLine("");
            #endregion
            foreach (var item in GetByWhere(x => x.Name == "Yasin"))
            {
                Console.WriteLine(item.Name);
            }

        }

        public static List<Student> GetByWhere(Func<Student, bool> expression)
        {
            return students.Where(expression).ToList();  
        }

        int DenemeX()
        {
            return 2 * 5;
        }

        int Deneme => 2 * 5;
    }
}
