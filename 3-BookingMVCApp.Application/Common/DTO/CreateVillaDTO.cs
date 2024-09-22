using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BookingMVCApp.Application.Common.DTO
{
    public class CreateVillaDTO
    {
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Range(10,10000)]
        public decimal Price { get; set; }
        public int Sqft { get; set; }
        [Range(1,10)]
        public int Occupancy { get; set; }
        public IFormFile Image { get; set; }
        public string? ImageUrl { get; set; }
    }
}
