using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyECommerce.Data;
using MyECommerce.Repositories.Interfaces;

namespace MyECommerce.Repositories.Services
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly AppDbContext DataContext;
        private readonly DbSet<T> _entitySet;

        protected BaseRepository(AppDbContext dataContext)
        {
            DataContext = dataContext;
            _entitySet = dataContext.Set<T>();
        }

        public async Task Delete(int? id)
        {
            if (await Exist(id))
            {
                var entity = await Find(id);
                DataContext.Remove(entity);
                await DataContext.SaveChangesAsync();
            }
        }

        public async Task<bool> Exist(int? id)
        {
            var entity = await _entitySet.FindAsync(id);
            return entity != null ? true : false;
        }

        public async Task<T> Find(int? id)
        {
            var entity = await _entitySet.FindAsync(id);
            return entity;
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _entitySet.ToListAsync();
        }

        public async Task<int> Count()
        {
            return await _entitySet.CountAsync();
        }

        public async Task Save(T t)
        {
            if (t != null)
            {
                await _entitySet.AddAsync(t);
                await DataContext.SaveChangesAsync();
            }
        }

        public async Task Update(T t)
        {
            if (t != null)
            {
                DataContext.Update(t);
                await DataContext.SaveChangesAsync();
            }
        }

        public async Task AddRange(T[] t)
        {
            await DataContext.AddRangeAsync(t);
            await DataContext.SaveChangesAsync();
        }
    }
}