using System;
namespace BillLibrary
{

public class BillSplit
{
    public decimal SplitAmount(decimal totalAmount, int numberOfPeople)
    {
        if (numberOfPeople <= 0)
        {
            throw new ArgumentException("Number of people must be greater than zero.");
        }

        return totalAmount / numberOfPeople;
    }
}
}