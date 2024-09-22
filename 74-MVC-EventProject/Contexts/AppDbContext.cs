using _74_MVC_EventProject.Models;
using Microsoft.EntityFrameworkCore;

namespace _74_MVC_EventProject.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<AppEvent> AppEvents { get; set; }
        public DbSet<AppEventDetail> AppEventDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppEventDetail>().HasKey(ed => ed.EventId);
            modelBuilder.Entity<AppEvent>().HasOne(e => e.AppEventDetail).WithOne(ed => ed.AppEvent).HasForeignKey<AppEventDetail>(ed => ed.EventId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
