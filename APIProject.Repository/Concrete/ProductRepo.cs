using APIProject.Entities;
using APIProject.Repository.Abstract;
using APIProject.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Repository.Concrete
{
    public class ProductRepo : IProductRepo
    {
        private readonly AppDbContext _context;

        public ProductRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool Any(Expression<Func<Product, bool>> filter)
        {
            return _context.Products.Any(filter);
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            var pro = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if (pro != null)
            {
                _context.Products.Remove(pro);
                _context.SaveChanges();
            }
            else 
            {
                throw new NullReferenceException("Product nesnesi bulunamadı");
            }
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>>? filter = null)
        {
            if (filter == null)
                return await _context.Products.ToListAsync();
            else
                return await _context.Products.Where(filter).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public Product Update(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}
