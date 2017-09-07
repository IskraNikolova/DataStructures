using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Remove_Odd_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var result = input
                .GroupBy(el => el)
                .ToList();

            List<double> evenOccr = new List<double>();

            foreach (var e in result)
            {
                if (e.Count() % 2 == 0)
                {
                    evenOccr.Add(e.Key);
                }
            }

            foreach (var e in input)
            {
                if (evenOccr.Contains(e))
                {
                    Console.Write(e + " ");
                }
            }
        }
    }
}
