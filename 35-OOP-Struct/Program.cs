namespace _35_OOP_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STRUCT: Değer Tipli: bellek üzerinde doğrudan veri saklar. Heap yerine Stack'de depolanır.

            //-Bellek Verimliliği, -Performans (data boyutu önemli), -Basit Verilerde tercih edilir.



            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 15;

            p1.Display();

            Point p2 = new Point(20, 39);
            p2.Display();
        }
    }
}
