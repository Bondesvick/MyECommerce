using MyECommerce.Core.Entities;
using MyECommerce.Core.Interfaces;
using MyECommerce.Infrastructure.Data;

namespace MyECommerce.Infrastructure.Services
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(AppDbContext dataContext) : base(dataContext)
        {
        }
    }
}