using Airport.BLL.Services;


while (true)
{
    Console.WriteLine("Welcome to DreamFly Airport. Please introduce yourself. ");
    var checkInService = new CheckInService();
    var userName = checkInService.GetUserName();
    Console.WriteLine($"Please go to registration, " + userName);

    var flightsInfo = checkInService.GetAllFlightsInfo();
    Console.WriteLine("List of all flights: ");
    Console.WriteLine(flightsInfo);

    Console.Write("Enter your flight number: ");

    var userInput = Console.ReadLine();

    var result = checkInService.CheckIfRegistrationStarted(userInput);
    Console.WriteLine(result);

    checkInService.AskUserAboutRegistration();

    Console.WriteLine("Welcome to register");

    checkInService.CheckWeight();

    Console.WriteLine("Thank you for registering and happy flying!");
    Console.ReadKey();

    Console.Clear();
}




