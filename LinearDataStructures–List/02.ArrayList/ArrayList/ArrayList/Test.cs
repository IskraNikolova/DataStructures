namespace ArrayList
{
    using System;

    public class Test
    {
        public static void Main()
        {
            ArrayList<int> testList = new ArrayList<int>();
            testList.Add(6);
            testList.Add(56);
            
            Console.WriteLine(testList.RemoveAt(0));
        }
    }
}
