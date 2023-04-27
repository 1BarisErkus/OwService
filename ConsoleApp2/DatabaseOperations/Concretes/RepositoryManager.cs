using ConsoleApp1.DatabaseOperations.Abstracts;
using System.Threading.Tasks;
using VardabitService.DatabaseOperations.Abstracts;
using VardabitService.DatabaseOperations.Context;

namespace VardabitService.DatabaseOperations.Concretes
{
    public class RepositoryManager : IRepositoryService
    {
        private readonly UsDatabaseContext _context;
        private readonly IStokService _stokService;
        private readonly IVStokService _vstokService;

        public RepositoryManager(UsDatabaseContext context,
            IStokService stokService,
            IVStokService vstokService)
        {
            _context = context;
            _stokService = stokService;
            _vstokService = vstokService;
        }

        public IStokService StokService => _stokService;

        public IVStokService VstokService => _vstokService;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
