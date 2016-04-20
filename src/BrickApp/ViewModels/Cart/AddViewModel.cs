using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;

namespace BrickApp.ViewModels.Cart
{
    public class AddViewModel
    {
        public CartItem CartItem { get; set; }
        public IEnumerable<Category> TopLevelCategories { get; set; }
    }
}