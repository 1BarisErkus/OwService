using ConsoleApp1.DatabaseOperations.Abstracts;
using ConsoleApp1.DatabaseOperations.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using VardabitService.DatabaseOperations.Context;
using VardabitService.Models.UsDatabase;

namespace VardabitService.DatabaseOperations.Concretes
{
    public class VStokManager : UsDatabaseManager<VStok>, IVStokService
    {
        public VStokManager(UsDatabaseContext context) : base(context)
        {
        }

        public async Task<VStok> GetVStok(string key)
        {
            return await _context.VStoklar
            .Where(s => s.Name.Equals(key))
            .SingleOrDefaultAsync();
        }
    }
}
