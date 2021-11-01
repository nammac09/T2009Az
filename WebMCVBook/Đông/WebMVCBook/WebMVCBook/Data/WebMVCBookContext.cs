using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMVCBook.Models;

namespace WebMVCBook.Data
{
    public class WebMVCBookContext : DbContext
    {
        public WebMVCBookContext (DbContextOptions<WebMVCBookContext> options)
            : base(options)
        {
        }

        public DbSet<WebMVCBook.Models.Book> Book { get; set; }
    }
}
