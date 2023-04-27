using System;
using System.Threading.Tasks;
using VardabitService.Models.UsDatabase;

namespace ConsoleApp1.DatabaseOperations.Abstracts
{
    public interface IVStokService : IUsDatabaseService<VStok>
    {
        Task<VStok> GetVStok(string key);
    }
}
