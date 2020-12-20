using MyECommerce.Controllers.Models;
using MyECommerce.Data;
using MyECommerce.Repositories.Interfaces;

namespace MyECommerce.Repositories.Services
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dataContext) : base(dataContext)
        {
        }
    }
}