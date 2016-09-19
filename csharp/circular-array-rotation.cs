using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
      var inputnkq = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
      var rotArray = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
      for (var i = 0; i < inputnkq[1]; i++){
        rotArray = new int[]{rotArray[rotArray.Length-1]}.Concat(rotArray.Take(rotArray.Length-1)).ToArray();
      }
      for (var i = 0; i < inputnkq[2]; i++){
        Console.WriteLine(rotArray[Convert.ToInt32(Console.ReadLine())]);
      }
    }
}
