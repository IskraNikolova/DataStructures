using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _02_Sort_Words
{
    public class SortWords
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            input.Sort();
            input.ForEach(w => Console.Write(w + " "));
        }
    }
}
