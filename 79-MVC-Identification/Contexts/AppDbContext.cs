using _79_MVC_Identification.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _79_MVC_Identification.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
