using csharpienumerablevsiqueryable;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (AppDbContext db = new(new DbContextOptionsBuilder().UseInMemoryDatabase("Products").Options))
        {
            db.Products.Add(new Product { Title = "Apple", Description = "iPhone 12", UnitPrice = 999 });
            db.Products.Add(new Product { Title = "Samsung", Description = "Galaxy S21", UnitPrice = 899 });
            db.Products.Add(new Product { Title = "Google", Description = "Pixel 5", UnitPrice = 699 });

            var result = await db.SaveChangesAsync();
            Debug.Assert(result == 3);
        }

        using (AppDbContext db = new(new DbContextOptionsBuilder().UseInMemoryDatabase("Products").Options))
        {
            //returnig IEnumerable problem - it is a parent of IQueryable !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            IEnumerable<Product> products = db.Products.Where(p => p.Title == "Apple");
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            foreach (var product in products)
            {
                Console.WriteLine($"Title: {product.Title} Description: {product.Description} UnitPrice: {product.UnitPrice}");
            }
        }
    }
}