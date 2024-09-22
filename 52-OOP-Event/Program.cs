namespace _52_OOP_Event
{
    internal class Program
    {
        //Event, Bir programda meydana gelen eylemlerdir.
        //Publisher: Eylemi başlatan (veya gönderen) sınıfa denir.
        //Subscriber: Eylemi alan (veya işleyen (handle)) sınıflara denir.

        //Publisher (Yayıncı) / Subscriber (Abone) pattern kullanmanız daha doğru olur. (Event/Delegate)
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.OnCreated += Email.Send;
            order1.OnCreated += SMS.Send;

            order1.Create();

            Order order2 = new Order();
            order2.OnCreated += Email.Send;
            order2.Create();
        }
    }
}
