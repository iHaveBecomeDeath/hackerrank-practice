using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
      var amountOfSticks = Convert.ToInt32(Console.ReadLine());
      var sticks = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      
      while (sticks.Count() > 0) {
        Console.WriteLine(sticks.Count());
        sticks = sticks.Select(s => s - sticks.Min()).Where(st => st > 0).ToArray();
      }
    }
}
