// HackerRank "30 Days of Code" - Day 21 - Generics

using System;

public class Solution
{

// ------[ Solution code begins here ]------------------------------------------

// ------[ Solution code ends here ]--------------------------------------------

  static void Main(string[] args)
  {
    int[] vInt = new int[] {1, 2, 3};
    string[] vString = new string[] {"Hello", "World"};

    printArray<int>(vInt);
    printArray<string>(vString);
  }
}
