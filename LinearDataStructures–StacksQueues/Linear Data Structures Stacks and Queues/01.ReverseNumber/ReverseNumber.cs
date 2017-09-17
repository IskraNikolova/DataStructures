using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumber
{
    public class ReverseNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse);
            Stack<int> inputs = new Stack<int>();
            foreach (var el in input)
            {
                inputs.Push(el);
            }

            foreach (var el in inputs)
            {
                Console.Write(el + " ");
            }
        }
    }
}
