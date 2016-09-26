using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
class Solution {

  static void Main(String[] args) {
    var startingString = Console.ReadLine().ToArray();
    var numberOfChars = Convert.ToInt64(Console.ReadLine());
    if (startingString.Count(x => x == 'a') == startingString.Length){
      Console.WriteLine(numberOfChars);
    } else {
      var arr = new char[numberOfChars];
      long copyLength = startingString.Length;
      long totalCopied = 0;
      Array.Copy(startingString, arr, startingString.Length);
      totalCopied = copyLength;
      while (totalCopied < numberOfChars){        
        copyLength = numberOfChars < copyLength + totalCopied
          ? numberOfChars - totalCopied
          : copyLength;
        Array.Copy(arr, 0, arr, totalCopied, copyLength);
        totalCopied += copyLength;
      }
      Console.WriteLine(arr.Count(x => x == 'a'));
    }
  }
} 
