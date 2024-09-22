namespace _55_Entity_DbFirstRehber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Added
            //DbTelefonContext context = new DbTelefonContext();
            //context.Rehbers.Add(new Rehber() { Adi = "Beyazıt", Soyadi = "Alkan", Telefon = "554" });
            //context.Rehbers.Add(new Rehber() { Adi = "Onur", Soyadi = "Alkan", Telefon = "554" });
            //context.Rehbers.Add(new Rehber() { Adi = "Batuhan", Soyadi = "Alkan", Telefon = "554" });
            //context.Rehbers.Add(new Rehber() { Adi = "Gizem", Soyadi = "Alkan", Telefon = "554" });

            //context.SaveChanges();

            //context.Rehbers.Add(new Rehber() { Adi = "Merve", Soyadi = "Alkan", Telefon = "554" });
            //context.Rehbers.Add(new Rehber() { Adi = "Berkay", Soyadi = "Alkan", Telefon = "554" });

            //Console.WriteLine("Işlem başarılı");
            #endregion

            //LINQ (Language Integrated Query) C# programlama dilinde veri sorgulama ve manipülasyonu için kullanılan bir özelliktir.

            //IEnumerable ve IQueryable

            DbTelefonContext context = new DbTelefonContext();
            var rehbers = context.Rehbers.Where(x => x.Telefon == "554");
            foreach (var item in rehbers)
            {
                Console.WriteLine(item.Adi);
            }
        }
    }
}

