// See https://aka.ms/new-console-template for more information
using _95_DP_ChainOfResponsibilities;

Console.WriteLine("Hello, World!");
ATMDispenseChain aTMDispenseChain = new ATMDispenseChain();
while (true)
{
    int amaount = 0;
    Console.WriteLine("Çekmek istediğiniz miktar: ");
    amaount = Convert.ToInt32(Console.ReadLine());
    if (amaount % 10 != 0) 
    {
        Console.WriteLine("Tutar 10 nun katı olmalıdır.");
        return;
    }
    aTMDispenseChain.c1.dispense(new Currency(amaount));
}