using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BrickApp.Models.Bricks;
using BrickApp.ViewModels.Blogs;
using System.Collections.Generic;

namespace BrickApp.Controllers
{
    public class BlogsController : Controller
    {
        private BrickContext _context;

        public BlogsController(BrickContext context)
        {
            _context = context;    
        }

        // GET: Blogs
        public async Task<IActionResult> Index()
        {
            List<Post> posts = _context.Posts.ToList();
            List<Blog> blogs = _context.Blogs.ToList();
            return View(new IndexViewModel
            {
                Blogs = blogs,
                Posts = posts
            });
        }

        // GET: Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Blog blog = await _context.Blogs.SingleAsync(m => m.BlogId == id);
            IEnumerable<Post> posts = _context.Posts.ToList().Where(p => p.BlogId == id);
            if (blog == null)
            {
                return HttpNotFound();
            }

            return View(new DetailsViewModel
            {
                Posts = posts,
                Category = blog.Category
            });
        }

        // GET: Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Blogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Blogs.Add(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Blog blog = await _context.Blogs.SingleAsync(m => m.BlogId == id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: Blogs/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Blog blog = await _context.Blogs.SingleAsync(m => m.BlogId == id);
            if (blog == null)
            {
                return HttpNotFound();
            }

            return View(blog);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Blog blog = await _context.Blogs.SingleAsync(m => m.BlogId == id);
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
