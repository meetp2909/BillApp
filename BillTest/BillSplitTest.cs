using System;
using BillLibrary;

namespace BillTest
{
[TestClass]
public class BillSplitTest
{
    [TestMethod]
    public void SplitAmount_WhenValidAmountAndPositiveNumberOfPeople_ReturnsCorrectSplitAmount()
    {
        BillSplit splitter = new BillSplit();
        decimal totalAmount = 100.0m;
        int numberOfPeople = 5;
        decimal expectedSplitAmount = 20.0m;
        decimal splitAmount = splitter.SplitAmount(totalAmount, numberOfPeople);
        Assert.AreEqual(expectedSplitAmount, splitAmount);
    }

    [TestMethod]
    public void SplitAmount_WhenNegativeNumberOfPeople_ThrowsArgumentException()
    {
        BillSplit splitter = new BillSplit();
        decimal totalAmount = 100.0m;
        int numberOfPeople = -5;
       Assert.ThrowsException<ArgumentException>(() => splitter.SplitAmount(totalAmount, numberOfPeople));
    }

    [TestMethod]
    public void SplitAmount_WhenZeroNumberOfPeople_ThrowsArgumentException()
    {
        BillSplit splitter = new BillSplit();
        decimal totalAmount = 100.0m;
        int numberOfPeople = 0;
        Assert.ThrowsException<ArgumentException>(() => splitter.SplitAmount(totalAmount, numberOfPeople));
    }
}
}