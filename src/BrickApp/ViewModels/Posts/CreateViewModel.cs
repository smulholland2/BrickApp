using System;
using System.Collections.Generic;
using BrickApp.Models.Bricks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.ViewModels.Posts
{
    public class CreateViewModel
    {               
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        [Display(Name = "Blog Category")]
        public int BlogId { get; set; }
        public IEnumerable<Blog> TopLevelCategories { get; set; }
    }
}