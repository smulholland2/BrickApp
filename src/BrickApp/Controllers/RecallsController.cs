using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using System.Linq;
using BrickApp.Models.BrickStore;

namespace BrickApp.Controllers
{
    public class RecallsController : Controller
    {
        private BrickStoreContext db;

        public RecallsController(BrickStoreContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            var recalls = db.Recalls
                .Include(r => r.Product)
                .ToList();

            return View(recalls);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Recall recall)
        {
            if (ModelState.IsValid)
            {
                db.Recalls.Add(recall);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recall);
        }
    }
}
