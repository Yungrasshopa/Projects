using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAndTesting.Library
{
    /// <summary>
    /// A list with some extra helper methods
    /// </summary>
    /// <remarks>
    /// Two strategies we could use to leverage the builtin
    ///  collection classes:
    ///  - Inheritance (MyCollection IS a List)
    ///  - Composition (MyCollection HAS a List)
    /// </remarks>
    
    public class MyCollection<T>
    {
        // Readonly just means we can't reassign _list to a different
        //  object later. You can still modify the object with its methods
        private readonly List<string> _list = new List<string>();

        // Every class has at least one constructor
        //  if you do not define one it will give you 
        //  an empty default constructor without 
        //  any parameters

        public void Sort()
        {
            _list.Sort();
        }

        public void Add(string item)
        {
            _list.Add(item);
        }

        public int Length
        {
            get
            {
                return _list.Count;
            }
        }

        public string Get(int index)
        {
            return _list[index];
        }

        public string Longest()
        {

            if (Length == 0)
                return null;

            return _list.Where(a => a != null).Aggregate("", (max, cur) => max.Length >= cur.Length ? max : cur);
        }

        public double AverageLength()
        {
            return _list.Average(x => x.Length);
        }

        // Return number of elements that 
        //  start with an 'a'
        public int NumberOfAs()
        {
            return _list.Count(x => (x.Length > 0 && x[0] == 'a'));

            // Lambda expressions '=>' are like methods
            //  that you can pass as variables and assign tme to variables.
        }

        private static bool ContainsVowel(string s)
        {
            // Lambda expressions are convertible to "Func" or
            //  'Action" types so they can be assigned as variables like this:
            Func<char, bool> isVowel = (c => "AEIOUaeiou".Contains(c));
            return s.Any(
                x => "AEIOUaeiou".Contains(x)
                );
        }

        public int NumberWithVowels()
        {
            return _list.Count(ContainsVowel);
        }

        // LINQ and IEnumerableuses "deferred execution"
        public string FirstAlphabetical()
        {
            // Orderby will sort the sequence by some 'key
            //  as x => x means sort the strings using regular
            //  string sort
            IEnumerable<string> sorted = _list.OrderBy(x => x);

            // Runs the sort then discards everything but first
            //  entry.
            var first = sorted.First();

            return first;
        }

    }
}
