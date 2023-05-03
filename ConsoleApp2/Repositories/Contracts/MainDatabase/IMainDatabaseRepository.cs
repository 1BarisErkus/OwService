using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2.Repositories.Contracts.MainDatabase
{
    public interface IMainDatabaseRepository<T>
    {
        Task<List<T>> GetAllAsync();
    }
}
