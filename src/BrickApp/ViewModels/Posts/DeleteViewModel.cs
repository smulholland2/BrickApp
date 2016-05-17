using System;
using System.Collections.Generic;
using BrickApp.Models.BrickStore;
using System.ComponentModel.DataAnnotations;

namespace BrickApp.ViewModels.Posts
{
    public class DeleteViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Last Updated")]
        public DateTime LastUpdated { get; set; }
    }
}