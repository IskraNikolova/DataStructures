using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CalculateSequenceWithAQueue
{
    public class CalculateSequence
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Queue<int> sequances = new Queue<int>();
            sequances.Enqueue(input);
            int index = 1;
            List<int> result = new List<int>();
            while (index <= 50)
            {
                var firstElement = sequances.Dequeue();
                result.Add(firstElement);
                var second = firstElement + 1;
                var third = firstElement * 2 + 1;
                var fourth = firstElement + 2;
                sequances.Enqueue(second);
                sequances.Enqueue(third);
                sequances.Enqueue(fourth);
                index++;
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}
