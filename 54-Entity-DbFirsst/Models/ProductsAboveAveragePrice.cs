using System;
using System.Collections.Generic;

namespace _54_Entity_DbFirsst.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
