using ConsoleApp2.Services.Contracts;
using ConsoleApp2.Services.Contracts.MainDatabase;
using ConsoleApp2.Services.Contracts.UsDatabase;

namespace ConsoleApp2.Services.Concretes
{
    public class ServiceManager : IServiceManager
    {
        private readonly IStokService _stokService;
        private readonly IVStokService _vstokService;

        public ServiceManager(IStokService stokService, IVStokService vstokService)
        {
            _stokService = stokService;
            _vstokService = vstokService;
        }

        public IStokService StokService => _stokService;

        public IVStokService VStokService => _vstokService;
    }
}
