using System;

namespace Task_3_HW04.Combiner
{
    internal class Program
    {
        static void OutputOnDisplay(string text)
        {
            Console.WriteLine(text);
        }
        static string TextOutput(string firstName, string lastName)
        {
            string text = "Hello " + firstName + " " + lastName + "!" + " " + "It's a god day today!";
            return text;
        }
        static (string firstName, string lastName) InputFirstAndLastName()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Clear();

            return (firstName, lastName);
        }
        static void Main(string[] args)
        {
            var input = InputFirstAndLastName();
            string firstName = input.firstName, lastName = input.lastName;

            string text = TextOutput(firstName, lastName);

            OutputOnDisplay(text);

            Console.ReadKey();
        }
    }
}
