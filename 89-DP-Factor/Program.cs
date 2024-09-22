using _89_DP_Factor;

internal class Program
{
    private static void Main(string[] args)
    {
        var gamePC1 = FactoryComputer.FactoryMethod("32", "1000", "i7", Model.GamePC);
        var gamePC2 = FactoryComputer.FactoryMethod("32", "1000", "i5", Model.GamePC);

        var officePC = FactoryComputer.FactoryMethod("16", "500", "i7", Model.OfficePC);

        Console.WriteLine($"Game PC-1: {gamePC1.ToString()}");
        Console.WriteLine($"Game PC-2: {gamePC2.ToString()}");
        Console.WriteLine($"Office PC-1: {officePC.ToString()}");
    }
}