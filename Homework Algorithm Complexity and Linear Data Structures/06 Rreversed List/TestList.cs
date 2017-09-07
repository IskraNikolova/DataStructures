using System;

namespace _06_Rreversed_List
{
    public class TestList
    {
        public static void Main()
        {
            ReveresedList<int> testInt = new ReveresedList<int>();
            testInt.Add(1);
            testInt.Add(2);
            testInt.Add(3);
            testInt.Add(4);
            testInt.Add(5);
            testInt.RemoveAt(2);
            foreach (var el in testInt)
            {
                Console.WriteLine(el);
            }
         
        }
    }
}
