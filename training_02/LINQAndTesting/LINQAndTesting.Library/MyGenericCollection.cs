using System;
using System.Collections.Generic;
using System.Text;

namespace LINQAndTesting.Library
{

    // Type parameter constraints
    //  MyGnericCollection<T> where T : sometype
    //  new() require default constructor
    class MyGenericCollection<T> where T: new()
    {
        private List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);

            _list.Add(new T());
            // not allowed unless we put 
            // new() constraint where T is declared
        }

        // Generic Methods
        public static bool Compare<T1, T2>(T1 first, T2 second)
        {
            return first.Equals(second);
        }

    }
}
