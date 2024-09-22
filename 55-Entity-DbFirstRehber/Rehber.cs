using System;
using System.Collections.Generic;

namespace _55_Entity_DbFirstRehber
{
    public partial class Rehber
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public string? Soyadi { get; set; }
        public string? Telefon { get; set; }
    }
}
