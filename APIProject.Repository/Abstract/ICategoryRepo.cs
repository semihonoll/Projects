using APIProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Repository.Abstract
{
    public interface ICategoryRepo
    {
        Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>>? filter = null);
        Task<Category> GetByIdAsync(int id);
        bool Any(Expression<Func<Category, bool>> filter);
        Category Create(Category category);
        Category Update(Category category);
        void Delete(Category category);
    }
}
