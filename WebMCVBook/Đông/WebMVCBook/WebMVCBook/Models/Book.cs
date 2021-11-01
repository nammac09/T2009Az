using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMVCBook.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        public string Img { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        [Range(1, 100)]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
