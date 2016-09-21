using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
  const string formatString = "0.000000";
  
  static void Main(String[] args) {
    int count = Convert.ToInt32(Console.ReadLine());
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
    var negsFraction = GetFractionWithSixDecimals(arr.Count(x => x < 0), count);
    var posFraction = GetFractionWithSixDecimals(arr.Count(x => x > 0), count);
    var zeroesFraction = GetFractionWithSixDecimals(arr.Count(x => x == 0), count);
    Console.Write($"{posFraction}\r\n{negsFraction}\r\n{zeroesFraction}");
  }
  
  static string GetFractionWithSixDecimals(int part, int total){
    return ((decimal)part/total).ToString(formatString);   
  }
}
