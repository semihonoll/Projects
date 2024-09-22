using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _81_MVC_Role.Contexts
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Varsayılan
            //builder.Entity<IdentityRole>().HasData(new IdentityRole
            //{
            //    Name = "admin",
            //    NormalizedName = "ADMIN"
            //});

            //var adminUser = new IdentityUser
            //{
            //    UserName = "admin@admin.com",
            //    Email = "admin@admin.com",
            //    NormalizedEmail = "ADMIN@ADMIN.COM",
            //    NormalizedUserName = "ADMIN@ADMIN.COM",
            //    EmailConfirmed = true,
            //    LockoutEnabled = false,

            //};
        }
    }
}
