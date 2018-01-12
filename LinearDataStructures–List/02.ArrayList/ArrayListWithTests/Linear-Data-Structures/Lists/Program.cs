using System;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList<string> testList = new ArrayList<string>();
        testList.Add("Pesho");
        Console.WriteLine(testList.Count);
        testList[0] = "Gosho";
        Console.WriteLine(testList[0]);
        Console.WriteLine(testList.RemoveAt(0));
    }
}
