using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_HW06.ThirdArrayCreator
{
    internal class Program
    {
        static void DisplayEqualOnScreen(int[] sumOfArchives)
        {
            Console.WriteLine("Array content: ");
            Console.WriteLine(string.Join("  ", sumOfArchives));

        }
        static int[] GetEqualArchives(int[] OutputKeyboardArrey, int[] OutputRandomArrey, int[] sumOfArchives)
        {
            for (int i = 0; i < sumOfArchives.Length; ++i)
            {
                sumOfArchives[i] = OutputRandomArrey[i] + OutputKeyboardArrey[i];
            }
            return sumOfArchives;
        }
        static void OutputKeyboardArrey(int[] arrayKeyboardInput)
        {
            Console.WriteLine("Keyboard input: ");

            for (int i = 0; i < arrayKeyboardInput.Length; i++)
                arrayKeyboardInput[i] = int.Parse(Console.ReadLine());
        }
        static void OutputRandomArrey(int[] arrayRandomInput)
        {
            Random random = new Random();
            for (int i = 0; i < arrayRandomInput.Length; i++)
            {
                arrayRandomInput[i] = random.Next(20);
                Console.WriteLine("Array element value " + " = " + arrayRandomInput[i]);
            }

        }
        static void Main(string[] args)
        {
            int[] arrayRandomInput = new int[5];
            int[] arrayKeyboardInput = new int[5];
            int[] sumOfArchives = new int[5];

            OutputRandomArrey(arrayRandomInput);
            OutputKeyboardArrey(arrayKeyboardInput);

            sumOfArchives = GetEqualArchives(arrayKeyboardInput, arrayRandomInput, sumOfArchives);

            DisplayEqualOnScreen(sumOfArchives);
        }
    }
}
