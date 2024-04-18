using System;
namespace BillLibrary
{
public class TipBillCalc
{
    public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
    {
        if (price <= 0)
        {
            throw new ArgumentException("Price must be greater than zero.", nameof(price));
        }

        if (numberOfPatrons <= 0)
        {
            throw new ArgumentException("Number of patrons must be greater than zero.", nameof(numberOfPatrons));
        }

        if (tipPercentage < 0 || tipPercentage > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(tipPercentage), "Tip percentage must be between 0 and 100.");
        }

        decimal totalTip = price * (decimal)(tipPercentage / 100);
        decimal tipPerPerson = totalTip / numberOfPatrons;

        return tipPerPerson;
    }
}
}