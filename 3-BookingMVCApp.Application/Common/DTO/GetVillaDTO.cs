using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BookingMVCApp.Application.Common.DTO
{
    public class GetVillaDTO
    {
        [Display(Name = "No")]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Sqft { get; set; }
        public int Occupancy { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsAvailable { get; set; }
    }
}
