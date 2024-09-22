using _1_DependencyInversion.BadApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependencyInversion.BadApp
{
    public class OrderProcessor
    {
        private FileLogger _logger;

        public OrderProcessor()
        {
            _logger = new FileLogger();
        }

        public void Process(Order order)
        {
            //Proccess the order...
            //_logger.Log("Sipariş kargo verildi");
        }
    }
}
