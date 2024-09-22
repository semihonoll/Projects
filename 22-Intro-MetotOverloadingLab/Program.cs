namespace _22_Intro_MetotOverloadingLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            


            //Maaş Bordro Programı
            Console.WriteLine("Maaş Hesaplama Programı");
            bool devaMi = true;

            while (devaMi) 
            {
                Console.Write("Çalışanın Ismi: ");
                string isim = Console.ReadLine();
                
                Console.Write("Saatlik Ücreti: ");
                double  sUcret = double.Parse(Console.ReadLine());

                Console.Write("Çalişma Süresi: ");
                double cSure = double.Parse(Console.ReadLine());

                //double tMaas;

                //if (MaasKontrolEt(sUcret, cSure, out tMaas) == true)
                //{
                //    Console.WriteLine("Maaş ödemesine hak kazandınız: ");
                //    Console.WriteLine("Maaşını: " + tMaas);
                //}
                //else
                //{
                //    Console.WriteLine("Maaş ödemesine hak kazanamadınız: ");
                //    Console.WriteLine("Maaş kazanmanın için gerekli miktar: " +(5000-tMaas)/cSure);
                //}


                Console.Write("Bonus Miktarı: ");
                double bMiktar = double.Parse(Console.ReadLine());

                Console.WriteLine("\n------------------------\n");

                if (bMiktar > 0)
                    Console.WriteLine("Maaşı: " + MaasHesapla(sUcret, cSure, bMiktar));
                else
                    Console.WriteLine("Maaşı: " + MaasHesapla(sUcret, cSure));
            }
        }

        static double MaasHesapla(double saatlikUcret, double calismaSuresi)
        {
            double ucret = saatlikUcret * calismaSuresi;
            return ucret;
        }

        static double MaasHesapla(double saatlikUcret, double calismaSuresi, double bonus)
        {
            double ucret = saatlikUcret * calismaSuresi;
            return ucret + bonus;
        }

        static bool MaasKontrolEt(double saatlikUcret, double calismaSuresi, out double toplamMaas)
        {
            double sonuc = saatlikUcret * calismaSuresi;
            if (sonuc > 5000)
            {
                toplamMaas = sonuc;
                return true;
            }
            else
            {
                toplamMaas = sonuc;
                return false;
            }

        }
    }
}
