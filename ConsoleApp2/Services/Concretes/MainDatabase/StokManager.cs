using ConsoleApp2.Entities.Models.MainDatabase;
using ConsoleApp2.Repositories.Contracts;
using ConsoleApp2.Services.Contracts.MainDatabase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.Concretes.MainDatabase
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
