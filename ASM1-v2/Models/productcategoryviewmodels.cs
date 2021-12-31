using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASM1_v2.Models
{
    public class productcategoryviewmodels
    {
        public List<Product>? Products { get; set; }
        public SelectList? Category { get; set; }
        public SelectList? Price { get; set; }
        public int? ProCategory { get; set; }
        public int? ProPrice { get; set; }
        public string? SearchString { get; set; }
    }
}
