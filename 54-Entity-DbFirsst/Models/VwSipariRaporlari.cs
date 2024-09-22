using System;
using System.Collections.Generic;

namespace _54_Entity_DbFirsst.Models
{
    public partial class VwSipariRaporlari
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? TitleOfCourtesy { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? ContactName { get; set; }
        public string? Phone { get; set; }
        public string ProductName { get; set; } = null!;
        public short? UnitsInStock { get; set; }
        public string CategoryName { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}
