using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BrickApp.Models.Bricks;

namespace BrickApp.ViewModels.Posts
{
    public class EditViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        [Display(Name = "Blog Category")]
        public int BlogId { get; set; }
        public IEnumerable<Blog> TopLevelCategories { get; set; }
    }    
}