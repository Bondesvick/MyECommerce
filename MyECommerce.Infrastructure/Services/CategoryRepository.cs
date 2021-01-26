using MyECommerce.Core.Entities;
using MyECommerce.Core.Interfaces;
using MyECommerce.Infrastructure.Data;

namespace MyECommerce.Infrastructure.Services
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext dataContext) : base(dataContext)
        {
        }
    }
}