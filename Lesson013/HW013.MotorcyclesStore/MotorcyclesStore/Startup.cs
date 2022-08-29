using MotorcyclesStore.Core.Interfaces;
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
                        _motoStoreController.GetAll();
                        break;
                    case "2":
                        _motoStoreController.GetFirstOrDefaultById(0);
                        break;
                    case "3":
                        _motoStoreController.Create();
                        break;
                    case "4":
                        _motoStoreController.Update();
                        break;
                    case "5":
                        _motoStoreController.Delete();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
