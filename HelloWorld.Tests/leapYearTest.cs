namespace HelloWorld.Tests;

public class leapYearTest
{
    [Fact]
    public void returns_true_if_given_leap_year()
    {
        //arrange
        var leap = new leapYear();

        //act
        var result = leap.IsLeapYear(1600);
        var resultTwo = leap.IsLeapYear(1900);

        //assert
        result.Should().Be(true);
        resultTwo.Should().Be(false);

    }
    /*
    [Fact]
    public void returns_yay_if_given_leap_year(){
        var leap = new leapYear();

        var result = leap.UserInput();

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        var stringReader = new StringReader("1600");
        Console.SetIn(stringReader);

        result.Should().Be("yay");
    }
    [Fact]
    public void returns_nay_if_given_non_leap_year(){
        var leap = new leapYear();

        var result = leap.UserInput();

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        
        var stringReader = new StringReader("1900");
        Console.SetIn(stringReader);

        result.Should().Be("nay");
    }
    */
     [Fact]
    public void is_divisible_by_four_unless_also_by_100_unless_divisible_by_400()
    {
        var leap = new leapYear();

        var result = leap.IsLeapYear(1600);
        result.Should().Be(true);
    }
    [Fact]
    public void above_or_below_1582(){
        var leap = new leapYear();

        var on = leap.IsLeapYear(1582);
        Action under = () => leap.IsLeapYear(1500);
        on.Should().Be(false);
        under.Should().Throw<ArgumentException>();
    }
}