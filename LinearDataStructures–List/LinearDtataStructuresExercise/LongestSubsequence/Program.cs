namespace LongestSubsequence
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

            List<int> longestSub = LongestSubsequence(input);

            Console.WriteLine(string.Join(" ", longestSub));
        }

        private static List<int> LongestSubsequence(List<int> input)
        {
            var result = new List<int>();
            var currentSequence = new List<int>();

            int maxLenght = 1;

            for (int i = 0; i < input.Count; i++)
            {
                if (i != input.Count - 1 && 
                    input[i] == input[i + 1])
                {
                    currentSequence.Add(input[i]);
                }

                else
                {
                    currentSequence.Add(input[i]);

                    if (maxLenght < currentSequence.Count)
                    {
                        maxLenght = currentSequence.Count;

                        result.Clear();
                        result.AddRange(currentSequence);
                    }

                    currentSequence.Clear();
                }
            }

            return result;
        }
    }
}
