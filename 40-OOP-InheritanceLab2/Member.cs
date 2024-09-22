using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_OOP_InheritanceLab2
{
    public class Member
    {
        //Fields
        private int _id;
        private string _name;
        private string _surname;
        private int _createDate;
        protected double _price;

        //Constructor
        public Member()
        {
            Console.WriteLine("Parametresiz Ana Yapıcı - Member Class");
        }

        public Member(int id, string name, string surname, int createDate)
        {
            Console.WriteLine("4 Parametreli Ana Yapıcı - Member Class");

            _id = id;
            _name = name;
            _surname = surname;
            _createDate = createDate;
        }

        public override string ToString()
        {
            return $"\nUye No: {_id} \nUye Adı: {_name} \nKayıt Tarihi: {_createDate} \nYıllık Ücret: {_price}";
        }

        public virtual void GetPrice()
        {
            _price = 500 * 12;
        }
    }
}
