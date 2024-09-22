using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95_DP_ChainOfResponsibilities
{
    public class TL50Dispenser : IDispenseChain
    {
        private IDispenseChain chain;

        public void dispense(Currency currency)
        {
            if (currency.getAmount() >= 50)
            {
                int num = currency.getAmount() / 50;
                int remainder = currency.getAmount() % 50;
                Console.WriteLine(num + " adet 50 TL verild.");
                if (remainder != 0)
                {
                    this.chain.dispense(new Currency(remainder));
                }
            }
            else 
            { 
                this.chain.dispense(currency);
            }
        }

        public void setNextChain(IDispenseChain nextChain)
        {
            this.chain = nextChain;
        }
    }
}
