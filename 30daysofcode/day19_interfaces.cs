// HackerRank "30 Days of Code" - Day 19 - Interfaces

using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

// ------[ Solution code begins here ]------------------------------------------

// ------[ Solution code ends here ]--------------------------------------------

class Solution
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
    }
}
