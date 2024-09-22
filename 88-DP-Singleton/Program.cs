using _88_DP_Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        var nesne1 = EagerSingleton.GetInstance();

        var nesne2 = LazySingleton.GetInstance();

        var sample1 = SampleSingleton.Instance();
        sample1.Data = "First Instance";

        //Nesne üretmeye devam...
        var sample2 = SampleSingleton.Instance();
        var sample3 = SampleSingleton.Instance();

        Console.WriteLine("Object-1" + sample1.Data);
        Console.WriteLine("Object-2" + sample2.Data);
        Console.WriteLine("Object-3" + sample3.Data);

        if (sample1 == sample2 && sample2 == sample3 && sample1 == sample3) 
        {
            Console.WriteLine(sample1.GetHashCode());
            Console.WriteLine(sample2.GetHashCode());
            Console.WriteLine(sample3.GetHashCode());
            Console.WriteLine("Objects are the same instance");
        }
    }
}