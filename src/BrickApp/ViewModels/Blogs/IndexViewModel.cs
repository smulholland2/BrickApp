using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;
using System.ComponentModel.DataAnnotations;
using BrickApp.Models.Bricks;

namespace BrickApp.ViewModels.Blogs
{
    public class IndexViewModel
    {        
        public List<Blog> Blogs { get; set; }
        public List<Post> Posts { get; set; }
    }
}