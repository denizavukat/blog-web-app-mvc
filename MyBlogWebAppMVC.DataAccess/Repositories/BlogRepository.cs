
using MyBlogWebAppMVC.Domain.Models;
using System.Collections.Generic;

namespace MyBlogWebAppMVC.DataAccess.Repositories;

public class BlogRepository
{
    private List<Blog> blogs = new List<Blog>();

    public void AddBlog(Blog blog) => blogs.Add(blog);
        
    public IEnumerable<Blog> GetAllBlogs() => blogs;

    public Blog GetBlogById(int id) => blogs.Find(b => b.Id == id);
}