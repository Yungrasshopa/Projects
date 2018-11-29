using System;
using System.Collections.Generic;

namespace Collections
{
    // internal default
    class Program
    {
        static void Main(string[] args) // memebers are defaulted to private
        {
            Arrays();
            Sets();
            StringEquality();
            Dictionaries();
        }

        static void Arrays()
        {
            // Filled by defaut with 0's for int
            int[] intArray = new int[10];
            // intArray has 10 values of 0
            // null for objects, 0 for ints, false for bool
            Console.WriteLine(intArray[3]);

            // Iterate over arrays with regular for loop or foreach
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write(intArray[i]);
            }
            Console.WriteLine();

            // You can use foreach loop with anything implementing 
            //  IEnumerable interface
            foreach (var item in intArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            // Jagged / nested arrays
            int[][] arrayOfFourArrays = new int[4][];
            // Array of 4 nulls
            //Console.WriteLine(arrayOfFourArrays[0][0]); // exception
            arrayOfFourArrays[0] = new int[3];

            // Multi-dimensional arrays (rectangular, never jagged)
            int[,] trueMultiDArray = new int[5, 5];
            // This is filled with 25 zeroes; index row/col
            trueMultiDArray[3, 4] = 5;

            // Generally use generic collection classes for 
            //  most array based needs.

            // Length is inferred
            int[] array = new int[]
            {
                1, 2, 3, 4, 5
            };
        }

        static void Lists()
        {
            var list = new List<bool>();
            list.Add(true);
            list.Add(true);
            list.Add(false);

            // Lists have dynamic length. They grow
            //  and shrink as you add values

            var list2 = new List<bool>() { false, false, false };
            list2.AddRange(list);

            // Indexable just like arrays
            var x = list2[2];
            list[1] = true;
            // Also foreach-able
        }

        static void Sets()
        {
            var set = new HashSet<string>();
            // Sets have no order to them. Do not
            //  allow duplicates

            // Adding an existing element does nothing.

            set.Add("abc");
            set.Add("abc");
            set.Add("def");

            // Should print 2.
            Console.WriteLine(set.Count);

            // Based on mathematical concept of "set"
            // standard: union, intersecton and difference

            // Sets are fast to search for specific values
            //  even with large numbers of items in the set
            //  because it's implemented with a "hashtable"

            // Slower to iterate over than list.
            // Fast lookup times
        }

        static void Dictionaries()
        {
            var dict = new Dictionary<string, string>();

            dict.Add("Germany", "Berlin");
            dict.Add("USA", "Washington, DC");

            // You can use index syntax with dictionaries
            Console.WriteLine(dict["USA"]);

            dict["Mexico"] = "Mexico City";


            // Dictionary initialization syntax
            var dict2 = new Dictionary<string, string>
            {
                { "Germany", "Berlin" },
                { "USA", "Washington, DC" }
            };

            // foreaching dictionaries
            foreach (var key in dict.Keys)
            {

            }
            foreach (var value in dict.Values)
            {

            }
            foreach (KeyValuePair<string, string> pair in dict)
            {
                // pair.Key
                // pair.Value
            }

        }

        static void StringEquality()
        {
            // in some languages, == means "references the same object in memeory"
            // .Equals is for "references an equivalent object
            bool stringsEqual = "abc" == "abc";
            Console.WriteLine(stringsEqual);

            // In C# strings with == compare value, not reference.
            // We have operator overloading in C# though we don't use it much
            // and you can override == to do value comaprison too on your classes



            // For basically all reference types except string, == compares
            //  the exact same object yes or no
            Console.WriteLine(new Dummy() == new Dummy()); // Prints false
            
        }
        
        public class Dummy { }
    }
}
