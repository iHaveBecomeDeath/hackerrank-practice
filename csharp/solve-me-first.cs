using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        Console.WriteLine(new int[]{ReadLineInt(), ReadLineInt()}.Sum());
    }
    static int ReadLineInt() {
        return Convert.ToInt32(Console.ReadLine());
    }
}      
