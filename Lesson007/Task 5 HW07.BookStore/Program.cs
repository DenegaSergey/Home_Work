using System;

namespace Task5HW07.BookStore
{
    internal class Program
    {
        static void ExpensiveBook(int[,,] arreyBooks, int max)
        {
            for (int i = 0; i < arreyBooks.GetLength(0); i++)
                for (int j = 0; j < arreyBooks.GetLength(1); j++)
                    for (int k = 0; k < arreyBooks.GetLength(2); k++)
                        if (arreyBooks[i, j, k] > max)
                            max = arreyBooks[i, j, k];

            Console.WriteLine("Most expensive book: " + max);
        }
        static void CheapestBook(int[,,] arreyBooks, int min)
        {
            for (int i = 0; i < arreyBooks.GetLength(0); i++)
                for (int j = 0; j < arreyBooks.GetLength(1); j++)
                    for (int k = 0; k < arreyBooks.GetLength(2); k++)
                        if (arreyBooks[i, j, k] < min)
                            min = arreyBooks[i, j, k];

            Console.WriteLine("The cheapest book: " + min);
        }
        static void Main(string[] args)
        {
            int[,,] arreyBooks =
            {
                {
                   {09, 12, 05, 15},
                   {10, 08, 07, 11},
                   {35, 12, 12, 16},
                   {15, 24, 67, 89}
                },
                {
                   {88, 76, 13, 33},
                   {11, 53, 61, 14 },
                   {56, 44, 22, 17 },
                   {11, 98, 13, 14 }
                },
                {
                   {29, 27, 77, 14},
                   {78, 03, 55, 17},
                   {48, 19, 68, 80},
                   {68, 41, 14, 07}
                }
            };

            int max = int.MinValue, min = int.MaxValue;

            CheapestBook(arreyBooks, min);
            ExpensiveBook(arreyBooks, max);
        }
    }
}
