using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProje2
{
    public abstract class Person
    {
		private int workingTime;
        private double hourlyWages;

        public Person(string name)
        {
            Name = name;
        }

        public int WorkingTime
		{
			get { return workingTime; }
			set 
			{
				if (value > 0)
					workingTime = value;
				else
					throw new Exception("Çalışma süresi 0 dan küçük olamaz!");
			}
		}

		public double HourlyWages
		{
			get { return hourlyWages; }
			set 
			{
				if (value > 0)
					hourlyWages = value;
				else
					throw new Exception("Saatlik ücret 0 dan küçük olamaz!");
			}
		}
        public double MainWages { get; private set; }
        public double TotalWages { get; protected set; }
        public string Name { get; private set; }

		public virtual void CalculateSalary()
		{
			MainWages = workingTime * hourlyWages;
			TotalWages = MainWages;
		}

        public override string ToString()
        {
			return $"\nPersonel Ismi: {Name} \nSaatlik Ucret: {hourlyWages} \nÇalışma Saati: {workingTime} \nAna Ucret: {MainWages} \nToplam Ücret: {TotalWages}";
        }
    }
}
