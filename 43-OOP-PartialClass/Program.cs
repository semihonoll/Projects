namespace _43_OOP_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Isci isci = new Isci(1, "Fatih");

            Employee employee = new Employee(1, "Fatih");
            
            //Partial Class aynı assembly ve namespace altında olmalıdır.
        }
    }
}
