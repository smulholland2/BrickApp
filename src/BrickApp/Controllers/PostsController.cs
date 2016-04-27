using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using BrickApp.Models.Bricks;
using BrickApp.ViewModels.Posts;
using System;

namespace BrickApp.Controllers
{
    public class PostsController : Controller
    {
        private BrickContext _context;

        public PostsController(BrickContext context)
        {
            _context = context;    
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            var brickContext = _context.Posts.Include(p => p.Blog);
            return View(await brickContext.ToListAsync());
        }

        // GET: Posts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Post post = await _context.Posts.SingleAsync(m => m.PostId == id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }

        // GET: Posts/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
                ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "Blog");
            else
                ViewData["BlogId"] = id;

            return View(new CreateViewModel
            {
                TopLevelCategories = _context.Blogs.ToList()//.Where(p => p.BlogId == id)
            });
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateViewModel formPost)
        {

            if (ModelState.IsValid)
            {
                Post post = new Post();
                post.BlogId = formPost.BlogId;
                post.PostId = formPost.PostId;
                post.Title = formPost.Title;
                post.Tags = formPost.Tags;
                post.Content = formPost.Content;
                post.DateCreated = DateTime.Now;
                post.LastUpdated = DateTime.Now;

                _context.Posts.Add(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "Blog", formPost.BlogId);

            return View(new CreateViewModel {
                TopLevelCategories = _context.Blogs.ToList()//.Where(p => p.BlogId == formPost.BlogId)
            });
        }

        // GET: Posts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Post post = await _context.Posts.SingleAsync(m => m.PostId == id);
            if (post == null)
            {
                return HttpNotFound();
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "Blog", post.BlogId);

            return View(new EditViewModel {
                PostId = post.PostId,
                Title = post.Title,
                Content = post.Content,
                DateCreated = post.DateCreated,
                LastUpdated = post.LastUpdated,
                Tags = post.Tags,
                BlogId = post.BlogId,
                TopLevelCategories = _context.Blogs.ToList()
            });
        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditViewModel formPost)
        {
            if (ModelState.IsValid)
            {
                Post post = new Post();
                post.BlogId = formPost.BlogId;
                post.PostId = formPost.PostId;
                post.Title = formPost.Title;
                post.Tags = formPost.Tags;
                post.Content = formPost.Content;
                post.LastUpdated = DateTime.Now;

                _context.Update(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["BlogId"] = new SelectList(_context.Blogs, "BlogId", "Blog", formPost.BlogId);
            return View(new EditViewModel
            {
                PostId = formPost.PostId,
                Title = formPost.Title,
                Content = formPost.Content,
                DateCreated = formPost.DateCreated,
                LastUpdated = formPost.LastUpdated,
                Tags = formPost.Tags,
                BlogId = formPost.BlogId,
                TopLevelCategories = _context.Blogs.ToList()
            });
        }

        // GET: Posts/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Post post = await _context.Posts.SingleAsync(m => m.PostId == id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post);
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Post post = await _context.Posts.SingleAsync(m => m.PostId == id);
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
