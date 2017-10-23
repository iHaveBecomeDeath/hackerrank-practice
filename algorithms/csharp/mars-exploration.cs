using System;
using System.Linq;

class Solution {
  static void Main(String[] args) {
    const int sosLength = 3;
    var s = Console.ReadLine().ToArray();
    var changedLetters = 0;
    for (var i = 0; i < s.Length; i+=sosLength) {
      for (var j = 0; j < sosLength; j++){
        var comparisonChar = j == 0 || j % 2 == 0 ? 'S' : 'O';
        changedLetters += s[i+j] == comparisonChar ? 0 : 1;
      }
    }
    Console.WriteLine(changedLetters);
  }
}
