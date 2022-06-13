using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Car
    {
        public int Id { get; set; }
          [Required]
        public string Model { get; set; }
        [Required]

        public int Doors { get; set; }
        [Required]

        public int Seats { get; set; }
    

        public string Luggage { get; set; }
        [Required]

        public string Image { get; set; }
      
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool Transmission { get; set; }
        [Required]

        public bool AirConditiong { get; set; }

    }
}
