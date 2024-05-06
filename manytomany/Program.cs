using csharpmanytomany;
using csharpmanytomany.Model;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (AppDbContext db = new(new DbContextOptionsBuilder().UseInMemoryDatabase("blogs").Options))
        {
            var blog = new Blog("My First Blog", "My First Blog Description");
            db.Blogs.Add(blog);

            var user = new User("My First User");
            db.Users.Add(user);

            await db.SaveChangesAsync();
        }

        using (AppDbContext db = new(new DbContextOptionsBuilder().UseInMemoryDatabase("blogs").Options))
        {

            var blog = await db.Blogs.FirstOrDefaultAsync();
            var user = await db.Users.FirstOrDefaultAsync();


            var post1 = new Post("My First Post", "My First Post Body", blog!.BlogId, user!.Id);
            var post2 = new Post("My Second Post", "My Second Post Body", blog!.BlogId, user!.Id);

            db.Posts.Add(post1);
            db.Posts.Add(post2);
            await db.SaveChangesAsync();
        }

        using(AppDbContext db = new(new DbContextOptionsBuilder().UseInMemoryDatabase("blogs").Options)) 
        {
            //List<Blog> blogs = await db.Blogs.ToListAsync();
            List<Blog> blogs = await db.Blogs.Include(b => b.Posts).ThenInclude(p => p.User).ToListAsync();

            foreach (var item in blogs)
            {
                Console.WriteLine($"Blog: {item.Title}");
                foreach (var post in item.Posts)
                {
                    Console.WriteLine($"Post: {post.Title}, User: {post.User.Name}");
                }
            }
        }
    }
}