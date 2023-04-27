using ConsoleApp1.DatabaseOperations.Abstracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VardabitService.DatabaseOperations;

namespace ConsoleApp1.DatabaseOperations.Concretes
{
    public class MainDatabaseManager<T> : IMainDatabaseService<T> where T : class
    {
        protected readonly MainDatabaseContext _context;
        public MainDatabaseManager(MainDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
