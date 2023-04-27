using Services.Contracts.MainDatabase;
using Services.Contracts.UsDatabase;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        IStokService StokService { get; }
        IVStokService VStokService { get; }
    }
}
