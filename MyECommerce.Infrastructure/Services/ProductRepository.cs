using MyECommerce.Core.Entities;
using MyECommerce.Core.Interfaces;
using MyECommerce.Infrastructure.Data;

namespace MyECommerce.Infrastructure.Services
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dataContext) : base(dataContext)
        {
        }
    }
}