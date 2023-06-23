using FluentAssertions;

namespace FizzBuzz.Tests;

// Given an integer, return a string where:
//
// "FizzBuzz" if number is divisible by 3 and 5.
// "Fizz" if number is divisible by 3.
// "Buzz" if number is divisible by 5.
// number (as a string) if none of the above conditions are true.


public class FizzBuzzTests
{

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(7)]
    public void GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString(int number)
    {
        string result = FizzBuzzGame.Play(number);
        result.Should().Be(number.ToString());
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void GivenANumberDivisibleBy5_ThenReturnsBuzz(int number)
    {
        var result = FizzBuzzGame.Play(number);
        result.Should().Be("Buzz");
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GivenANumberDivisibleBy3_ThenReturnsFizz(int number)
    {
        var result = FizzBuzzGame.Play(number);
        result.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(60)]
    public void GivenANumberDivisibleBy15_ThenReturnsFizzBuzz(int number)
    {
        var result = FizzBuzzGame.Play(number);
        result.Should().Be("FizzBuzz");
    }
}
