// See https://aka.ms/new-console-template for more information
using _93_DP_Proxy;

Console.WriteLine("Hello, World!");

ICommandExecutor executor = new CommandExecutorProxy("admin", "1234");

executor.RunCommand("ls -ltr");
