using Airport.Core.Constants;
using Airport.Core.System;
using Airport.DAL.Repositories;

namespace Airport.BLL.Services
{
    public class CheckInService
    {
        private readonly FlightInfoRepository _flightInfoRepository;
        private readonly BaggageInfo _baggageInfo;

        public CheckInService()
        {
            _flightInfoRepository = new FlightInfoRepository();
            _baggageInfo = new BaggageInfo();
        }
        public string GetAllFlightsInfo()
        {
            var flights = _flightInfoRepository.GetAll();
            var result = "";
            foreach (var flight in flights)
            {
                result += $"Number: {flight.Number} From: {flight.From} To: {flight.To} DepartureTime: {flight.DepartureTime}\n";
            }
            return result;
        }
        public string CheckIfRegistrationStarted(string flightNumber)
        {
            var flights = _flightInfoRepository.GetAll();

            foreach (var flight in flights)
            {
                if (flight.Number.Equals(flightNumber, StringComparison.InvariantCultureIgnoreCase))
                {
                    var currentTime = DateTime.Now;
                    var departureTime = flight.DepartureTime;

                    var startRegistrationTime = departureTime.AddHours(-2);

                    if (currentTime > flight.DepartureTime)
                    {
                        return "Registration is ended";
                    }
                    else if (currentTime < flight.DepartureTime && currentTime > startRegistrationTime)
                    {
                        return "Registration started";
                    }
                    else
                    {
                        return $"Registration will start at {startRegistrationTime}";
                    }
                }
            }
            return "Number of flight don't exist";
        }

        public Result AskUserAboutRegistration()
        {
            Console.WriteLine("Do you want to start registration? (Yes/No)");
            var userInput = Console.ReadLine();

            return userInput!.Equals("Yes", StringComparison.OrdinalIgnoreCase) ? Result.Yes : Result.No();
        }

        public void CheckWeight()
        {
            while (true)
            {
                Console.Write("Enter the weight of your baggage: ");
                int userValue = Convert.ToInt32(Console.ReadLine());

                if (userValue < BaggageInfo.MinWight)
                {
                    Console.WriteLine("Enter the correct weight of your baggage.");

                }
                else if (userValue < BaggageInfo.MaxWight)
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
        public string GetUserName()
        {
            string userName = Console.ReadLine();
            return userName;
        }
    }
}