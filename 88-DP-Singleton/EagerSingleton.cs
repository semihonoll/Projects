using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_DP_Singleton
{
    public class EagerSingleton
    {
        private static EagerSingleton instance;
        private EagerSingleton()
        {
                
        }

        public static EagerSingleton GetInstance()
        { 
            return instance;
        }
    }
}
