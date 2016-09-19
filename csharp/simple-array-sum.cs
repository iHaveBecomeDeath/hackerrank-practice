using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        Console.ReadLine();
        Console.Write(Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse).Sum());
    }
}
