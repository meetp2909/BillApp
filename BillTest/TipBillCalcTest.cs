using BillLibrary;


namespace BillTest
{
[TestClass]
public class TipBillCalcTest
{
    [TestMethod]
    public void CalculateTipPerPerson_WhenValidInput_ReturnsCorrectTipPerPerson()
    {
        decimal price = 100.0m;
        int numberOfPatrons = 5;
        float tipPercentage = 15.0f;
        decimal expectedTipPerPerson = 3.0m;
        TipBillCalc calculator = new TipBillCalc();

        decimal tipPerPerson = calculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);
         Assert.AreEqual(expectedTipPerPerson, tipPerPerson);
    }

    [TestMethod]
    public void CalculateTipPerPerson_WhenZeroPrice_ThrowsArgumentException()
    {
        decimal price = 0m;
        int numberOfPatrons = 5;
        float tipPercentage = 15.0f;
        TipBillCalc calculator = new TipBillCalc();
        Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage));
    }

    [TestMethod]
    public void CalculateTipPerPerson_WhenNegativeNumberOfPatrons_ThrowsArgumentException()
    {
        decimal price = 100.0m;
        int numberOfPatrons = -5;
        float tipPercentage = 15.0f;
        TipBillCalc calculator = new TipBillCalc();
      Assert.ThrowsException<ArgumentException>(() => calculator.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage));
    }
}
}