namespace _45_OOP_AbstractLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gitar gitar1 = new Gitar();
            gitar1.Markasi = "Yamaha";
            gitar1.Modeli = "X53";

            Console.WriteLine($"Gitarın Markası: {gitar1.Markasi} Modeli: {gitar1.Modeli} Sesi: {gitar1.Cal()}");

            Batari batari1 = new Batari() { Markasi = "Ashton", Modeli = "Z34" };

            Console.WriteLine($"Baterinin Markası: {batari1.Markasi} Modeli: {batari1.Modeli} Sesi: {batari1.Cal()}");

            Keman keman1 = new Keman() { Markasi = "Stradivarius", Modeli = "S310" };

            Console.WriteLine($"Kemanın Markası: {keman1.Markasi} Modeli: {keman1.Modeli} Sesi: {keman1.Cal()}");

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Akın";
            muzisyen.Soyadı = "Temel";
            muzisyen.MuzikAleti = gitar1;

            Console.WriteLine($"Müzisyenin Adı: {muzisyen.Adi} Soyadı: {muzisyen.Soyadı} Çaldığı Müzik Aletinin Markası: {muzisyen.MuzikAleti.Markasi} Modeli: {muzisyen.MuzikAleti.Modeli} Sesi: {muzisyen.MuzikAleti.Cal()}");

            Muzisyen muzisyen1 = new Muzisyen() { Adi = "Onur", Soyadı = "Anatça", MuzikAleti = new Gitar() { Markasi = "Yamaha", Modeli = "Elektronik" } };

            Console.WriteLine($"Muzisyenin Adı: {muzisyen1.Adi} Soyadı: {muzisyen1.Soyadı} Çaldığı Müzik Aletinin Markası: {muzisyen1.MuzikAleti.Markasi} Modeli: {muzisyen1.MuzikAleti.Modeli} Sesi: {muzisyen1.MuzikAleti.Cal()}");

            Muzisyen muzisyen2 = new Muzisyen();
            muzisyen2.Adi = "Gülderen";
            muzisyen2.Soyadı = "Kara";
            muzisyen2.MuzikAleti = keman1;

            Console.WriteLine($"Muzisyenin Adı: {muzisyen2.Adi} Soyadı: {muzisyen2.Soyadı} Çaldığı Müzik Aletinin Markası: {muzisyen2.MuzikAleti.Markasi} Modeli: {muzisyen2.MuzikAleti.Modeli} Sesi: {muzisyen2.MuzikAleti.Cal()}");

            Muzisyen muzisyen3 = new Muzisyen();
            muzisyen3.Adi = "Okan";
            muzisyen3.Soyadı = "Avcı";
            muzisyen3.MuzikAleti = new Batari() { Markasi = "Asthorn", Modeli = "12A" };

            Console.WriteLine($"Muzisyenin Adı: {muzisyen3.Adi} Soyadı: {muzisyen3.Soyadı} Çaldığı Müzik Aletinin Markası: {muzisyen3.MuzikAleti.Markasi} Modeli: {muzisyen3.MuzikAleti.Modeli} Sesi: {muzisyen3.MuzikAleti.Cal()}");


            //Müzik Grubu
            Console.WriteLine("\n******************************\n");

            List<Muzisyen> liste1 = new List<Muzisyen> { muzisyen1, muzisyen2, muzisyen3 };

            MuzikGrubu muzikGrubu = new MuzikGrubu();
            muzikGrubu.Name = "Grup - 1";
            muzikGrubu.Muzisyens = new List<Muzisyen>
            {
                muzisyen1,
                muzisyen2,
                new Muzisyen()
                {
                    Adi="Fatih",
                    Soyadı="Alkan",
                    MuzikAleti = new Gitar()
                    {
                        Markasi="Telsiz Gitar",
                        Modeli="adas"
                    }
                }
            };

            //muzikGrubu.Muzisyens = liste1;

            //muzikGrubu.Muzisyens.Add(muzisyen1);
            //muzikGrubu.Muzisyens.Add(muzisyen2);
            //muzikGrubu.Muzisyens.Add(muzisyen3);

            Console.WriteLine($"Muzik Grubunun Adı: {muzikGrubu.Name}");
            foreach (Muzisyen item in muzikGrubu.Muzisyens)
            {
                Console.WriteLine($"Muzisyenin Adı: {item.Adi} Çaldığı Muzik Aleti: {item.MuzikAleti.Markasi}");
            }
        }
    }
}
