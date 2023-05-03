using ConsoleApp2.Repositories.Contracts.MainDatabase;
using ConsoleApp2.Repositories.Contracts.UsDatabase;
using System.Threading.Tasks;

namespace ConsoleApp2.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IStokRepository Stok { get; }
        IVStokRepository VStok { get; }
        Task SaveVStokAsync();
    }
}
