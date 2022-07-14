using System;

namespace Task3HW07.Pyramid
{
    internal class Program
    {
        static int[,] ReplacingValuesInArray(int[,] myArrey, int displayValueZero, int middleValueOne, int middleValueTwo, int displayValueOne)
        {
            for (int i = 0; i < myArrey.GetLength(0); i++)
            {
                for (int j = 0; j < myArrey.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        Console.Write(displayValueZero);
                    }
                    else
                    {
                        if (j > middleValueOne && j < middleValueTwo)
                        {
                            Console.Write(displayValueOne);
                        }
                        else
                        {
                            Console.Write(displayValueZero);
                        }
                    }
                }
                middleValueOne--;
                middleValueTwo++;
                Console.WriteLine();
            }
            return myArrey;
        }
        static void Main(string[] args)
        {
            int rowCount = 4;
            int colummneCount = 5;
            int[,] myArrey = new int[rowCount, colummneCount];

            int displayValueZero = 0;
            int displayValueOne = 1;
            int middleValueOne = (colummneCount - 1) / 2;
            int middleValueTwo = (colummneCount - 1) / 2;
            ReplacingValuesInArray(myArrey, displayValueZero, middleValueOne, middleValueTwo, displayValueOne);
        }
    }
}