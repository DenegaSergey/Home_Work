using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_HW04.Birthday
{
    internal class Program
    {
        static void DisplayingResult(int age)
        {
            Console.WriteLine($"You are {age} years old");
        }
        static string BirthDay()
        {
            Console.WriteLine("Enter your Birthday in DD-MM-YYYY format: ");
            string bDay = Console.ReadLine();

            return bDay;
        }
        static int CalculateAge()
        {

            string bDay = BirthDay();

            var today = DateTime.Now;

            var myDate = Convert.ToDateTime(bDay);
            var age = today.Year - myDate.Year; //Calculate age.

            if (myDate.Date > today.AddYears(-age)) age--;

            return age;
        }
        static void Main(string[] args)
        {
            int age = CalculateAge();

            DisplayingResult(age);//Displaying the result on the screen.

            Console.ReadKey();  // HACK: This code is temporary and can be removed.
        }

    }
}
