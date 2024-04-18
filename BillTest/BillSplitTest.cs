using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        // Arrange
        BillSplit splitter = new BillSplit();
        decimal totalAmount = 100.0m;
        int numberOfPeople = 5;
        decimal expectedSplitAmount = 20.0m;

        // Act
        decimal splitAmount = splitter.SplitAmount(totalAmount, numberOfPeople);

        // Assert
        Assert.AreEqual(expectedSplitAmount, splitAmount);
    }

    [TestMethod]
    public void SplitAmount_WhenNegativeNumberOfPeople_ThrowsArgumentException()
    {
        // Arrange
        BillSplit splitter = new BillSplit();
        decimal totalAmount = 100.0m;
        int numberOfPeople = -5;

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => splitter.SplitAmount(totalAmount, numberOfPeople));
    }

    [TestMethod]
    public void SplitAmount_WhenZeroNumberOfPeople_ThrowsArgumentException()
    {
        // Arrange
        BillSplit splitter = new BillSplit();
        decimal totalAmount = 100.0m;
        int numberOfPeople = 0;

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => splitter.SplitAmount(totalAmount, numberOfPeople));
    }
}
}