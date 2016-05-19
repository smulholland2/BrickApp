using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class Redirect
    {
        [Key]
        [Required]
        public int RedirectId { get; set; }
        [Required]
        public string OldUrl { get; set; }
        [Required]
        public string NewUrl { get; set; }
    }
}
