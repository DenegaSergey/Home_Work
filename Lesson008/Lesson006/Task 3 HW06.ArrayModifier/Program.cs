using System;

namespace Task3HW06.ArrayModifier
{
    internal class Program
    {
        static int EnteringSizeArrey()
        {
            Console.Write("Enter the size of the array: ");
            int elementsCount = int.Parse(Console.ReadLine());

            return elementsCount;
        }
        static int EnteringLastNumber()
        {
            Console.Write("Enter last value: ");
            int userlastNumber = Convert.ToInt32(Console.ReadLine());
            return userlastNumber;
        }
        static void DisplayingAnArray(int[] myArrey)
        {
            Console.WriteLine("Array output:");

            for (int i = 0; i < myArrey.Length; i++)
            {
                Console.WriteLine(myArrey[i]);
            }
        }
        static int[] OffsetToLeft(int[] myArrey)
        {
            int toLeft = myArrey[0];
            for (int i = 0; i < myArrey.Length - 1; i++)
            {
                myArrey[i] = myArrey[i + 1];
            }
            myArrey[myArrey.Length - 1] = toLeft;

            return myArrey;
        }
        static int GetLastNumberInArray(int[] myArrey)
        {
            int lastNumber = EnteringLastNumber();

            myArrey[myArrey.Length - 1] = lastNumber;

            return lastNumber;
        }
        static int[] GetNumberOfElementsInArray()
        {
            int elementsCount = EnteringSizeArrey();
            int[] myArrey = new int[elementsCount];

            for (int i = 0; i < elementsCount - 1; i++)
            {
                myArrey[i] = int.Parse(Console.ReadLine());
            }
            return myArrey;
        }
        static void Main(string[] args)
        {
            int[] myArrey = GetNumberOfElementsInArray();

            int lastNumber = GetLastNumberInArray(myArrey);

            int[] myArreySecond = OffsetToLeft(myArrey); 

            DisplayingAnArray(myArrey);

            Console.ReadKey();
        }
    }
}