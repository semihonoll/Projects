using APIProject.Entities;
using APIProject.Repository.Context;
using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Service.Concrete
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _context;

        public DbInitializer(AppDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0) 
                { 
                    _context.Database.Migrate();
                }
                if (!_context.Categories.Any())
                {
                    _context.Categories.Add(new Category { Name = "Teknoloji" });
                    _context.Categories.Add(new Category { Name = "Sebze Meyve" });
                    _context.Categories.Add(new Category { Name = "Kırtasiye" });
                    _context.Categories.Add(new Category { Name = "Baklagil" });
                    _context.Categories.Add(new Category { Name = "Fırın ve Ocak" });
                    _context.SaveChanges();
                }
                if (!_context.Products.Any())
                {
                    for (int i = 0; i < 500; i++)
                    {
                        _context.Products.Add(
                            new Faker<Product>()
                            .RuleFor(P => P.CategoryId, f=> f.Random.Int(min: 1, max: 5) )
                            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                            .RuleFor(p => p.Price, f => double.Parse(f.Commerce.Price(0,100,2)))
                            .RuleFor(p => p.Stock, f => f.Random.Int(min: 0, max: 1000)));
                            
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
