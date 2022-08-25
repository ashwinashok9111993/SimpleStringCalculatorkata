using SimpleStringCalculator;
namespace SimpleStringCalculator.Tests;

public class SimpleStringCalculatorTest
{
    // Expect 0 for empty string output
    [Fact]
    public void empty_string_test()
    {
        var expected_output = StringCalculator.add_from_string(string.Empty);
        Assert.Equal(expected_output,0) ;
    }

    [Fact]
    public void one_input_string()
    {
        var expected_output = StringCalculator.add_from_string("1");
        Assert.Equal(expected_output,1);
    }

    [Fact]
    public void two_input_string()
    {
        var expected_output = StringCalculator.add_from_string("1,2");
        Assert.Equal(expected_output, 3);
    }
}