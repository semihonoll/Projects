using School.Manager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Services
{
    public class PersonService : IService<Person>
    {
        //readonly string deneme = "Beyazıt"; ilk oluşturulduğu anda veya nesne oluştuğu anda değer atanmak zorunda.
        //const int kdv; Sabit ilk oluşturulduğu anda değer atanmak zorunda.

        private readonly List<Person> _people;
        public PersonService()
        {
            _people = new List<Person>();
        }
        public void Add(Person entity)
        {
            try
            {
                _people.Add(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                if (_people.Count < id)
                    _people.RemoveAt(id);
                else
                    throw new Exception("Girilen değer liste boyutundan büyük");
            }
            catch
            {
                throw new Exception("Silme işlemi sırasında hata gerçekleşti.");
            }
        }

        public List<Person> GetAll()
        {
            if (_people != null)
                return _people;
            else
                throw new Exception("Personel listesi boş");
        }

        public Person GetById(int id)
        {
            return _people[id];
        }

        public void Update(Person entity, int id)
        {
            var oldPerson = GetById(id);
            if (oldPerson is not null) 
            { 
                if(entity.FirstName is not null)
                    oldPerson.FirstName = entity.FirstName;
                if (entity.LastName is not null)
                    oldPerson.LastName = entity.LastName;
                oldPerson.Age = entity.Age;
                oldPerson.Position = entity.Position;
            }
            else
            {
                throw new Exception("Böyle bir personel bulunamadı.");
            }
        }
    }
}
