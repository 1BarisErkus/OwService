using ConsoleApp2.Services.Contracts.MainDatabase;
using ConsoleApp2.Services.Contracts.UsDatabase;

namespace ConsoleApp2.Services.Contracts
{
    public interface IServiceManager
    {
        IStokService StokService { get; }
        IVStokService VStokService { get; }
    }
}
