using _1_DependencyInversion.BadApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DependencyInversion.GoodApp
{
    public class OrderProcess
    {
        private readonly ILogger _logger;

        public OrderProcess(ILogger logger)
        {
            _logger = logger;
        }

        public void Process(Order order)
        {
            //Process the order...
            _logger.Log("Sipariş kargoya verildi...");
        }
    }
}
