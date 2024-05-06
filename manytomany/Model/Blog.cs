namespace csharpmanytomany.Model
{
    public class Blog
    {
        public Blog(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Navigation property
        public List<Post> Posts { get; set; } = new List<Post>();
    }
}