using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class Testimonial
    {
        [Key]
        [Required]
        public int TestimonialId { get; set; }
        [Required]
        public string Message { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
