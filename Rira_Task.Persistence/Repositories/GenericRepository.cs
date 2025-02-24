using Microsoft.EntityFrameworkCore;
using Rira_Task.Application.Contracts.Persistence;

namespace Rira_Task.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Rira_TaskDbContext _context;
        public GenericRepository(Rira_TaskDbContext context) { 
            _context = context;
        }  
        public async Task<T> Add(T Entity)
        {
           await _context.AddAsync(Entity);
            _context.SaveChanges();
            return Entity;
        }

        public async Task<bool> Delete(T Entity)
        {
            _context.Set<T>().Remove(Entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
          return await _context.Set<T>().FindAsync(id);                
        }

        public async Task<bool> IsExist(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<bool> Update(T Entity)
        {
            _context.Entry(Entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
