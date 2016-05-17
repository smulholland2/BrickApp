using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BrickApp.Models.Bricks;
using BrickApp.ViewModels.Blogs;
using System.Collections.Generic;
using BrickApp.Models;

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
            List<Post> posts = _context.Posts.Where(p=> p.Status == Models.Status.Active).ToList();
            List<Blog> blogs = _context.Blogs.Where(b => b.Status == Models.Status.Active).ToList();
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

            Blog blog = await _context.Blogs.SingleAsync(b => b.BlogId == id);
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

            //Status data goes to a checkbox and needs to be converted to bool for the viewmodel
            bool Active = StatusHelper.ToBool(blog.Status);

            return View(new EditViewModel {
                BlogId = blog.BlogId,
                Active = Active,
                Category = blog.Category
            });
        }

        // POST: Blogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditViewModel formBlog)
        {
            if (ModelState.IsValid)
            {                
                //Status data from checkbox must be converted to Status enum
                Status status = StatusHelper.ToStatus(formBlog.Active);
                Blog blog = new Blog();
                blog.BlogId = formBlog.BlogId;
                blog.Category = formBlog.Category;                
                blog.Status = status;

                _context.Update(blog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }            

            return View(new EditViewModel
            {
                BlogId = formBlog.BlogId,
                Active = formBlog.Active,
                Category = formBlog.Category

            });
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
