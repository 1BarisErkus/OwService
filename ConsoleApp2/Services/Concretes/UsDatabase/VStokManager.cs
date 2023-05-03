using ConsoleApp2.Entities.Models.UsDatabase;
using ConsoleApp2.Repositories.Contracts;
using ConsoleApp2.Services.Contracts.UsDatabase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.Concretes.UsDatabase
{
    public class VStokManager : IVStokService
    {
        private readonly IRepositoryManager _manager;

        public VStokManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task AddAsync(VStok entity)
        {
            await _manager.VStok.AddAsync(entity);
            await _manager.SaveVStokAsync();
        }

        public async Task DeleteAsync(VStok entity)
        {
            await _manager.VStok.DeleteAsync(entity);
            await _manager.SaveVStokAsync();
        }

        public async Task<List<VStok>> GetAllAsync() =>
           await _manager.VStok.GetAllAsync();

        public Task<VStok> GetOneAsync(string key)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(VStok entity)
        {
            await _manager.VStok.UpdateAsync(entity);
            await _manager.SaveVStokAsync();

        }
    }
}
