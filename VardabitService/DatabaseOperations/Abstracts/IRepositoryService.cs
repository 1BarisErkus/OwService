using ConsoleApp1.DatabaseOperations.Abstracts;
using System.Threading.Tasks;

namespace VardabitService.DatabaseOperations.Abstracts
{
    public interface IRepositoryService
    {
        IStokService StokService { get; }
        IVStokService VstokService { get; }
        Task SaveAsync();
    }
}
