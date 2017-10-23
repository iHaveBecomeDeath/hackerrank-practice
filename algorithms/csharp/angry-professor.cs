using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

  static void Main(String[] args) {
    var testCases = Convert.ToInt32(Console.ReadLine());
    for(var i = 0; i < testCases; i++){
      var threshold = Convert.ToInt32(Console.ReadLine().Split(' ')[1]);
      var arrivalTimes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

      Console.WriteLine(arrivalTimes.Count(a => a <= 0) < threshold ? "YES" : "NO");
    }
  }
}
