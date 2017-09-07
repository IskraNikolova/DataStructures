namespace _03__Longest_Subsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequence
    {
        /// <summary>
        /// A program that reads list of integers and finds in it all sequences of equal elements.
        /// </summary>
        public static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> equalsEl = new List<int>();
            List<int> result = new List<int>();
            equalsEl.Add(input[0]);

            for (int i = 1; i <= input.Count - 1; i++)
            {
                if (input[i - 1] == input[i])
                {
                    equalsEl.Add(input[i]);
                }
                else
                {
                    Swap(result, equalsEl);
                    equalsEl.Clear();
                    equalsEl.Add(input[i]);
                }
            }

            Swap(result, equalsEl);

            result.ForEach(e => Console.Write(e + " "));
            Console.WriteLine();
        }

        private static void Swap(List<int> result, List<int> equalsEl)
        {
            if (result.Count < equalsEl.Count)
            {
                result.Clear();
                result.AddRange(equalsEl);
            }
        }
    }
}
