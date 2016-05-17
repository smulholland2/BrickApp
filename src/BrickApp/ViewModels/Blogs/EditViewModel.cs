using System;
using System.Collections.Generic;
using BrickApp.Models.Bricks;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.ViewModels.Blogs
{
    public class EditViewModel
    {

        public int BlogId { get; set; }
        [Display(Name = "Blog Name")]
        public string Category { get; set; }
        [Display(Name ="Active Blog")]
        public bool Active { get; set; }
    }
}