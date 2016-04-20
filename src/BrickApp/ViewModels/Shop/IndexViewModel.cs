using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;

namespace BrickApp.ViewModels.Shop
{
    public class IndexViewModel
    {
        public IEnumerable<Product> FeaturedProducts { get; set; }
        public IEnumerable<Category> TopLevelCategories { get; set; }
    }
}