using MotorcyclesStore.Core.Models;

namespace MotorcyclesStore.Core.Interfaces
{
    public interface IMotoStoreService
    {
        MotoInfo GetMotorcycleByID(int Id);

        string GetMotorcycles();

        void CreateMotorcycle(MotoInfo model);

        void UpdateMotorcycle(MotoInfo model);

        void DeleteMotorcycle(int Id);

    }
}
