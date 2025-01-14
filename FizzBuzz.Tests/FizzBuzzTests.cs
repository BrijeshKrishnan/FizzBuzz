using FluentAssertions;
namespace FizzBuzz.Tests;

// Given an integer, return a string where:
//
// "FizzBuzz" if number is divisible by 3 and 5
// "Fizz" if number is divisible by 3 
// "Buzz" if number is divisible by 5
// number (string) if none of the above condition are true

public class FizzBuzzTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void GivenANumberNotDivisibleBy3or5_ThenReturnsNumberAsString(int number)
    {
        string result = FizzBuzzGame.Play(number);
        result.Should().Be(number.ToString());
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void GivenANumberDivisibleby5_ThenReturnBuzz(int number)
    {
        var result = FizzBuzzGame.Play(number);
        result.Should().Be("Buzz");
    }
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void GivenANumberDivisibleby5_ThenReturnFizz(int number)
    {
        var result = FizzBuzzGame.Play(number);
        result.Should().Be("Fizz");
    }
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(60)]
    public void GivenANumberDivisibleby3and5_ThenReturnFizzBuzz(int number)
    {
        var result = FizzBuzzGame.Play(number);
        result.Should().Be("FizzBuzz");
    }
}