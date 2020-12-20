using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyECommerce.Controllers.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateIpdated { get; set; } = DateTime.Now;

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}