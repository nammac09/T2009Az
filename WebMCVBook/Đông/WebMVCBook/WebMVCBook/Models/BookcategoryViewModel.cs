using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebMVCBook.Models
{
    public class BookcategoryViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Category { get; set; }
        public string BookCategory { get; set; }
        public string SearchString { get; set; }
    }
}
