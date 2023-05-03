
using ConsoleApp2.Entities.Models.UsDatabase;
using ConsoleApp2.Repositories.Concretes.Context;
using ConsoleApp2.Repositories.Contracts.UsDatabase;

namespace ConsoleApp2.Repositories.Concretes.UsDatabase
{
    public class VStokRepository : UsDatabaseRepository<VStok>, IVStokRepository
    {
        public VStokRepository(UsDatabaseContext context) : base(context)
        {
        }
    }
}
