using System;

namespace Task_4_HW04.SalaryBonusCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your salary: ");
            int salary = int.Parse(Console.ReadLine());

            Console.Write("Your experience: ");
            int experience = int.Parse(Console.ReadLine());

            double bonus = 0;
            if (experience < 5) bonus = 0.10;
            if (experience >= 5 && experience < 10) bonus = 0.15;
            if (experience >= 10 && experience < 15) bonus = 0.25;
            if (experience >= 15 && experience < 20) bonus = 0.35;
            if (experience >= 20 && experience < 25) bonus = 0.45;
            if (experience >= 50) bonus = 0.50;

            double payoff = salary + (Math.Round(salary * bonus, 2));

            Console.WriteLine($"Your Bonus - {Math.Round(salary * bonus, 2)}, to payoff - {payoff}");
        }
    }
}

