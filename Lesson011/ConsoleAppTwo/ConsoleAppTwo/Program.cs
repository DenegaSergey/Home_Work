using Airport.BLL.Services;
using Airport.DAL.Repositories;


while (true)
{
    Console.WriteLine("Welcome to DreamFly Airport. Please introduce yourself. ");
    var passportInfoRepository = new PassportInfoRepository();
    passportInfoRepository.Name = Console.ReadLine();

    Console.WriteLine($"Please go to registration, " + passportInfoRepository.Name);
    var checkInService = new CheckInService();

    var flightsInfo = checkInService.GetAllFlightsInfo();
    Console.WriteLine("List of all flights: ");
    Console.WriteLine(flightsInfo);

    Console.Write("Enter your flight number: ");

    var userInput = Console.ReadLine();

    var result = checkInService.CheckIfRegistrationStarted(userInput);
    Console.WriteLine(result);
    
    checkInService.AskUserAboutRegistration();
    
    Console.WriteLine("Welcome to register");

    var passportControlService = new PassportControlService();

    var baggageService = new BaggageCervice();
    baggageService.CheckWeight();

    Console.WriteLine("Thank you for registering and happy flying!");
    Console.ReadKey();

    Console.Clear();
}




