namespace SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            Console.WriteLine($"Sum={input.Sum()}; Average={input.Average():F2}");

        }
    }
}
