using System;
using System.Text.RegularExpressions;

namespace Task2HW07.StringWorkerThree
{
    internal class Program
    {
        static void ShowCalculationResult(int calculationResult)
        {
            Console.WriteLine(calculationResult);
        }
        static int CalculateResult(int leftNumbers, int rightNumbers)
        {
            int calculationResult = leftNumbers * rightNumbers;
            return calculationResult;
        }
        static int ConvertRightNumber(string[] digitsAfterDivision)
        {
            int rightNumbers = int.Parse(digitsAfterDivision[1]);
            return rightNumbers;
        }
        static int ConvertLeftNumber(string[] digitsAfterDivision)
        {
            int leftNumbers = int.Parse(digitsAfterDivision[0]);
            return leftNumbers;
        }
        static string[] SplitByCharacter(string numbers)
        {
            string[] digitsAfterDivision = numbers.Split('*');
            return digitsAfterDivision;
        }
        static void ShowNumbers(string numbers)
        {
            Console.WriteLine(numbers);
        }
        static string GetNumbersString(string[] separationResult)
        {
            string numbers = string.Join("", separationResult);
            return numbers;
        }
        static string[] InitializeArray(string[] separationResult)
        {
            for (int i = 0; i < separationResult.Length; i++)
            {
                if (i < separationResult.Length - 1)
                    Console.Write("");
            }
            return separationResult;
        }
        static string[] DivideUserString(string userString)
        {
            string separator = "([*])|[a-z]+";

            string[] separationResult = Regex.Split(userString, separator, RegexOptions.IgnoreCase);
            return separationResult;
        }
        static void Main(string[] args)
        {
            string userString = "gdfgdf234dg54gf*23oP42";
            string[] separationResult = DivideUserString(userString);

            InitializeArray(separationResult);

            string numbers = GetNumbersString(separationResult);

            ShowNumbers(numbers);

            string[] digitsAfterDivision = SplitByCharacter(numbers);

            int leftNumbers = ConvertLeftNumber(digitsAfterDivision);
            int rightNumbers = ConvertRightNumber(digitsAfterDivision);

            int calculationResult = CalculateResult(leftNumbers, rightNumbers);
            ShowCalculationResult(calculationResult);
        }
    }
}


