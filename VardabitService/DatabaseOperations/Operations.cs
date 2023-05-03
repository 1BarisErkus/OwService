using ConsoleApp1.DatabaseOperations.Abstracts;
using VardabitService.DatabaseOperations.Concretes;
using VardabitService.DatabaseOperations.Context;
using VardabitService.Models.UsDatabase;

namespace VardabitService.DatabaseOperations
{
    public static class Operations
    {
        public async static void WriteOnDbForStok()
        {
            var mainDatabaseContext = new MainDatabaseContext();
            var usDatabaseContext = new UsDatabaseContext();
            var stokManager = new StokManager(mainDatabaseContext);
            var vstokManager = new VStokManager(usDatabaseContext);

            var stokDatas = await stokManager.GetAllAsync();

            for (int i = 0; i < stokDatas.Count; i++)
            {
                var obje = new VStok()
                {
                    //Id = stokDatas[i].Id,
                    Name = stokDatas[i].Name,
                    Amount = stokDatas[i].Price
                };

                var vData = await vstokManager.GetVStok(stokDatas[i].Name);
                if (vData != null)
                    continue;
                
                await vstokManager.AddAsync(obje);

            }
        }
    }
}
