using my_books.Data.Models;

namespace my_books.Data
{
    public class AppDbInitlialer
    {
        // This file initializes the database


        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            // scope for the application services
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                // Cehcking to see if we have any books in the database
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()

                    {
                        Title = "new Book title",
                        Description = "new Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-2),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "New Author",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    },
    new Book()

    {
        Title = "other Book title",
        Description = "other Book Description",
        IsRead = true,
        Genre = "Biography",
        Author = "New Author",
        CoverUrl = "https...",
        DateAdded = DateTime.Now
    });
                    context.SaveChanges();
                }
            }
        }
    }
}






