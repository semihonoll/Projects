using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95_DP_ChainOfResponsibilities
{
    public class TL10Dispenser : IDispenseChain
    {
        private IDispenseChain chain;
        public void dispense(Currency currency)
        {
            if (currency.getAmount() >= 10)
            {
                int num = currency.getAmount() / 10;
                int remainder = currency.getAmount() % 10;
                Console.WriteLine(num + " Adet 10TL verildi.");
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
