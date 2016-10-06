// HackerRank "30 Days of Code" - Day 14 - Scope

using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

// ------[ Solution code begins here ]------------------------------------------

  public Difference(int[] elements)
  {
    this.elements = elements;
  }
  public void computeDifference() =>
    maximumDifference = elements.Max() - elements.Min();

// ------[ Solution code ends here ]--------------------------------------------

} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}
