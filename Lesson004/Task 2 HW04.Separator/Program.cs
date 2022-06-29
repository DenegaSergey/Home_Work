using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Task 2 HW04.Separator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordUser = Console.ReadLine() ;

            Console.Clear();

            wordUser = wordUser.Replace(" ", string.Empty);
            var result = String.Join(" ", wordUser.ToCharArray());

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
