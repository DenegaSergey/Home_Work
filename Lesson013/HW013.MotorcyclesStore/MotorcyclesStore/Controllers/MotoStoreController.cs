using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorcyclesStore.Core.Interfaces;
using MotorcyclesStore.Core.Models;
using Serilog;

namespace MotorcyclesStore.UI.Controllers
{
    public class MotoStoreController : IMotoStoreController
    {
        private readonly IMotoStoreService _motoStoreService;

        public MotoStoreController(IMotoStoreService motoStoreServicevice)
        {
            _motoStoreService = motoStoreServicevice;
        }

        public void GetAll()
        {
            var allMoto = _motoStoreService.GetMotorcycles();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(allMoto);
            Console.ResetColor();
        }

        public void GetFirstOrDefaultById(int Id)
        {
            Log.Logger.Information("Method GetFirstOrDefaultById STARTED");

            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter Motorcycle ID: ");
                var userInputId = Convert.ToInt32(Console.ReadLine());
                Log.Logger.Debug("Entering the moto ID", userInputId);
                var motoInfo = _motoStoreService.GetMotorcycleByID(userInputId);
                Log.Logger.Information(" Get Info Motorcycle");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Id: {motoInfo.Id}  Name: {motoInfo.Name}  Model: {motoInfo.Model}  Year: {motoInfo.Year}  Odometer: {motoInfo.Odometer}  Price: {motoInfo.Price}\n");
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Log.Logger.Error($"Some ERROR {e}");
                throw e;
            }
        }

        public void Delete()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Motorcycle ID: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            _motoStoreService.DeleteMotorcycle(userInput);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Motorcycle {userInput} delete");
            Console.ResetColor();

        }

        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter Motorcycle ID: ");
            var userInput = Convert.ToInt32(Console.ReadLine());

            var moto = _motoStoreService.GetMotorcycleByID(userInput);

            Console.WriteLine("Enter new motorcycle Name:");
            var name = Console.ReadLine();
            moto.Name = name;

            Console.WriteLine("Enter new motorcycle Model:");
            var model = Console.ReadLine();
            moto.Model = model;
            Console.ResetColor();

            _motoStoreService.UpdateMotorcycle(moto);
        }

        public void Create()
        {
            var motoInfo = new MotoInfo();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Enter new motorcycle info.");

            Console.WriteLine("Enter motorcycle Name:");
            var name = Console.ReadLine();
            motoInfo.Name = name;

            Console.WriteLine("Enter motorcycle Model:");
            var model = Console.ReadLine();
            motoInfo.Model = model;

            Console.WriteLine("Enter production date.");
            Console.WriteLine("Enter motorcycle Year:");
            var newYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter motorcycle Moth:");
            var newMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter motorcycle Day:");
            var newDay = Convert.ToInt32(Console.ReadLine());

            DateTime year = new DateTime(newYear, newMonth, newDay);
            motoInfo.Year = year;

            Console.WriteLine("Enter motorcycle Odometer:");
            int odometer = Convert.ToInt32(Console.ReadLine());
            motoInfo.Odometer = odometer;

            Console.WriteLine("Enter motorcycle Price:");
            int price = Convert.ToInt32(Console.ReadLine());
            motoInfo.Price = price;
            Console.ResetColor();

            _motoStoreService.CreateMotorcycle(motoInfo);
        }

    }
}
