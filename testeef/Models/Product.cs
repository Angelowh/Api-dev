using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace teste.Models
{

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
