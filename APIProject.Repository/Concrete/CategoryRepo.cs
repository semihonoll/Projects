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
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;

        public CategoryRepo(AppDbContext context)
        {
            _context = context;
        }

        public bool Any(Expression<Func<Category, bool>> filter)
        {
           return _context.Categories.Any(filter);
        }

        public Category Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void Delete(Category category)
        {
            var cat = _context.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (cat != null)
            {
                _context.Remove(cat);
                _context.SaveChanges();
            }
            else 
            {
                throw new NullReferenceException("Kategori nesnesi bulunamadı");
            }
        }

        public async Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>>? filter = null)
        {
            if (filter == null)
                return await _context.Categories.ToListAsync();
            else
                return await _context.Categories.Where(filter).ToListAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public Category Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}
