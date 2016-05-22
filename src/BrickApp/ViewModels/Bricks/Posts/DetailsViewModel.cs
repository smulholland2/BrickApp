using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;
using BrickApp.Models.Bricks;

namespace BrickApp.ViewModels.Posts
{
    public class DetailsViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
        public IEnumerable<Blog> TopLevelCategories { get; set; }
        public List<WebsiteAd> CurrentAds { get; set; }
    }
}