// HackerRank "30 Days of Code" - Day 21 - Generics

using System;

public class Solution
{

// ------[ Solution code begins here ]------------------------------------------

  public static void printArray<T>(T[] values)
  {
    foreach(T value in values) Console.WriteLine(value);
  }

// ------[ Solution code ends here ]--------------------------------------------

  static void Main(string[] args)
  {
    int[] vInt = new int[] {1, 2, 3};
    string[] vString = new string[] {"Hello", "World"};

    printArray<int>(vInt);
    printArray<string>(vString);
  }
}
