using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class ArrayListTests
{
    ArrayList<int> list;
    [TestInitialize]

    public void TestInitialize()
    {
         list = new ArrayList<int>();
    }

    [TestMethod]
    public void AddSingleElementShouldIncreaseCount()
    {      
        list.Add(1);

        Assert.AreEqual(1, list.Count);
    }

    [TestMethod]
    public void AddMultipleElementShouldIncreaseCount()
    {
        for (int i = 0; i < 100; i++)
        {
            list.Add(i);
        }

        Assert.AreEqual(100, list.Count);
    }

    [TestMethod]
    public void AddAndGetSingleElement()
    {
        list.Add(5);

        Assert.AreEqual(5, list[0]);
    }

    [TestMethod]
    public void AddAndGetMultipleElements()
    {
        for (int i = 0; i < 100; i++)
        {
            list.Add(i);
        }

        for (int i = 0; i < 100; i++)
        {
            Assert.AreEqual(i, list[i]);
        }
    }

    [TestMethod]
    public void SetSingleElement()
    {
        list.Add(0);
        list[0] = 2;

        Assert.AreEqual(2, list[0]);
    }

    [TestMethod]
    public void SetMultipleElements()
    {
        for (int i = 0; i < 100; i++)
        {
            list.Add(i);
        }

        for (int i = 0; i < list.Count; i++)
        {
            list[i] = i + 1;
        }

        for (int i = 0; i < 100; i++)
        {
            Assert.AreEqual(i + 1, list[i]);
        }
    }

    [TestMethod]
    public void RemoveSingleElementShouldHaveCorrectCount()
    {
        list.Add(0);
        list.RemoveAt(0);

        Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void RemoveSingleElementShouldHaveCorrectElements()
    {
        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.RemoveAt(0);

        Assert.AreEqual(1, list[0]);
        Assert.AreEqual(2, list[1]);
    }

    [TestMethod]
    public void RemoveMultipleElements()
    {

        for (int i = 0; i < 100; i++)
        {
            list.Add(i);
        }

        for (int i = 0; i < 50; i++)
        {
            list.RemoveAt(0);
        }

        Assert.AreEqual(50, list.Count);
        for (int i = 0; i < 50; i++)
        {
            Assert.AreEqual(i + 50, list[i]);
        }
    }

    [TestMethod]
    public void AddMultiplePerformanceTest()
    {
        for (int i = 0; i < 100000; i++)
        {
            list.Add(i);
        }

        for (int i = 0; i < 100000; i++)
        {
            Assert.AreEqual(i, list[i]);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void SetInvalidPositionShouldThrow()
    {
        list[5] = 2;
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void RemoveAtInvalidPositionShouldThrow()
    {
        list.RemoveAt(3);
    }
}
