using System;
using System.Collections.Generic;
using System.Linq;

namespace _05__Count_of_Occurrences
{
    public class CountOfOccurrences
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

                input.Sort();

            var result = input
                .GroupBy(el => el)
                .ToList();

            foreach (var el in result)
            {
                Console.WriteLine($"{el.Key} -> {el.Count()} times");
            }
        }
    }
}
