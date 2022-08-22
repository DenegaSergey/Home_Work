using MotorcyclesStore.Core.Interfaces;
using MotorcyclesStore.Core.Models;
using Serilog;

namespace MotorcyclesStore.BLL.Services
{
    public class MotoStoreService : IMotoStoreService
    {
        public readonly IMotoInfoRepository _motoInfoRepository;

        public MotoStoreService(IMotoInfoRepository motoInfoRepository)
        {
            _motoInfoRepository = motoInfoRepository;
        }

        public MotoInfo GetMotorcycleByID(int id)
        {
            return _motoInfoRepository.GetFirstOrDefaultById(id);
        }

        public string GetMotorcycles()
        {
            var motorcycles = _motoInfoRepository.GetAll();
            var result = " ";
            foreach (var moto in motorcycles)
            {
                result += $"Id: {moto.Id}  Name: {moto.Name}  Model: {moto.Model}  Year: {moto.Year}  Odometer: {moto.Odometer}  Price: {moto.Price}\n";
            }
            return result;
        }

        public void CreateMotorcycle(MotoInfo model)
        {
            _motoInfoRepository.Create(model);
        }

        public void UpdateMotorcycle(MotoInfo model)
        {
            _motoInfoRepository.Update(model);
        }

        public void DeleteMotorcycle(int id)
        {
            _motoInfoRepository.Delete(id);
        }
    }
}