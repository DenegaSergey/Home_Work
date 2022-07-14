using System;
using System.Threading;

namespace Task_2HW04.Separator
{
    internal class Program
    {
        static string InputWord()
        {
            string userWord = Console.ReadLine();

            Console.Clear();

            var result = String.Join(" ", userWord.ToCharArray());

            return result;
        }
        static void Main(string[] args)
        {
            string result = InputWord();

            string[] word1 = result.Split(' ');
            foreach (string text in word1)
            {
                Console.WriteLine(text);
                Thread.Sleep(250);
            }
            Console.ReadKey();
        }
    }
}