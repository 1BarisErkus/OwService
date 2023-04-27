using Repositories.Contracts.MainDatabase;
using Repositories.Contracts.UsDatabase;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IStokRepository Stok { get; }
        IVStokRepository VStok { get; }
        Task SaveVStokAsync();
    }
}
