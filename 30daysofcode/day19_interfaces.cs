// HackerRank "30 Days of Code" - Day 19 - Interfaces

using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

// ------[ Solution code begins here ]------------------------------------------

public class Calculator : AdvancedArithmetic
{
  public int divisorSum(int n)
  {
    if(n <= 1) return n;

    var result = n + 1;
    for (int i = 2; i < n; i++)
    {
      if (n % i == 0) result += i;
    }
    return result;
  }
}

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
