using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution {

    static void Main(String[] args) {
      var input = Console.ReadLine();
      var words = Regex.Replace(input, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
      Console.WriteLine(words.Split(' ').Count());
    }
}
