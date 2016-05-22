using System;
using System.Collections.Generic;
using BrickApp.Models.Bricks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.ViewModels.Blogs
{
    public class DetailsViewModel
    {

        public string Category { get; set; }

        [Display(Name = "Blog Posts")]
        public IEnumerable<Post> Posts { get; set; }
    }
}