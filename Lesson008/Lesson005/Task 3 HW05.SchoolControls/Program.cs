using System;

namespace Task3HW05.SchoolControls
{
   internal class Program
    {
        static int YourQuarter(int controlTest, string firstQuarter, string secondQuarter, string thridQuarter, string fourthQuarter)
        {
            if (controlTest <= 15)
            {
                Console.WriteLine(firstQuarter);
            }
            else if (controlTest > 15 & controlTest <= 30)
            {
                Console.WriteLine(secondQuarter);
            }
            else if (controlTest > 30 & controlTest <= 45)
            {
                Console.WriteLine(thridQuarter);
            }
            else if (controlTest > 45 & controlTest <= 60)
            {
                Console.WriteLine(fourthQuarter);
            }
            return controlTest;
        }
        static void Main(string[] args)
        {
            string firstQuarter = "First Quarter", secondQuarter = "Second Quarter ", thridQuarter = "Thrid Quarter", fourthQuarter = "Fourth Quarter";
            int controlTest;

            Console.WriteLine("Your control test number: ");
            controlTest = Convert.ToInt32(Console.ReadLine());

            YourQuarter(controlTest, firstQuarter, secondQuarter, thridQuarter, fourthQuarter);
        }
    }
}
