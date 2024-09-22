using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_OOP_Constructor
{
    public class Product
    {
        //Fields
        private string _id;
        private string _name;
        private double _price;
        private int _stock;
        private DateTime _created;
        private bool _status;

        //Constructor
        public Product()
        {
            _id = Guid.NewGuid().ToString().Substring(0, 5);
            _created = DateTime.Now;
        }

        //Properties
        public string Id //ReadOnly
        {
            get { return _id; }
            //private set { _id = value; }
        }

        public string Name //ReadWrite
        {
            get { return "KD21-" + _name; }
            set { _name = value.ToUpper(); }
        }

        public double Price
        {
            get { return _price; }
            set 
            { 
                if(value>0)
                    _price = value;
                else
                    throw new Exception("Ürünün Fiyatı 0 dan küçük olamaz.");
            }
        }

        public int Stock
        {
            get { return _stock; }
            set 
            {
                if (value > 0)
                    _stock = value;
                else
                    throw new Exception("Stok adetin 0 dan küçük olamaz.");
            }
        }

        public bool Status 
        {
            get => _status;
            set => _status = value;
        }

        //Methods
        public void StockAdd(int quantity)
        {
            _stock += quantity;
        }

        public void StockRemove(int quantity)
        {
            if (_stock > quantity)
            {
                _stock += quantity;
            }
            else
            {
                throw new Exception("Bu kadar adet stoğumuz bulunmamaktadır.");
            }
        }

    }
}
