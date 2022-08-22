using MotorcyclesStore.Core.Models;

namespace MotorcyclesStore.Core.Interfaces
{
    public interface IMotoInfoRepository
    {
        void Create(MotoInfo item);

        void Create(List<MotoInfo> listOfItems);

        List<MotoInfo> GetAll();

        MotoInfo GetFirstOrDefaultById(int id);

        void Update(MotoInfo item);

        void Delete(int id);

    }
}
