using System;
using System.Collections.Generic;

namespace linq
{
    public static class Extensions
    {
	public static bool SequenceEquals<T>(this IEnumerable<T> first, IEnumerable<T> second)
	{
		var firstIter = first.GetEnumerator();
		var secondIter = second.GetEnumerator();

		while(firstIter.MoveNext() && secondIter.MoveNext())
		{
			if (!firstIter.Current.Equals(secondIter.Current))
			{
				return false;
			}
		}
		return true;
	}
        public static IEnumerable<T> InterleaveSequenceWith<T>
            (this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while(firstIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }
    }    
}
