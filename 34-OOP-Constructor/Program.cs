namespace _34_OOP_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car() { Model = "TOGG", Brand = "ASD" };

            Car car2 = new Car("Tesla");
            car2.Model = "X101";
            car2.Fuel = 200;

            Car car3 = new Car("", 200) { Model = "A3" };

            Console.WriteLine("");
        }
    }
}
