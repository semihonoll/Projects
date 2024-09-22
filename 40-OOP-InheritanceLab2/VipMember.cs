using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_InheritanceLab2
{
    public class VipMember : Member
    {
        private string _notes;
        public VipMember() : base()
        {
            Console.WriteLine("Parametresiz Alt Yapıcı - VipMember");
        }

        public VipMember(int id, string name, string surname, int createDate, string notes) : base(id, name, surname, createDate)
        {
            Console.WriteLine("5 Parametreli Alt Yapıcı - VipMember");

            _notes = notes;   
        }

        //public void GetPrice(double unitPrice)
        //{
        //    _price = (unitPrice * 12) + 500;
        //}

        public override void GetPrice()
        {
            base.GetPrice();
            _price += 5000;
        }

        public void GetVipMember()
        {
            Console.WriteLine("VIP Member");
        }

    }
}
