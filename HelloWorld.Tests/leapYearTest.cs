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
        
        var stringReader = new StringReader("1600");
        Console.SetIn(stringReader);

        result.Should().Be("yay");
    }
    [Fact]
    public void returns_nay_if_given_non_leap_year(){
        var leap = new leapYear();

        var result = leap.UserInput();

        var stringReader = new StringReader("1900");
        Console.SetIn(stringReader);

        result.Should().Be("nay");
    }
    */
}