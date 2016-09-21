using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
  
  static int[] GetStringSimilarity (string s) {
    var len = s.Length;
    var z = new int[len];
    for (int i = 0, left = 0, right = 0; i < len; ++i) {
        if (i <= right)
            z[i] = Math.Min(right - i + 1, z[i - left]);
        while (i + z[i] < len && s[z[i]] == s[i + z[i]])
            ++z[i];
        if (i + z[i] - 1 > right){
            left = i;
            right = i + z[i] - 1;
        }
    }
    return z;
  }

 
  static void Main(String[] args) {
    var testCases = Convert.ToInt32(Console.ReadLine());
      for (var _t_i = 0; _t_i < testCases; _t_i++) {
        Console.WriteLine(GetStringSimilarity(Console.ReadLine()).Sum());
      }
    }
}
