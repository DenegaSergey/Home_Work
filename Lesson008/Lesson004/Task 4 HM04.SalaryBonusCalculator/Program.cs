using System;

namespace Task_4_HW04.SalaryBonusCalculator
{
    internal class Program
    {
        static void ShowSalaryAndBonus(int salary, double bonus, double result)
        {
            Console.WriteLine($"Your Bonus - {CalculationBonus(salary, bonus)}, to payoff - {result}");
        }
        static int EnteringUserExperience()
        {
            Console.Write("Your experience: ");
            int experience = int.Parse(Console.ReadLine());
            return experience;
        }
        static int EnteringUserSalary()
        {
            Console.Write("Your salary: ");
            int salary = int.Parse(Console.ReadLine());
            return salary;
        }
        static double CalculationBonus(int salary, double bonus)
        {
            double allowance = (Math.Round(salary * bonus, 2));
            return allowance;
        }
        static double GetBonusValue(int experience)
        {
            double bonus = 0;
            if (experience < 5) bonus = 0.10;
            if (experience >= 5 && experience < 10) bonus = 0.15;
            if (experience >= 10 && experience < 15) bonus = 0.25;
            if (experience >= 15 && experience < 20) bonus = 0.35;
            if (experience >= 20 && experience < 25) bonus = 0.45;
            if (experience >= 50) bonus = 0.50;

            return bonus;

        }
        static double PayoffСalculation(int salary, double bonus)
        {
            double result = salary + (Math.Round(salary * bonus, 2));

            return result;
        }
        static void Main(string[] args)
        {
            int salary = EnteringUserSalary();
            int experience = EnteringUserExperience();

            double bonus = GetBonusValue(experience);
            double result = PayoffСalculation(salary, bonus);

            ShowSalaryAndBonus(salary, bonus, result);
        }
    }
}



