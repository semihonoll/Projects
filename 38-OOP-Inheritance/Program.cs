namespace _38_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW",true);
            car.Brand = "BMW";
            car.Model = "i5";
            car.Color = "Kırmızı";
            car.ChildSeat = true;

            Truck truck = new Truck("Volvo");
            truck.Brand = "Volvo";
            truck.Model = "Y10";
            truck.Color = "Siyah";
            truck.MaxWeight = 100;

            List<Vehicle> cars = new List<Vehicle>();
            cars.Add(car);
            cars.Add(truck);
        }
    }
}
