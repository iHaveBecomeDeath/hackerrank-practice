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
        for (var i = 0; i < alice.Count(); i++) {
            var curA = Convert.ToInt32(alice[i]);
            var curB = Convert.ToInt32(bob[i]);            
            if (curA > curB)
                a++;
            else if (curA < curB)
                b++;
        }
        Console.Write($"{a} {b}");
    }
}
