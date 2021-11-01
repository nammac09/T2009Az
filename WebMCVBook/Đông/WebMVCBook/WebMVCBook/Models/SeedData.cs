using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebMVCBook.Data;
using System;
using System.Linq;

namespace WebMVCBook.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new WebMVCBookContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebMVCBookContext>>());
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }

            context.Book.AddRange(
                new Book
                {
                    Title = "When Harry Met Sally",
                    Name = "Romantic Comedy",
                    Price = 7.99M,
                    Author = "Đông",
                    Category = "Vũ Trụ",
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Book.svg/1200px-Book.svg.png"
                },
                new Book
                {
                    Title = "When Harry Met Sally",
                    Name = "Romantic Comedy",
                    Price = 7.99M,
                    Author = "Đông",
                    Category = "Vũ Trụ",
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Book.svg/1200px-Book.svg.png"
                },
                new Book
                {
                    Title = "When Harry Met Sally",
                    Name = "Romantic Comedy",
                    Price = 7.99M,
                    Author = "Đông",
                    Category = "Vũ Trụ",
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Book.svg/1200px-Book.svg.png"
                },
                new Book
                {
                    Title = "When Harry Met Sally",
                    Name = "Romantic Comedy",
                    Price = 7.99M,
                    Author = "Đông",
                    Category = "Khoa Học",
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Book.svg/1200px-Book.svg.png"
                },
                new Book
                {
                    Title = " Sally",
                    Name = "Romantic Comedy",
                    Price = 7.99M,
                    Author = "Đông",
                    Category = "Vũ Trụ",
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Book.svg/1200px-Book.svg.png"
                },
                new Book
                {
                    Title = "When Harry Met Sally",
                    Name = "Romantic Comedy",
                    Price = 7.99M,
                    Author = "Đông",
                    Category = "Điện Ảnh",
                    Img = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/39/Book.svg/1200px-Book.svg.png"
                }
            );
            context.SaveChanges();
        }
    }
}