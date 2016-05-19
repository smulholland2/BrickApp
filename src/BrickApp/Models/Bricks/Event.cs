using BrickApp.Models.BrickStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrickApp.Models.Bricks
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Status Status { get; set; }
    }
}
