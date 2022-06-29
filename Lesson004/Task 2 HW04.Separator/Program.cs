using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2HW04.Separator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userWord = Console.ReadLine() ;

            Console.Clear();

            var result = String.Join(" ", userWord.ToCharArray());

            string[] word1 = result.Split(' ');
            foreach (string text in word1)
            {
                Console.WriteLine(text);
                Thread.Sleep(250);
            }  
            Console.ReadKey ();
        }
    }
}
