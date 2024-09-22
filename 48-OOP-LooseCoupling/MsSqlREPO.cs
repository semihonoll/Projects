using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_OOP_LooseCoupling
{
    public class MsSqlREPO
    {
        public List<string> GetAllPersons()
        {
            return new List<string>();
        }

        public void CreatePerson(string person)
        {
            Console.WriteLine($"{person} adlı kişi eklendi.");
        }

        public void DeletePerson(string person) 
        {
            Console.WriteLine($"{person} adlı kişi silindi.");
        }

        public void UpdatePerson(string person)
        {
            Console.WriteLine($"{person} adlı kişi güncellendi.");
        }
    }
}
