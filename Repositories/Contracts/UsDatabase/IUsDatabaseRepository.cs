namespace Repositories.Contracts.UsDatabase
{
    public interface IUsDatabaseRepository<T>
    {
        Task AddAsync(T entity);

        Task DeleteAsync(T entity);

        Task<List<T>> GetAllAsync();

        //Task<T> GetOneAsync(int id);

        Task UpdateAsync(T entity);
    }
}
