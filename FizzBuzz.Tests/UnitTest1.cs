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
    [Fact]
    public void GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString()
    {
        string result = FizzBuzzGame.Play(i: 1);
        result.Should().Be("1");
    }
}

public static class FizzBuzzGame
{
    public static string Play(int i)
    {
        return "1";
    }
}