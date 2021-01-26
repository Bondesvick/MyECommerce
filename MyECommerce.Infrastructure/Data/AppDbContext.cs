using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyECommerce.Core.Entities;

namespace MyECommerce.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new { pc.CategoryId, pc.ProductId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Product>(pc => pc.Product)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne<Category>(pc => pc.Category)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}