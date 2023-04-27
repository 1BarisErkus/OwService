using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1.DatabaseOperations.Abstracts
{
    public interface IMainDatabaseService<T>
    {
        Task<List<T>> GetAllAsync();
    }
}
