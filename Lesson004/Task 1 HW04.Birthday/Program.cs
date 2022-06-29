using System;

namespace Task_1_HW04.Birthday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;

            Console.WriteLine("Enter your Birthday in DD-MM-YYYY format: ");

            var bDay = Console.ReadLine();
            var myDate = Convert.ToDateTime(bDay);

            var age = today.Year - myDate.Year; //Calculate age.

            
            if (myDate.Date > today.AddYears(-age)) age--;

            Console.WriteLine($"You are {age} years old"); //Displaying the result on the screen.

            // HACK: This code is temporary and can be removed.
            Console.ReadKey();


        }
    }
}
