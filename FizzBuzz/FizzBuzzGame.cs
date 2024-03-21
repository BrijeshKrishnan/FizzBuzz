using System.Runtime.InteropServices.JavaScript;

namespace FizzBuzz;

public static class FizzBuzzGame
{
    public static string Play(int i)
    {
        return i switch
        {
            _ when i.IsDivisibleBy(15)
                => "FizzBuzz",
            _ when i.IsDivisibleBy(3)
                => "Fizz",
            _ when i.IsDivisibleBy(5)
                => "Buzz",
            _ => i.ToString()
        };
        // if (i.IsDivisibleBy(3) && i.IsDivisibleBy(5)) //if (i.IsDivisibleBy(15)
        //     return "FizzBuzz";
        // if (i.IsDivisibleBy(3))
        //     return "Fizz";
        // if (i.IsDivisibleBy(5))
        //     return "Buzz";
        // return i.ToString();
    }

    private static bool IsDivisibleBy(this int i, int divisibleBy) => i % divisibleBy == 0;
}