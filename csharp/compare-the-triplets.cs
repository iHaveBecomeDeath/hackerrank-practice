using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] alice = Console.ReadLine().Split(' ');
        string[] bob = Console.ReadLine().Split(' ');
        var a = 0;
        var b = 0;
        for (var i = 0; i < 3; i++) {
            var curA = Convert.ToInt32(alice[i]);
            var curB = Convert.ToInt32(bob[i]);            
            if (curA > curB)
                a += 1;
            else if (curA < curB)
                b += 1;
        }
        Console.Write($"{a} {b}");
    }
}
