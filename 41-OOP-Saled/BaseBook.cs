using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_OOP_Saled
{
    public class BaseBook
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public virtual void GetLog()
        { 
            //...
        }
        public virtual void GetUser()
        { 
            //...
        }
    }
}
