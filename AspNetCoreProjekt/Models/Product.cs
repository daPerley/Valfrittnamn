﻿using System.ComponentModel.DataAnnotations;

namespace AspNetCoreProjekt.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(5, 1000)]
        public decimal Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
