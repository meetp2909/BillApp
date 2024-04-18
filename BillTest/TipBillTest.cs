using System;
using BillLibrary;

namespace BillTest
{
[TestClass]
public class TipBillTest
{
    private const decimal Tolerance = 100.01m; 
    [TestMethod]
    public void CalculateTip_WhenValidArguments_ReturnsCorrectTipAmounts()
    {
        var mealCosts = new Dictionary<string, decimal>
        {
            { "Alice", 25.0m },
            { "Bob", 30.0m },
            { "Charlie", 20.0m }
        };
        float tipPercentage = 15.0f;
        var expectedTipAmounts = new Dictionary<string, decimal>
        {
            { "Alice", 11.25m },
            { "Bob", 13.50m },
            { "Charlie", 9.00m }
        };
        TipBill calculator = new TipBill();
        var tipAmounts = calculator.CalculateTip(mealCosts, tipPercentage);
        foreach (var kvp in expectedTipAmounts)
        {
            Assert.AreEqual(kvp.Value, tipAmounts[kvp.Key], Tolerance);
        }
    }
}
}