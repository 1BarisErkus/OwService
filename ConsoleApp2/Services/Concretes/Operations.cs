using ConsoleApp2.Entities.Models.UsDatabase;
using ConsoleApp2.Repositories.Concretes.Context;
using ConsoleApp2.Services.Contracts;
using ConsoleApp2.Services.Contracts.MainDatabase;
using ConsoleApp2.Services.Contracts.UsDatabase;

namespace ConsoleApp2.Services.Concretes
{
    public class Operations : IOperations
    {
        private readonly IStokService _stokManager;
        private readonly IVStokService _vStokManager;

        public Operations(IStokService stokManager, IVStokService vStokManager)
        {
            _stokManager = stokManager;
            _vStokManager = vStokManager;
        }

        public async void WriteOnDbForStok()
        {
            var stokDatas = await _stokManager.GetAllAsync();

            for (int i = 0; i < stokDatas.Count; i++)
            {
                var obje = new VStok()
                {
                    //Id = stokDatas[i].Id,
                    Name = stokDatas[i].Name,
                    Amount = stokDatas[i].Price
                };

                var vData = await _vStokManager.GetOneAsync(stokDatas[i].Name);
                if (vData != null)
                    continue;

                await _vStokManager.AddAsync(obje);

            }
        }
    }
}
