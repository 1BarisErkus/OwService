using Microsoft.EntityFrameworkCore;
using Repositories.Concretes.Context;
using Repositories.Contracts.MainDatabase;

namespace Repositories.Concretes.MainDatabase
{
    public class MainDatabaseRepository<T> : IMainDatabaseRepository<T> where T : class
    {
        protected readonly MainDatabaseContext _context;
        public MainDatabaseRepository(MainDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
