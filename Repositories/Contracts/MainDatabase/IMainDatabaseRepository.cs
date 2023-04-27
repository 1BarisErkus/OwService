namespace Repositories.Contracts.MainDatabase
{
    public interface IMainDatabaseRepository<T>
    {
        Task<List<T>> GetAllAsync();
    }
}
