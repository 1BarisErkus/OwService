using ConsoleApp2.Repositories.Concretes.Context;
using ConsoleApp2.Repositories.Contracts.MainDatabase;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Repositories.Concretes.MainDatabase
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
