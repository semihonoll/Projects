using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_OOP_LooseCoupling
{
    public class NewPostSqlRepo : IRepo
    {
        public void CreatePerson(string adi)
        {
            Console.WriteLine($"{adi} POST Sql ile kayıt edildi.");
        }

        public void DeletePerson(string adi)
        {
            throw new NotImplementedException();
        }

        public List<string> GetPersons()
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(string adi)
        {
            Console.WriteLine($"{adi} POST Sql ile kayıt edildi.");
        }
    }
}
