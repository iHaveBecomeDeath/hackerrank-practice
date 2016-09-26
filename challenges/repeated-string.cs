using System;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var startingString = Console.ReadLine().ToArray();
        var numberOfChars = Convert.ToInt64(Console.ReadLine());
        var amountOfAs = startingString.Count(x => x == 'a');
        var remainder = numberOfChars % startingString.Length;
        if (remainder == 0)
        {
            Console.WriteLine(numberOfChars / startingString.Length * amountOfAs);
        }
        else
        {
            var resultWithWrongAmountOfAs = Math.Floor(((double)numberOfChars / startingString.Length)) * amountOfAs;
            var correctResult = new string(startingString)
              .Substring(0, Convert.ToInt32(remainder)).Count(x => x == 'a')
              + resultWithWrongAmountOfAs;
            Console.WriteLine(correctResult);
        }
    }
}
