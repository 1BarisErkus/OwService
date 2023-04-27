using Entities.Models.UsDatabase;
using Repositories.Concretes.Context;
using Repositories.Contracts.UsDatabase;

namespace Repositories.Concretes.UsDatabase
{
    public class VStokRepository : UsDatabaseRepository<VStok>, IVStokRepository
    {
        public VStokRepository(UsDatabaseContext context) : base(context)
        {
        }
    }
}
