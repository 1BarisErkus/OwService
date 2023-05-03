using ConsoleApp2.Repositories.Concretes.Context;
using ConsoleApp2.Repositories.Contracts.UsDatabase;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Repositories.Concretes.UsDatabase
{
    public class UsDatabaseRepository<T> : IUsDatabaseRepository<T> where T : class
    {
        protected readonly UsDatabaseContext _context;

        public UsDatabaseRepository(UsDatabaseContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
                return await _context.Set<T>().ToListAsync();
        }

        //public async Task<T> GetOneAsync(int id)
        //{
        //    using (var _context = new UsDatabaseContext())
        //    {
        //        return await _context.Set<T>()
        //        .Where(s => s.Id.Equals(id))
        //        .SingleOrDefaultAsync();
        //    }
        //}

        public async Task UpdateAsync(T entity)
        {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
        }
    }
}
