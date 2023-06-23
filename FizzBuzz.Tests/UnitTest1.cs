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
}

public static class FizzBuzzGame
{
    public static string Play(int i)
    {
        return i.ToString();
    }
}