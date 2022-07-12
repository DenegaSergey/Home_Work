using System;

namespace Task3HW06.ArrayModifier
{
    internal class Program
    {
        static void DisplayingAnArray(int[] myArrey)
        {
            Console.WriteLine("Array output:");

            for (int i = 0; i < myArrey.Length; i++)
            {
                Console.WriteLine(myArrey[i]);
            }

        }
        static int[] ToLeft(int[] myArrey)
        {
            int toLeft = myArrey[0];
            for (int i = 0; i < myArrey.Length - 1; i++)
            {
                myArrey[i] = myArrey[i + 1];
            }
            myArrey[myArrey.Length - 1] = toLeft;

            return myArrey;
        }
        static int LastNumberInArray(int[] myArrey)
        {
            int lastNumber = 0;

            Console.Write("Enter last value: ");
            lastNumber = Convert.ToInt32(Console.ReadLine());

            myArrey[myArrey.Length - 1] = lastNumber;

            return lastNumber;
        }
        static int[] NumberOfElementsInArray()
        {
            Console.Write("Enter the size of the array: ");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArrey = new int[elementsCount];

            for (int i = 0; i < elementsCount - 1; i++)
            {
                myArrey[i] = int.Parse(Console.ReadLine());
            }
            return myArrey;
        }
        static void Main(string[] args)
        {
            int[] myArrey = NumberOfElementsInArray();

            int lastNumber = LastNumberInArray(myArrey);

            int[] myArreySecond = ToLeft(myArrey); //move the element to the left

            DisplayingAnArray(myArrey);

            Console.ReadKey();
        }
    }
}