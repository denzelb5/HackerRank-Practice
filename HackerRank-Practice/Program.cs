using System;

namespace HackerRank_Practice
{
    class Program
    {
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {

            var tax = meal_cost * (tax_percent * .01);
            var tip = meal_cost * (tip_percent * .01);
            var total = meal_cost + tax + tip;
            var rounded = Math.Round(total);
            Console.WriteLine(rounded);

        }

        static void Main(string[] args)
        {
            solve(12.00, 20, 8);
        }
    }
}
