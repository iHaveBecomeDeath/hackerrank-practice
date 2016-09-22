using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        var input = Console.ReadLine().Split(' ');
        var kangaroos = new List<Kangaroo>
        {
            new Kangaroo { XPosition = int.Parse(input[0]), Velocity = int.Parse(input[1]) },
            new Kangaroo { XPosition = int.Parse(input[2]), Velocity = int.Parse(input[3]) }
        };
        
        if (kangaroos.First().NextPosition > kangaroos.Second().NextPosition)
        {
            kangaroos.Reverse();
        }
        var collision = false;
        if (!kangaroos.First().CannotCatchUpTo(kangaroos.Second()))
        {
            while (kangaroos.First().XPosition <= kangaroos.Second().XPosition)
            {
                kangaroos.First().Jump();
                kangaroos.Second().Jump();
                if (kangaroos.First().XPosition == kangaroos.Second().XPosition)
                {
                    collision = true;
                    break;
                }
            }
        }
        Console.WriteLine(collision ? "YES" : "NO");
    }

    class Kangaroo
    {
        public int XPosition { get; set; }
        public int Velocity { get; set; }
        public int NextPosition => XPosition + Velocity;
        public void Jump()
        {
            XPosition += Velocity;
        }
        public bool CannotCatchUpTo(Kangaroo opponent)
        {
            return (XPosition <= opponent.XPosition && Velocity < opponent.Velocity) || 
              (XPosition < opponent.XPosition && Velocity <= opponent.Velocity);
        }
    }
}

public static class Extensions
{
    public static T Second<T>(this IEnumerable<T> list)
    {
        return list.Skip(1).First();
    }
}
