using ConsoleApp2.Entities.Models.MainDatabase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Services.Contracts.MainDatabase
{
    public interface IStokService
    {
        Task<List<Stok>> GetAllAsync();
    }
}
