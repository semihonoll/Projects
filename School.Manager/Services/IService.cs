using School.Manager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Services
{
    public interface IService<T> where T : BaseEntity  
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity, int id);
        void Delete(int id);
    }
}
