using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95_DP_ChainOfResponsibilities
{
    public class ATMDispenseChain
    {
        public IDispenseChain c1;

        public ATMDispenseChain()
        {
            c1 = new TL50Dispenser();
            IDispenseChain c2 = new TL20Dispenser();
            IDispenseChain c3 = new TL10Dispenser();

            //Set next chain
            c1.setNextChain(c2);
            c2.setNextChain(c3);
        }
    }
}
