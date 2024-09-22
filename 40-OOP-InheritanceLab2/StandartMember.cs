using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_InheritanceLab2
{
    public class StandartMember : Member
    {
        public StandartMember(int id, string name, string surname, int date):base(id, name, surname, date)
        {
            
        }

        //public void GetPrice(double unitPrice)
        //{
        //    _price = unitPrice * 12;
        //}

        public override void GetPrice()
        {
            base.GetPrice();
        }

        public void GetStandartMember()
        {
            Console.WriteLine("Standart Member");
        }
    }
}
