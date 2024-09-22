namespace _48_OOP_LooseCoupling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tightly Coupling (Sıkı Bağlantı)
            //MsSqlREPO msSqlREPO = new MsSqlREPO();
            //PostSqlREPO postSqlREPO = new PostSqlREPO();

            //Loose Coupling (Gevşek Bağlantı)
            IRepo newMsSqlRepo = new NewPostSqlRepo();

            Console.WriteLine("Eklemek istediğini kişinini adını giriniz: ");
            string adi = Console.ReadLine();
            //msSqlREPO.CreatePerson(adi);
            //postSqlREPO.CreatePersonPost(adi);
            newMsSqlRepo.CreatePerson(adi);

            Console.WriteLine("Güncelemek istediğiniz kişinin adını giriniz: ");
            adi = Console.ReadLine();
            //msSqlREPO.UpdatePerson(adi);
            //postSqlREPO.CreatePersonPost(adi);
            newMsSqlRepo.UpdatePerson(adi);

        }
    }
}
