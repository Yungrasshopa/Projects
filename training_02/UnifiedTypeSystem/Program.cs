using System;

namespace UnifiedTypeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value type; two copies of the 
            //  number 1
            int a = 1;
            int b = a;

            // Reference type only on copy of the string
            //  "hello" with two references to it.
            //  Each variable of a reference type might all
            //  be pointing to the same object.

            string c = "hello";
            string d = c; // This is a new reference to the same value
        }
    }
}
