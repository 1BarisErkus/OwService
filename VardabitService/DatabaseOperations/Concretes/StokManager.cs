using ConsoleApp1.DatabaseOperations.Abstracts;
using ConsoleApp1.DatabaseOperations.Concretes;
using VardabitService.Models.MainDatabase;

namespace VardabitService.DatabaseOperations.Concretes
{
    public class StokManager : MainDatabaseManager<Stok>, IStokService
    {
        public StokManager(MainDatabaseContext context) : base(context)
        {
        }
    }
}
