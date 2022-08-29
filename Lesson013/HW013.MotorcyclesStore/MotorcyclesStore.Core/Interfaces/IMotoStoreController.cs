namespace MotorcyclesStore.Core.Interfaces
{
    public interface IMotoStoreController 
    {
        void GetAll();

        void GetFirstOrDefaultById(int Id);

        void Delete();

        void Update();

        void Create();
    }
}
