using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class GalleryContent
    {
        [Key]
        [Required]
        public int GalleryContentId { get; set; }
        [Required]
        public string ContentType { get; set; }
        [Required]
        public string ContentUrl { get; set; }
        [Required]
        public int GalleryId { get; set; }
        public Gallery Gallery { get; set; }
    }
}
