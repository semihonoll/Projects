namespace _42_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia();
            nokia.Brand = "Nokia";
            nokia.Model = "3310";
            Console.WriteLine($"Telefon Marka: {nokia.Brand} Model: {nokia.Model}");
            nokia.CallSound();

            Samsung samsung = new Samsung();
            samsung.Brand = "Samsung";
            samsung.Model = "S7";
            Console.WriteLine($"Telefon Marka: {samsung.Brand} Model: {samsung.Model}");
            samsung.CallSound();

            Iphone iphone = new Iphone();
            iphone.Brand = "Apple";
            iphone.Model = "Iphone 14";
            Console.WriteLine($"Telefon Marka: {iphone.Brand} Model: {iphone.Model}");
            iphone.CallSound();
        }
    }
}
