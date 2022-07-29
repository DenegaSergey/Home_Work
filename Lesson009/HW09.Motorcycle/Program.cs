using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var motorcycleOne = new Motorcycle("CB 600 Hornet", "Honda", new DateTime(2005, 03, 25, 14, 08, 13), "used", 35636, "Street", "Orange");

            Console.WriteLine(motorcycleOne.GetAllInfo());
            
            Console.WriteLine($"This motorcycle is {DateTime.Now.Year - motorcycleOne.CreatedAt.Year} years old.");

            Console.WriteLine($"Average mileage is " + $"{motorcycleOne.Mileage/(DateTime.Now.Year - motorcycleOne.CreatedAt.Year)}km per year.");
        }
    }
}
