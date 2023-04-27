using ConsoleApp1.DatabaseOperations.Abstracts;
using VardabitService.Models.UsDatabase;

namespace VardabitService.DatabaseOperations
{
    public class Operations
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

                var vData = await _vStokManager.GetVStok(stokDatas[i].Name);
                if (vData != null)
                    continue;
                
                await _vStokManager.AddAsync(obje);

            }
        }
    }
}
