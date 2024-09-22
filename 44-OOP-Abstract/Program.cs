namespace _44_OOP_Abstract
{
    internal class Program
    {
        //Abstract Classlar sadece base class olarak davranmasını istediğimiz durumlarda (yani inherit edilebilmesi) kullanılır.
        //VE kendisinden INSTANCE (nesne oluşturulması) çıkartılmasını istemediğimiz durumlarda kullanılır.
        static void Main(string[] args)
        {
            Car car = new Car("BMW");
            Console.WriteLine(car.Brand);
            car.Calistir();

            Truck truck = new Truck("Volvo");
            Console.WriteLine(truck.Brand);
            truck.Calistir();

            List<Vehicle> vehicles = new List<Vehicle>() { car, truck };
        }
    }
}
