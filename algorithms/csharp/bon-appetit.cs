using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
      var courses = Console.ReadLine().Trim().Split(' ');
      var annaDidNotEat = int.Parse(courses[1]);
      var prices = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), int.Parse);
      var charged = int.Parse(Console.ReadLine().Trim());
      var annasShare = (prices.Sum() - prices[annaDidNotEat]) / 2;
      Console.WriteLine(charged > annasShare ? (charged - annasShare).ToString() : "Bon Appetit");
    }
}