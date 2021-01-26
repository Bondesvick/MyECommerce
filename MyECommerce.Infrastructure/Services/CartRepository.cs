using MyECommerce.Core.Entities;
using MyECommerce.Core.Interfaces;
using MyECommerce.Infrastructure.Data;

namespace MyECommerce.Infrastructure.Services
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        public CartRepository(AppDbContext dataContext) : base(dataContext)
        {
        }
    }
}