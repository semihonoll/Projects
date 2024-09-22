namespace _40_OOP_InheritanceLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Fitness Üyelik Sistemi

            //Uye
            //-Ad, Soyad, Uyelik Tarihi, Yıllık Ücreti

            //VipUye - (600 * 12) + 5000
            //-Ad, Soyad, Uyelik Tarihi, Yıllık Ücreti

            //NormalUye - 600 * 12
            //-Ad, Soyad, Uyelik Tarihi, Yıllık Ücreti

            //Member member = new Member(1, "Fatih", "Alkan", 2024);
            //Console.WriteLine(member.ToString());

            //VipMember vipMember = new VipMember();
            Member member = new Member();

            VipMember vipMember1 = new VipMember(1, "Yasin", "Tanrıverdi", 2022, "Kilosu 80");
            VipMember vipMember2 = new VipMember(2, "Mehmet", "Yüksek", 2022, "Kilosu 70");

            StandartMember standart1 = new StandartMember(3, "Fatih", "Alkan", 2023);
            StandartMember standart2 = new StandartMember(4, "Zeynep", "Gül", 2023);
            StandartMember standart3 = new StandartMember(5, "Şenay", "Dal", 2023);

            Console.WriteLine("\n*****************************************\n");

            List<Member> members = new List<Member>() { vipMember1, vipMember2, standart1, standart2, standart3 };

            foreach (var item in members)
            {
                //Yontem-1 IS - AS Kullanımı
                if (item is VipMember)
                {
                    (item as VipMember).GetVipMember();
                }
                else
                {
                    (item as StandartMember).GetStandartMember();
                }

                //Yontem-2 GetType - typeof Kullanımı
                if (item.GetType() == typeof(VipMember))
                {
                    ((VipMember)item).GetVipMember();
                }
                else
                {
                    ((StandartMember)item).GetStandartMember();
                }

                item.GetPrice();
                Console.WriteLine(item.ToString());
            }

        }
    }
}
