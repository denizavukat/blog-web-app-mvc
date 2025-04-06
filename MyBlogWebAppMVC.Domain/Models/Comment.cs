namespace MyBlogWebAppMVC.Domain.Models
{
    
    public class Comment
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}

