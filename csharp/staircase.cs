using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
      int stairSize = Convert.ToInt32(Console.ReadLine());
      for (var i = 1; i <= stairSize; i++){
        Console.WriteLine($"{new string(' ', stairSize - i)}{new string('#', i)}");
      }
    }
}
