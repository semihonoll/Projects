// See https://aka.ms/new-console-template for more information
using _90_DP_Prototype;

Employee employee = new Employee();
employee.LoadData();

Console.WriteLine("Employee Nesnesi " + employee.GetHashCode());
foreach (var item in employee.GetEmpList())
{
    Console.WriteLine(item);
}

Employee employeeClone2 = (Employee)employee.Clone();
Console.WriteLine("\nEmployee Clone - 1 " + employeeClone2.GetHashCode());
foreach (var item in employeeClone2.GetEmpList())
{
    Console.WriteLine(item);
}

Employee employeeClone3 = (Employee)employee.Clone();
Console.WriteLine("\nEmployee Clone - 3 " + employeeClone3.GetHashCode());
foreach (var item in employeeClone3.GetEmpList())
{
    Console.WriteLine(item);
}

