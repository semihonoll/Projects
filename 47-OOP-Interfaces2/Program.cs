namespace _47_OOP_Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kaleci muslera = new Kaleci();
            Defans sabri = new Defans("Sabri", "55");
            Forvet icardi = new Forvet();

            IList<IFutbolcu> futbolcus = new List<IFutbolcu>();
            futbolcus.Add(muslera);
            futbolcus.Add(sabri);
            futbolcus.Add(muslera);
            

        }
    }
}
