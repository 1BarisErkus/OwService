using Entities.Models.MainDatabase;
using Repositories.Contracts;
using Services.Contracts.MainDatabase;

namespace Services.Concretes.MainDatabase
{
    public class StokManager : IStokService
    {
        private readonly IRepositoryManager _manager;

        public StokManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task<List<Stok>> GetAllAsync() => await _manager.Stok.GetAllAsync();
    }
}
