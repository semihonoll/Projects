namespace _36_OOP_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel() { Name = "Onur", SurName= "Anatça", Departman = Departmanlar.Yazilim };

            Personel personel2 = new Personel() { Name = "Berkay", SurName= "Arslan", Departman = Departmanlar.Sistem };


            Personel personel3 = new Personel() { Name = "Gülderen", SurName = "Kara", Departman = Departmanlar.Yazilim };

            Personel personel4 = new Personel() { Name = "Merve", SurName = "Çürük", Departman = Departmanlar.Test };

            Personel personel5 = new Personel() { Name = "Semih", SurName = "Önol", Departman = Departmanlar.IsSagligiGüvenliği };

            List<Personel> personels = new List<Personel>()
            { personel1, personel2, personel3, personel4, personel5 };

            foreach (var item in personels)
            {
                if (item.Departman == Departmanlar.Yazilim)
                {
                    Console.WriteLine($"Isim : {item.Name}");
                }
            }

        }
    }
}
