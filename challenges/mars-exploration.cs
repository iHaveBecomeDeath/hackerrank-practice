using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
  static void Main(String[] args) {
    var s = Console.ReadLine();
    var numberOfSOSes = s.Length / 3;
    for (var i = 0; i < numberOfSOSes; i+=3)
    var changedLetters = 
      numberOfSOSes - s.Count(x => x == 'O')
      + numberOfSOSes * 2 - s.Count(x => x == 'S');
    Console.WriteLine(changedLetters);
  }
}
