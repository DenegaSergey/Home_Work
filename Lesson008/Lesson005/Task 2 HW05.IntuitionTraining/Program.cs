using System;

namespace Task2HW05.IntuitionTraining
{
    internal class Program
    {
        static int HiddenNumber(int guess, int number, int min, int max)
        {
            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine("No number " + guess + " is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("No number " + guess + " is too low!");
                }
            }
            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!!!");
            return number;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 5;
            int number;
            int guess;

            while (playAgain)
            {
                guess = 0;
                number = random.Next(min, max + 1);
            }
        }
    }
}
