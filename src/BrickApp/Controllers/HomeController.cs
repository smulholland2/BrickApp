using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using BrickApp.Models.BrickStore;
using BrickApp.ViewModels.Home;

namespace BrickApp.Controllers
{
    public class HomeController : Controller
    {
        private BrickStoreContext db;
        CategoryCache categoryCache;

        public HomeController(BrickStoreContext context, CategoryCache cache)
        {
            db = context;
            categoryCache = cache;
        }

        public IActionResult Index() 
        {
            var ads = db.WebsiteAds
                .Where(a => a.Start == null || a.Start <= DateTime.Now.ToUniversalTime())
                .Where(a => a.End == null || a.End >= DateTime.Now.ToUniversalTime());

            return View(new IndexViewModel
            {
                TopLevelCategories = categoryCache.TopLevel(),
                CurrentAds = ads.ToList()
            });
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}