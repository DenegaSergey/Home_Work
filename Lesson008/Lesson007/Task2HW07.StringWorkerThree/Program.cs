using System;
using System.Text.RegularExpressions;

namespace Task2HW07.StringWorkerThree
{
    internal class Program
    {
        static string[] SeparationUserString(string userString, string separator)
        {
            string[] separationResult = Regex.Split(userString, separator, RegexOptions.IgnoreCase);

            for (int i = 0; i < separationResult.Length; i++)
            {
                if (i < separationResult.Length - 1)
                    Console.Write("");
            }
            return separationResult;
        }
        static void Main(string[] args)
        {
            string userString = "gdfgdf234dg54gf*23oP42";
            string separator = "([*])|[a-z]+";
            string[] separationResult = SeparationUserString(userString, separator);

            string numbers = string.Join("", separationResult);

            Console.WriteLine(numbers);

            string[] number = numbers.Split('*');

            int leftNumbers = int.Parse(number[0]);
            int rightNumbers = int.Parse(number[1]);

            int calculationResult = leftNumbers * rightNumbers;

            Console.WriteLine(calculationResult);
        }
    }
}


