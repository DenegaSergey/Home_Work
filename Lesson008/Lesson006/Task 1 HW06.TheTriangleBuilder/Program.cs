using System;

namespace Task1HW06.TheTriangleBuilder
{
    internal class Program
    {
        static void ShowDisplayingTriangle(int userInput)
        {
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
        static int InputTriangleSize()
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
        static void Main(string[] args)
        {
            int userInput = InputTriangleSize();
            ShowDisplayingTriangle(userInput);
        }
    }
}
