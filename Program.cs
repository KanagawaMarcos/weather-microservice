using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
		
	            var startingDeck =  from s in Suits()
        	                        from r in Ranks()
                	                select new { Suit = s, Rank = r };
           	    var shuffle = startingDeck;
		    var times = 0;
		do
		{
		    shuffle = shuffle.Take(26).InterleaveSequenceWith(shuffle.Skip(26));

	            foreach (var c in shuffle)
        	    {
                	Console.WriteLine(c);
            	    }

		    Console.WriteLine();
		    times++;
		}while(!startingDeck.SequenceEquals(shuffle));

		Console.WriteLine(times);
        }
        
        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
