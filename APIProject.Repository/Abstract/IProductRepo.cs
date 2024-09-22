using APIProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Repository.Abstract
{
    public interface IProductRepo
    {
        Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>>? filter = null);
        Task<Product> GetByIdAsync(int id);
        bool Any(Expression<Func<Product, bool>> filter);
        Product Create(Product product);
        Product Update(Product product);
        void Delete(Product product);
    }
}
