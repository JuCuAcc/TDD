# Solving FizzBuzz Problem Using TDD

# Problem

Given an integer, return a string where:<br/>
**"FizzBuzz"** if number is divisible by **3** and **5**.<br/>
**"Fizz"** if number is divisible by **3**.<br/>
**"Buzz"** if number is divisible by **5**.<br/>
number (as a string) if none of the above conditions are true.
<br/>

---

Implementation of the FizzBuzz problem using Test-Driven Development (TDD) in C#. Let's go through the code and explain its different components.


## Tests

```csharp
using FluentAssertions;
namespace FizzBuzz.Tests;

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

```
First, we have the test code, which is located within the **FizzBuzz.Tests** namespace. The test class is named **FizzBuzzTests**. It contains several test methods, each decorated with the **[Theory]** attribute, which indicates that they are parameterized tests. The test methods verify the behavior of the **FizzBuzzGame.Play()** method for different input numbers.

1. The **GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString** test verifies that if the number is not divisible by 3 or 5, the **Play()** method should return the number as a string. It uses the **InlineData** attribute to specify different input numbers for the test.

2. The **GivenANumberDivisibleBy5_ThenReturnsBuzz** test checks that if the number is divisible by 5, the **Play()** method should return "Buzz".

3. The **GivenANumberDivisibleBy3_ThenReturnsFizz** test ensures that if the number is divisible by 3, the **Play()** method should return "Fizz".

4. The **GivenANumberDivisibleBy15_ThenReturnsFizzBuzz** test verifies that if the number is divisible by both 3 and 5 (i.e., 15), the **Play()** method should return "FizzBuzz".
---

Now let's move on to the solution code, which is located within the **FizzBuzz** namespace. The solution contains a static class named **FizzBuzzGame**, which provides the **Play()** method for solving the FizzBuzz problem.

---


## Solution

```csharp
namespace FizzBuzz
{
    public static class FizzBuzzGame
    {
        public static string Play(int number)
        {
            // Using switch
            return number switch
            {
                _ when number.IsDivisibleBy(15)
                => "FizzBuzz",
                _ when number.IsDivisibleBy(3)
                => "Fizz",
                _ when number.IsDivisibleBy(5)
                => "Buzz",
                _ => number.ToString()
            };

        }

        public static bool IsDivisibleBy(
            this int i, int divisibleBy)
            => i % divisibleBy == 0;
    }
}
```
1. The **Play()** method takes an integer **number** as input and returns a string based on certain conditions. It uses a switch statement to determine the appropriate string to return.

2. The switch statement contains four cases:

    * The first case checks if the number is divisible by 15 (i.e., both 3 and 5) using the **IsDivisibleBy()** extension method. If true, it returns "FizzBuzz".
    * The second case checks if the number is divisible by 3. If true, it returns "Fizz".
    * The third case checks if the number is divisible by 5. If true, it returns "Buzz".
    * The default case is reached when none of the above conditions are true, and it simply returns the number as a string.

3. The **IsDivisibleBy()** extension method is defined for the **int** type. It checks if an integer is divisible by a given **divisibleBy** value by performing the modulo operation (%) and comparing the result to zero. If the remainder is zero, it means the number is divisible, and the method returns **true**; otherwise, it returns **false**.    
---
<br/>

The screenshots show the execution steps of the test cases and their outcomes. It shows that the code has been tested successfully, as all the tests have passed.

---


![Steps](<Screenshots/1 (1).png>)
![Steps](<Screenshots/1 (2).png>)
![Steps](<Screenshots/1 (3).png>)
![Steps](<Screenshots/1 (4).png>)
![Steps](<Screenshots/1 (5).png>)
![Steps](<Screenshots/1 (6).png>)
![Steps](<Screenshots/1 (7).png>)
![Steps](<Screenshots/1 (8).png>)
![Steps](<Screenshots/1 (9).png>)
![Steps](<Screenshots/1 (10).png>)
![Steps](<Screenshots/1 (11).png>)
![Steps](<Screenshots/1 (12).png>)
![Steps](<Screenshots/1 (13).png>)
![Steps](<Screenshots/1 (14).png>)
![Steps](<Screenshots/1 (15).png>)

---

Overall, this code demonstrates the use of Test-Driven Development (TDD) to solve the FizzBuzz problem in C#. By writing the tests first and then implementing the solution code, developers can ensure that their code meets the specified requirements and behaves correctly for different scenarios.

---
