using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class Gallery
    {
        [Key]
        [Required]
        public int GalleryId { get; set; }
        [Required]
        public string GalleryName { get; set; }
    }
}
