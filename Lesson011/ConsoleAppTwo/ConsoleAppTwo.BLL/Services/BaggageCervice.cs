using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Core.Models;

namespace Airport.BLL.Services
{
    public class BaggageCervice
    {
        private readonly BaggageInfo _baggageInfo;

        public BaggageCervice()
        {
            _baggageInfo = new BaggageInfo();
        }

        public void CheckWeight()
        {
            while (true)
            {
                Console.Write("Enter the weight of your baggage: ");
                int userValue = Convert.ToInt32(Console.ReadLine());

                if (userValue <= 0)
                {
                    Console.WriteLine("Enter the correct weight of your baggage.");
                   
                }
                else if (userValue < 15)
                {
                    Console.WriteLine("You can take this baggage with you");
                    break;
                }
                else
                {
                    Console.WriteLine("Maximum weight exceeded. Send your baggage to the luggage compartment");
                    break;
                }
            }

        }

    }
}
