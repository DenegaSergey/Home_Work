using MotorcyclesStore.Core.Interfaces;
using MotorcyclesStore.Core.Models;
using Serilog;

namespace MotorcyclesStore.UI
{
    public class Startup 
    {
        private readonly IMotoStoreController _motoStoreController;

        public Startup(IMotoStoreController motoStoreController)
        {
            _motoStoreController = motoStoreController;
        }

        public void Start()
        {
            Log.Logger.Information("App Motorcycles Store started\n");
            
            while (true)
            {
                Console.WriteLine("1. Get All Motorcycles\n" +
                                  "2. Get Id Info Motorcycles\n" +
                                  "3. Create Motorcycle\n" +
                                  "4. Update Motorcycle\n" +
                                  "5. Delete Motorcycle\n");

                Console.WriteLine("Enter the command: ");
                var command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        GetAll();
                        break;
                    case "2":
                        GetFirstOrDefaultById();
                        break;
                    case "3":
                        Create();
                        break;
                    case "4":
                        Update();
                        break;
                    case "5":
                        Delete();
                        break;
                    default:
                        return;
                }
            }
        }

        private void GetAll()
        {
            _motoStoreController.GetAll();
        }

        private void GetFirstOrDefaultById()
        {
            _motoStoreController.GetFirstOrDefaultById(0);
        }

        private void Delete()
        {
            _motoStoreController.Delete();
        }

        private void Update()
        {
            _motoStoreController.Update();
        }

        private void Create()
        {
            _motoStoreController.Create();
        }

    }
}
