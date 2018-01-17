class Launcher
{
    public static void Main()
    {
        LinkedList<int> testList = new LinkedList<int>();
        testList.AddFirst(1);
        testList.AddLast(2);
        testList.AddLast(3);
        foreach (var item in testList)
        {
            System.Console.WriteLine(item);
        }
    }
}
