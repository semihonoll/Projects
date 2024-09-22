using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProje2
{
    public class Manager : Person
    {
        private readonly double bonus = 5000;
        public Manager(string name, double bonus) : base(name)
        {
            if (bonus > this.bonus)
                this.bonus = bonus;
        }

        public override void CalculateSalary()
        {
            HourlyWages = HourlyWages < 500 ? 500 : HourlyWages;

            base.CalculateSalary();
            TotalWages = MainWages + bonus;
        }

        public override string ToString()
        {
            return $"\nPersonel Ismi: {Name} \nSaatlik Ucret: {HourlyWages} \nÇalışma Saati: {WorkingTime} \nAna Ucret: {MainWages} \nBonus: {bonus} \nToplam Ücret: {TotalWages}";
        }
    }
}
