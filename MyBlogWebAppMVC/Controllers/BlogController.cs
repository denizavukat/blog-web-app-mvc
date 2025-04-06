using Microsoft.AspNetCore.Mvc;
using MyBlogWebAppMVC.Domain.Models;
using MyBlogWebAppMVC.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MyBlogWebAppMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string category)
        {
            var blogs = await _context.Blogs.ToListAsync();
            if (!string.IsNullOrEmpty(category))
            {
                blogs = blogs.Where(b => b.Category == category).ToList();
            }

            ViewBag.Categories = await _context.Blogs.Select(b => b.Category).Distinct().ToListAsync();

            return View(blogs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var blog = await _context.Blogs.Include(b => b.Comments).FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null)
                return NotFound();

            return View(blog);
        }
    }
}