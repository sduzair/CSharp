namespace csharpmanytomany.Model
{
    public class Post
    {
        public Post(string title, string body, int blogId, int userId)
        {
            Title = title;
            Body = body;
            BlogId = blogId;
            UserId = userId;
        }

        public int PostId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        // Foreign Key
        public int BlogId { get; set; }
        public Blog Blog { get; set; } = null!;

        // Foreign Key
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}