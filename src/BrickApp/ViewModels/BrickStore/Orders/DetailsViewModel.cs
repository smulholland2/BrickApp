using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;

namespace BrickApp.ViewModels.Orders
{
    public class DetailsViewModel
    {
        public Order Order { get; set; }
        public bool ShowConfirmation { get; set; }
    }
}