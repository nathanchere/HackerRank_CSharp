// HackerRank "30 Days of Code" - Day 16 - Exceptions: String To Integer

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string S = Console.ReadLine();
        try
        {
          Console.WriteLine(Int32.Parse(S));
        }
        catch
        {
          Console.WriteLine("Bad String"); // ima smack your bum
        }
    }
}
