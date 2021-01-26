using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyECommerce.Core.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        public int ProductId { get; set; }

        public DateTime DataCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;

        [Required]
        public int Quantity { get; set; }
    }
}