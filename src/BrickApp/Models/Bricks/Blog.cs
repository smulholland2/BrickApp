﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Category { get; set; }
        public Status Status { get; set; }
    }
}
