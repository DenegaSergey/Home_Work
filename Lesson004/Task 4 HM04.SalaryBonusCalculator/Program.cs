using System;

namespace Task_4_HW04.SalaryBonusCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your salary: ");
            int salary = int.Parse(Console.ReadLine());

            Console.Write("Your seniority: ");
            int seniority = int.Parse(Console.ReadLine());

            double bonus = 0;
            if (seniority < 5) bonus = 0.10;
            if (seniority >= 5 && seniority < 10) bonus = 0.15;
            if (seniority >= 10 && seniority < 15) bonus = 0.25;
            if (seniority >= 15 && seniority < 20) bonus = 0.35;
            if (seniority >= 20 && seniority < 25) bonus = 0.45;
            if (seniority >= 50) bonus = 0.50;

            double payoff = salary + (Math.Round(salary * bonus, 2));

            Console.WriteLine($"Your Bonus - {Math.Round(salary * bonus, 2)}, to payoff - {payoff}");
        }
    }
}

