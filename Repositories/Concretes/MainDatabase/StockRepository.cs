using Entities.Models.MainDatabase;
using Repositories.Concretes.Context;
using Repositories.Contracts.MainDatabase;

namespace Repositories.Concretes.MainDatabase
{
    public class StockRepository : MainDatabaseRepository<Stok>, IStokRepository
    {
        public StockRepository(MainDatabaseContext context) : base(context)
        {
        }
    }
}
