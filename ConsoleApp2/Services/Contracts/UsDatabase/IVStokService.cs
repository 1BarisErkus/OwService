using ConsoleApp2.Entities.Models.UsDatabase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.Contracts.UsDatabase
{
    public interface IVStokService
    {
        Task AddAsync(VStok entity);

        Task DeleteAsync(VStok entity);

        Task<List<VStok>> GetAllAsync();

        Task<VStok> GetOneAsync(string key);

        Task UpdateAsync(VStok entity);
    }
}
