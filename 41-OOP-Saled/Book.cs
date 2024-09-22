using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Saled
{
    public class Book : BaseBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override void GetLog()
        {
            base.GetLog();
        }
        public sealed override void GetUser()
        {
            base.GetUser();
        }
    }
}
