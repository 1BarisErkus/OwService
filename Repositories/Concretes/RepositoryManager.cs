using Repositories.Concretes.Context;
using Repositories.Contracts;
using Repositories.Contracts.MainDatabase;
using Repositories.Contracts.UsDatabase;

namespace Repositories.Concretes
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly UsDatabaseContext _usDatabaseContext;
        private readonly IStokRepository _stokRepository;
        private readonly IVStokRepository _vstokRepository;

        public RepositoryManager(IStokRepository stokRepository,
            IVStokRepository vstokRepository,
            UsDatabaseContext usDatabaseContext)
        {
            _stokRepository = stokRepository;
            _vstokRepository = vstokRepository;
            _usDatabaseContext = usDatabaseContext;
        }

        public IStokRepository Stok => _stokRepository;

        public IVStokRepository VStok => _vstokRepository;

        public async Task SaveVStokAsync()
        {
            await _usDatabaseContext.SaveChangesAsync();
        }
    }
}
