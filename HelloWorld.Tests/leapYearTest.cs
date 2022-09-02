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
}