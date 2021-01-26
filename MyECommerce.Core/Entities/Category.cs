using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyECommerce.Core.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}