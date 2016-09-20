using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
      var input = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
      var n = input[0] >= 1 ? input[0] <= 100000 ? input[0] : 100000 : 1;
      var k = input[1] >= 1 ? input[1] <= 100000 ? input[1] : 100000 : 1;
      var q = input[2] >= 1 ? input[2] <= 500 ? input[2] : 500 : 1;
      var rotArray = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

      for (var i = 0; i < k; i++){
        var tmpArray = new int[n];
        Array.Copy(rotArray, n-1, tmpArray, 0, 1);
        Array.Copy(rotArray, 0, tmpArray, 1, n-1);
        rotArray = tmpArray;
      }
      
      for (var i = 0; i < q; i++){
        var index = Convert.ToInt32(Console.ReadLine());
        index = index >= 0 ? index < n ? index : n-1 : 0; 
        Console.WriteLine(rotArray[index]);
      }
    }
}
