using System;

namespace Task3HW07.Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrey = new int[4, 5];

            for (int y = 0; y < arrey.GetLength(0); y++) //высота массива
            {
                for (int x = 0; x < arrey.GetLength(1); x++) // ширина массива
                {
                    arrey[1, 2] = 1;
                    arrey[2, 1] = 1;
                    arrey[2, 2] = 1;
                    arrey[2, 3] = 1;
                    arrey[3, 0] = 1;
                    arrey[3, 1] = 1;
                    arrey[3, 2] = 1;
                    arrey[3, 3] = 1;
                    arrey[3, 4] = 1;

                    Console.Write(arrey[y, x] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
