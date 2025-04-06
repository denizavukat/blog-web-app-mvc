using Microsoft.EntityFrameworkCore;
using MyBlogWebAppMVC.Domain.Models; // Reference to your domain models

namespace MyBlogWebAppMVC.DataAccess
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Using SQLite for a local, cross-platform database
            optionsBuilder.UseSqlite("Data Source=blog.db");
        }
    }
}