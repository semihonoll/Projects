using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Class
{
    public class Person
    {
        //Field: Class içerisinde tanımlanan dışarıya kapalı değişkendir. Nesne oluşturulduğunda bu alanlar her bir nesnein örneği ayrı ayrı tutulur.
        private int id;

        //Properties: Class içerisinde tanımlanan dışarıya açık değişkendir. Field'lara erişimi yönetmek için kullanılır. Get ve Set metotolarını daha işlevsel hale getirerel.
        public string Name { get; set; }

        private double saatlikUcreti;

        //Encapsulation
        public double SaatlikUcreti
        {
            get { //Okuma
                return saatlikUcreti;
            }
            set { //Yazma
                if (value > 0)
                {
                    saatlikUcreti = value;
                }
                else
                {
                    saatlikUcreti = 100;
                    Console.WriteLine("Saatlik ücret 0 dan küçük olamaz. Minimum ücret 100 TL");
                }
            } 
        }
    }
}
