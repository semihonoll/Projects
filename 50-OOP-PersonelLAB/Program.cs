using _50_OOP_PersonelLib.Concretes;

namespace _50_OOP_PersonelLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.Write("Deparman Adı Giriniz [IT-Soft]: ");
            string departmanAdi = Console.ReadLine();


            if (departmanAdi == "IT")
            {
                DepartmentIT departmentIT = new DepartmentIT(1, departmanAdi);
                company.AddDepartment(departmentIT);
            }
            else
            { 
                DepartmentSoftware departmentSoftware = new DepartmentSoftware(1, departmanAdi);
                company.AddDepartment(departmentSoftware);
            }

            foreach (var item in company.GetDepartments()) 
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
