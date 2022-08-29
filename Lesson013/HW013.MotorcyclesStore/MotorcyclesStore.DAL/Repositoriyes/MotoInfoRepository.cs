using MotorcyclesStore.Core.Interfaces;
using MotorcyclesStore.Core.Models;

namespace MotorcyclesStore.DAL.Repositoriyes
{

    public class MotoInfoRepository: IMotoInfoRepository
    {
        private readonly List<MotoInfo> _motoInfos = new List<MotoInfo>()
        {
            new MotoInfo()
            {
                Id = 1,
                Name = "Honda",
                Model = "CB 600 Hornet",
                Year = new DateTime(2005, 6, 23),
                Odometer = 35690,
                Price = 3900
            },
            new MotoInfo()
            {
                Id = 2,
                Name = "Harley-Davidson",
                Model = "V-Rod Muscle VRSCF",
                Year = new DateTime(2008, 9, 03),
                Odometer = 33725,
                Price = 11800
            },
            new MotoInfo()
            {
                Id = 3,
                Name = "BMW",
                Model = "K К1600 GTL",
                Year = new DateTime(2018, 2, 12),
                Odometer = 8000,
                Price = 35000
            },
            new MotoInfo()
            {
                Id = 4,
                Name = "Урал",
                Model = "М 72",
                Year = new DateTime(1955, 5, 28),
                Odometer = 8,
                Price = 6000
            },
            new MotoInfo()
            {
                Id = 5,
                Name = "Kawasaki",
                Model = "Z H2",
                Year = new DateTime(2020, 7, 08),
                Odometer = 5500,
                Price = 15500
            }
        };

        public void Create(MotoInfo item)
        {
            var id = int.MinValue;
            foreach (var moto in _motoInfos)
            {
                if (moto.Id > id)
                {
                    id = moto.Id;
                }
            }
            id++;
            item.Id = id;
            _motoInfos.Add(item);
        }

        public void Create(List<MotoInfo> listOfItems)
        {
            foreach (MotoInfo item in listOfItems)
            {
                _motoInfos.Add(item);
            }
        }

        public List<MotoInfo> GetAll()
        {
            return _motoInfos;
        }

        public MotoInfo GetFirstOrDefaultById(int id)
        {
            foreach (MotoInfo moto in _motoInfos)
            {
                if (moto.Id == id)
                {
                    return moto;
                }
            }
            return null!;
        }

        public void Update(MotoInfo item)
        {
            foreach (MotoInfo moto in _motoInfos)
            {
                if (moto.Id == item.Id)
                {
                    moto.Name = item.Name;
                    moto.Model = item.Model;
                    moto.Odometer = item.Odometer;
                    moto.Price = item.Price;
                    moto.Year = item.Year;
                }
            }
        }

        public void Delete(int id)
        {
            foreach (var  moto in _motoInfos)
            {
                if (moto.Id == id)
                {
                    _motoInfos.Remove(moto);
                    break;
                }
            }
        }
    }
}
