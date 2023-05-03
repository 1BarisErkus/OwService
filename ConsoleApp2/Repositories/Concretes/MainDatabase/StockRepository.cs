using ConsoleApp2.Entities.Models.MainDatabase;
using ConsoleApp2.Repositories.Concretes.Context;
using ConsoleApp2.Repositories.Contracts.MainDatabase;

namespace ConsoleApp2.Repositories.Concretes.MainDatabase
{
    public class StockRepository : MainDatabaseRepository<Stok>, IStokRepository
    {
        public StockRepository(MainDatabaseContext context) : base(context)
        {
        }
    }
}
