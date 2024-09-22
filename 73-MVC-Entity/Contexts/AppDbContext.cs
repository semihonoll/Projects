using _73_MVC_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace _73_MVC_Entity.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
