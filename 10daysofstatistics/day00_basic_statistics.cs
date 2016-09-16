// HackerRank "10 Days of Statistics" - Day 00 - Basic Statistics

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static int count = 0;
    static int[] values;
  
    static void Main(String[] args)
    {
      count = int.Parse(Console.ReadLine());
      values = Console.ReadLine().Split(' ').ToList().Select(x=>int.Parse(x)).OrderBy(x=>x).ToArray();                 
      
      Console.WriteLine(Math.Round(GetMean(), 1));
      Console.WriteLine(Math.Round(GetMedian(), 1));
      Console.WriteLine(GetMode());
    }
  
   static double GetMean() => count == 0 ? 0 : values.Sum() / (double)count;   
  
   static double GetMedian()
   {     
     if(count == 0) return 0;
     var medianIndex = (int)(count / 2);     
     if(count % 2 == 1) return values[medianIndex];          
     return (values[medianIndex] + values[medianIndex-1]) / 2f;
   }
  
   static int GetMode() => count == 0 ? 0 : values
     .GroupBy(x=>x)
     .OrderByDescending(group=>group.Count())
     .ThenBy(group=>group.Key)
     .First().Key;
}