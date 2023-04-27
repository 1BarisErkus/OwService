using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1.DatabaseOperations.Abstracts
{
    public interface IUsDatabaseService<T>
    {
        Task AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<List<T>> GetAllAsync();

        Task UpdateAsync(T entity);
    }
}
