
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Fact]
    public void addTwoNumbers()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("3,4");
        Assert.Equal(7, result);
    }
    [Fact]
    public void addMoreThanTwoNumbers()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("3,4,5,6");
        Assert.Equal(18, result);
    }
}
