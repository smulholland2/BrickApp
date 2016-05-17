using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tags { get;  set;}
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public Status Status { get; set; }
    }
}
