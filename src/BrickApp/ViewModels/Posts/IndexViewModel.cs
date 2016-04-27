using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;

namespace BrickApp.ViewModels.Posts
{
    public class IndexViewModel
    {
        public int PostId { get; set; }
        public int MyProperty { get; set; }
        public IEnumerable<Category> TopLevelCategories { get; set; }
        public List<WebsiteAd> CurrentAds { get; set; }
    }
}