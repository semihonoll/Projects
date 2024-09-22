using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95_DP_ChainOfResponsibilities
{
    public interface IDispenseChain
    {
        void setNextChain(IDispenseChain nextChain);

        void dispense(Currency currency);
    }
}
