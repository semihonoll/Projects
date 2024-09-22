using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProje2
{
    public class Officer : Person
    {
        private double officerHourlyWages = 500;
        public int OverTime { get; private set; }

        private double overWagesRate = 750;
        public double OverWages { get; private set; } 
        public Officer(string name, OfficerLevel level=OfficerLevel.junior) : base(name)
        {
            if (level == OfficerLevel.junior)
                overWagesRate *= 1;
            else if (level == OfficerLevel.midjunior)
                overWagesRate *= 1.5;
            else if (level == OfficerLevel.senior)
                overWagesRate *= 2;  
        }

        public override void CalculateSalary()
        {
            if (WorkingTime > 180)
            {
                OverTime = WorkingTime - 180;
                WorkingTime = 180;
                base.CalculateSalary();
                OverWages = OverTime * overWagesRate;
                TotalWages = MainWages + OverWages;
            }
            else
            {
                base.CalculateSalary();
            }
        }

        public override string ToString()
        {
            return $"\nPersonel Ismi: {Name} \nSaatlik Ucret: {HourlyWages} \nÇalışma Saati: {WorkingTime} \nAna Ucret: {MainWages} \nMesai Ücret: {OverWages} \nToplam Ücret: {TotalWages}";
        }
    }
}
