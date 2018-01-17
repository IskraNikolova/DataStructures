namespace CountOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            List<int> input = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToList();

            var group = input.GroupBy(e => e).ToList();

            foreach (var items in group)
            {
                int count = items.ToList().Count;
                int element = items.ToList()[0];
                Console.WriteLine($"{element} -> {count} times");
            }
        }
    }
}
