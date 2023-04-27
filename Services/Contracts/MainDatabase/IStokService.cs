using Entities.Models.MainDatabase;

namespace Services.Contracts.MainDatabase
{
    public interface IStokService
    {
        Task<List<Stok>> GetAllAsync();
    }
}
