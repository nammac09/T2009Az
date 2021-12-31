using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM1_v2.Models
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category? Category { get; set; }
        [Required]
 
        public string? Name { get; set; }
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        [Required]
        [StringLength(30)]
        public string? Unit { get; set; }
    }
}
