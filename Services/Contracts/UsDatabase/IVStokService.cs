using Entities.Models.MainDatabase;
using Entities.Models.UsDatabase;

namespace Services.Contracts.UsDatabase
{
    public interface IVStokService
    {
        Task AddAsync(VStok entity);

        Task DeleteAsync(VStok entity);

        Task<List<VStok>> GetAllAsync();

        //Task<T> GetOneAsync(int id);

        Task UpdateAsync(VStok entity);
    }
}
