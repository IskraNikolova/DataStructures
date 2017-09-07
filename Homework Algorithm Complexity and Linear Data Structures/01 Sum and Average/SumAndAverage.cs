using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Sum_and_Average
{
    public class SumAndAverage
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //Sum=15; Average=5.00
            double sum = input.Sum();
            double avarage = input.Average();
            Console.WriteLine($"Sum={sum}; Average={avarage:F2}");
        }
    }
}
