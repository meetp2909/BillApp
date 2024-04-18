using System;
namespace BillLibrary
{
public class TipBill
{
    public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
    {
        if (mealCosts == null)
        {
            throw new ArgumentNullException(nameof(mealCosts), "Meal costs dictionary cannot be null.");
        }

        if (tipPercentage < 0 || tipPercentage > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(tipPercentage), "Tip percentage must be between 0 and 100.");
        }

        var tipAmounts = new Dictionary<string, decimal>();

        decimal totalCost = 0;

        foreach (var kvp in mealCosts)
        {
            totalCost += kvp.Value;
        }

        decimal tipTotal = totalCost * (decimal)(tipPercentage / 100);

        foreach (var kvp in mealCosts)
        {
            decimal individualTip = Math.Round(kvp.Value / totalCost * tipTotal, 2);
            tipAmounts.Add(kvp.Key, individualTip);
        }

        return tipAmounts;
    }
}
}