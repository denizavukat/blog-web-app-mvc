namespace MyBlogWebAppMVC.Domain.Models
{

    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Category { get; set; }
        public string? ImagePath { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}