
using Airport.Core.System;
using Airport.DAL.Repositories;

namespace Airport.BLL.Services
{
    public class CheckInService
    {
        private readonly FlightInfoRepository _flightInfoRepository;
        public CheckInService()
        {
            _flightInfoRepository = new FlightInfoRepository();
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

    }
}