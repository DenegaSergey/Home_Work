using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_HW06.ThirdArrayCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRandomInput = new int[5];
            Random random = new Random();

            for (int i = 0; i < arrayRandomInput.Length; i++)
            {
                arrayRandomInput[i] = random.Next(20);
                Console.WriteLine("Array element value " +  " = " + arrayRandomInput[i]);
            }

            int[] arrayKeyboardInput = new int[5];

            Console.WriteLine("Keyboard input: ");

            for (int i = 0; i < arrayKeyboardInput.Length; i++)
                arrayKeyboardInput[i] = int.Parse(Console.ReadLine());

            int[] sumOfArchives = new int[5];
            for (int i = 0; i < 5; ++i)
            {
                sumOfArchives[i] = arrayRandomInput[i] + arrayKeyboardInput[i];
            }

            Console.WriteLine("Array content: ");
            Console.WriteLine(string.Join("  ", sumOfArchives));
        }
    }
}
