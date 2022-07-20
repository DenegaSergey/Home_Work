using System;

namespace Task_3_HW04.Combiner
{
    internal class Program
    {
        static void OutputOnDisplay(string text)
        {
            Console.WriteLine(text);
        }
        static string ShowGreeting(string firstName, string lastName)
        {
            string text = "Hello " + firstName + " " + lastName + "!" + " " + "It's a god day today!";
            return text;
        }
        static string GetFirstName()
        {
            Console.Write("Enter your first name: ");
            string userFirstName = Console.ReadLine();

            Console.Clear();
            return userFirstName;
        }
        static string GetLastName()
        {
            Console.Write("Enter your last name: ");
            string userLastName = Console.ReadLine();

            Console.Clear();
            return userLastName;
        }
       
        static void Main(string[] args)
        {
            string firstName = GetFirstName();
            string lastName = GetLastName();

            string text = ShowGreeting(firstName, lastName);

            OutputOnDisplay(text);

            Console.ReadKey();
        }
    }
}
