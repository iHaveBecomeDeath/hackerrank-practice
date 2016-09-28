using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
      var cloudCount = Convert.ToInt32(Console.ReadLine());
      var clouds = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
      
      var position = 0;
      var jumps = 0;
      
      while (position < clouds.Length-1) {
        if (clouds.Length > position +2) { // possibly jump an extra step
          position += clouds[position + 2] == 1
            ? 0
            : 1;
        }
        position++; // always jump at least one step
        jumps++; // one jump per loop
      }
      
      Console.WriteLine(jumps);
    }
}
