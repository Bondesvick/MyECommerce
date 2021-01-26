using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyECommerce.Core.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        [Required]
        public int NumberAvailable { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}