// HackerRank "Algorithms" - Simple Array Sum

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
  static void Main()
  {
    Console.ReadLine();
    Console.WriteLine(Console.ReadLine()
		  .Split(' ')
			.Select(s=>Convert.ToInt32(s))
			.Sum()
		);
  }
}
