using System;

namespace Task4HW07.Diagonal
{
    internal class Program
    {
        static void ShowSmallestValue(int smallestValue)
        {
            Console.WriteLine("Smallest value in diagonal B: " + smallestValue);
        }
        static void ShowLargestValue(int largestValue)
        {
            Console.WriteLine("Largest value in diagonal A: " + largestValue);
        }
        static (int, int) GetMinMaxValuesInDiagonals(int[,] myArrey, int lengthMyArrey)
        {
            int largestValue = myArrey[0, 0];
            int smallestValue = myArrey[lengthMyArrey - 1, 0];

            for (int i = 0; i < lengthMyArrey; i++)
            {
                if (myArrey[i, i] > largestValue)
                {
                    largestValue = myArrey[i, i];
                }
                if (myArrey[lengthMyArrey - 1 - i, i] < smallestValue)
                {
                    smallestValue = myArrey[lengthMyArrey - 1 - i, i];
                }
            }
            return (largestValue, smallestValue);
        }
        static void Main(string[] args)
        {
            int[,] myArrey = {
                {11, 12, 13,14,15},
                {00, 22, 44, 17, 97},
                {02, 15, 10, 66, 76},
                {40, 09, 03, 55, 37},
                {58, 25, 53, 07, 44}
            };

            int lengthMyArrey = myArrey.GetLength(0);
            if (lengthMyArrey == 0)
                return;

            (int largestValue, int smallestValue) input = GetMinMaxValuesInDiagonals(myArrey, lengthMyArrey);
            int largestValue = input.Item1, smallestValue = input.Item2;

            ShowLargestValue(largestValue);
            ShowSmallestValue(smallestValue);
        }
    }
}

