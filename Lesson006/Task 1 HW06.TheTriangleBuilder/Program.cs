using System;

namespace Task1HW06.TheTriangleBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            int value = 1;

            for (int i = userInput; i >= 1; i--)
            {
                for (int j = userInput - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
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
