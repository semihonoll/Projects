using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88_DP_Singleton
{
    public class SampleSingleton
    {
        private static SampleSingleton instance;

        private string data;

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private SampleSingleton()
        {
            
        }

        public static SampleSingleton Instance()
        { 
            if (instance == null)
                instance = new SampleSingleton();

            return instance;
        }
    }
}
