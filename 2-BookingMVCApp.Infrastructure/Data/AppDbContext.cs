using _1_BookingMVCApp.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BookingMVCApp.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(new Villa
            {
                Id = 1,
                Name = "Royal Villa",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum porttitor semper. Fusce arcu justo, venenatis ac hendrerit ac, mollis a nisl. Vestibulum sagittis tellus justo, et hendrerit ligula vulputate eleifend. Duis mollis leo in augue malesuada, et congue purus elementum. Donec rutrum, erat nec pulvinar efficitur, odio sapien suscipit massa, id mattis libero massa rhoncus est. Suspendisse faucibus molestie posuere. Cras ut purus a urna fermentum dapibus. Pellentesque ut nibh mollis, venenatis ex sit amet, volutpat nisl. Maecenas elit tellus, cursus id placerat a, gravida vitae sem. Vestibulum vestibulum, tortor maximus dapibus ultricies, justo ligula tempor magna, eu aliquam sapien nunc vel nunc. Pellentesque a ullamcorper ligula. Cras nec finibus justo, non feugiat justo. Sed at tincidunt massa, a gravida neque. Curabitur ac rutrum mauris.",
                ImageUrl = "https://via.placeholder.com/600x400",
                Occupancy = 4,
                Price = 200,
                Sqft = 550
            },
                new Villa
                {
                    Id = 2,
                    Name = "Premium Royal Villa",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum porttitor semper. Fusce arcu justo, venenatis ac hendrerit ac, mollis a nisl. Vestibulum sagittis tellus justo, et hendrerit ligula vulputate eleifend. Duis mollis leo in augue malesuada, et congue purus elementum. Donec rutrum, erat nec pulvinar efficitur, odio sapien suscipit massa, id mattis libero massa rhoncus est. Suspendisse faucibus molestie posuere. Cras ut purus a urna fermentum dapibus. Pellentesque ut nibh mollis, venenatis ex sit amet, volutpat nisl. Maecenas elit tellus, cursus id placerat a, gravida vitae sem. Vestibulum vestibulum, tortor maximus dapibus ultricies, justo ligula tempor magna, eu aliquam sapien nunc vel nunc. Pellentesque a ullamcorper ligula. Cras nec finibus justo, non feugiat justo. Sed at tincidunt massa, a gravida neque. Curabitur ac rutrum mauris.",
                    ImageUrl = "https://via.placeholder.com/600x400",
                    Occupancy = 4,
                    Price = 300,
                    Sqft = 550
                }, new Villa
                {
                    Id = 3,
                    Name = "Luxury Royal Villa",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed dictum porttitor semper. Fusce arcu justo, venenatis ac hendrerit ac, mollis a nisl. Vestibulum sagittis tellus justo, et hendrerit ligula vulputate eleifend. Duis mollis leo in augue malesuada, et congue purus elementum. Donec rutrum, erat nec pulvinar efficitur, odio sapien suscipit massa, id mattis libero massa rhoncus est. Suspendisse faucibus molestie posuere. Cras ut purus a urna fermentum dapibus. Pellentesque ut nibh mollis, venenatis ex sit amet, volutpat nisl. Maecenas elit tellus, cursus id placerat a, gravida vitae sem. Vestibulum vestibulum, tortor maximus dapibus ultricies, justo ligula tempor magna, eu aliquam sapien nunc vel nunc. Pellentesque a ullamcorper ligula. Cras nec finibus justo, non feugiat justo. Sed at tincidunt massa, a gravida neque. Curabitur ac rutrum mauris.",
                    ImageUrl = "https://via.placeholder.com/600x400",
                    Occupancy = 4,
                    Price = 400,
                    Sqft = 750
                });
        }
    }
}
