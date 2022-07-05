using System;

namespace Task1HW06.TheTriangleBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            int value = 1;

            for (int lines = userInput; lines >= 1; lines--)
            {
                for (int spaces = userInput - 1; spaces >= lines; spaces--)
                {
                    Console.Write(" ");
                }

                for (int colums = 1; colums <= lines; colums++)
                {
                    Console.Write(value);
                    Console.Write(" ");
                }
                value++;
                if (value == 10)
                {
                    value = 0;
                }

                Console.WriteLine();
            }
        }
    }
}
