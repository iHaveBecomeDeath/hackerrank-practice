using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
      Console.ReadLine();
      Console.WriteLine(Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).Sum());
    }
}
