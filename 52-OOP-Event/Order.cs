using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_OOP_Event
{
    //1-Delegate Tanımla
    public delegate void OrderEventHandler();
    public class Order
    {
        //2-Event Tanımla
        public event OrderEventHandler OnCreated;

        public void Create()
        {
            //Sipariş geldiği zaman çalışacak metodum...
            Console.WriteLine("Order Created");
            //Email.Send();
            //SMS.Send();

            //3-Event Çağırma
            if (OnCreated != null)
                OnCreated.Invoke();
        }
    }
}
