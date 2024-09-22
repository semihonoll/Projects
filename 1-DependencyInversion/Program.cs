using _1_DependencyInversion.GoodApp;

namespace _1_DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OrderProcessor processor1 = new OrderProcessor();

            //OrderProcessor processor2 = new OrderProcessor();

            //OrderProcessor processor3 = new OrderProcessor();

            ILogger logger = new SqlLogger();

            OrderProcess process1 = new OrderProcess(logger);
            
            OrderProcess process2 = new OrderProcess(logger);

            OrderProcess orderProcess = new OrderProcess(logger);

        }
    }
}
