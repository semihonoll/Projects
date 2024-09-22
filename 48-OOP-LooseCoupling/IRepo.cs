using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_OOP_LooseCoupling
{
    public interface IRepo
    {
        List<string> GetPersons();
        void CreatePerson(string adi);
        void DeletePerson(string adi);
        void UpdatePerson(string adi);
    }
}
