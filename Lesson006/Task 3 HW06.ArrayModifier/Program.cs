using System;

namespace Task3HW06.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of array elements:\t");

            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArrey = new int[elementsCount];

            for (int i = 0; i < elementsCount - 1; i++)
            {
                myArrey[i] = int.Parse(Console.ReadLine());
            }

            int lastNumber = 0;

            Console.Write("Enter last value: ");
            lastNumber = Convert.ToInt32(Console.ReadLine());

            myArrey[myArrey.Length - 1] = lastNumber;

            int rightShift = myArrey[myArrey.Length - 1];

            for (int i = myArrey.Length - 1; i > 0; i--) //How to rotate an array to the left?
            {
                myArrey[i] = myArrey[i - 1];
            }

            myArrey[0] = rightShift;

            Console.WriteLine("Array output:");

            for (int i = 0; i < myArrey.Length; i++)
            {
                Console.WriteLine(myArrey[i]);
            }

            Console.ReadKey();
        }
    }
}
