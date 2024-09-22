using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95_DP_ChainOfResponsibilities
{
    public class Currency
    {
        private int amount;
        public Currency(int amt)
        {
            this.amount = amt;
        }

        public int getAmount()
        {
            return this.amount;
        }
    }
}
