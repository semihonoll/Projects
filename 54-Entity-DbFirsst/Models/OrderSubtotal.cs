using System;
using System.Collections.Generic;

namespace _54_Entity_DbFirsst.Models
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
