using _87_API_JWTToken.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _87_API_JWTToken.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Person> Person { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().HasData(
                new Person 
                { 
                    Id=1,
                    FirstName = "Fatih",
                    LastName = "Alkan"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Hüseyin",
                    LastName = "Çetin"
                },
                new Person 
                { 
                    Id = 3,
                    FirstName = "Osman",
                    LastName = "Melih"
                },
                new Person 
                { 
                    Id = 4,
                    FirstName = "Şenay",
                    LastName = "Dalğıç"
                });

            base.OnModelCreating(builder);
        }
    }
}
