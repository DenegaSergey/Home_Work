using System;

namespace Task_3_HW04.Combiner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Clear();

            Console.Write("Enter your last name: ");
            string lastName= Console.ReadLine();

            Console.Clear();

            string text = "Hello " + firstName + " " + lastName + "!" + " " + "It's a god day today!";

            Console.WriteLine(text);  

            Console.ReadKey();
        }
    }
}
