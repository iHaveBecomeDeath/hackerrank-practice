using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
      var tokens_n = Console.ReadLine().Split(' ');
      var amountOfValues = Convert.ToInt32(tokens_n[0]);
      var divisionFactor = Convert.ToInt32(tokens_n[1]);
      var values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      var matches = 0;
      
      for (var i = 0; i < amountOfValues-1; i++) {
        for (var j = i + 1; j < amountOfValues; j++) {
          if ((values[i] + values[j]) % divisionFactor == 0)
            matches++;
        }
      }
      
      Console.WriteLine(matches);
    }
}
