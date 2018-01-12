using System;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList<string> testList = new ArrayList<string>();
        testList.Add("Pesho");
        testList.Add("Pesho");
        testList.Add("Pesho");

        foreach (var item in testList)
        {
            Console.WriteLine(item);
        }
    }
}
