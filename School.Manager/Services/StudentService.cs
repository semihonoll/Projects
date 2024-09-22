using School.Manager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Manager.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _students;
        public StudentService()
        {
            _students = new List<Student>();
        }
        public void Add(Student entity)
        {
            _students.Add(entity);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="Exception"></exception>
        public void Delete(int id)
        {
            var oldStudent = GetById(id);
            if (oldStudent != null)
            {
                _students.Remove(oldStudent);
            }
            else
            {
                throw new Exception("Öğrenci bulunamadı...");
            }
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public void GetByClassName(string className)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            return _students[id];
        }

        public void Update(Student entity, int id)
        {
            var oldStudent = GetById(id);
            if (oldStudent is not null)
            {
                if (entity.FirstName is not null)
                    oldStudent.FirstName = entity.FirstName;
                if (entity.LastName is not null)
                    oldStudent.LastName = entity.LastName;
                oldStudent.Age = entity.Age;
                oldStudent.Class = entity.Class;
            }
            else
            {
                throw new Exception("Böyle bir personel bulunamadı.");
            }
        }
    }
}
