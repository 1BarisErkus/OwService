using Services.Contracts;
using Services.Contracts.MainDatabase;
using Services.Contracts.UsDatabase;

namespace Services.Concretes
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
