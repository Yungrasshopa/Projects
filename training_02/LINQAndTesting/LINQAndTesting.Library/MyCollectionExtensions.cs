using System;
using System.Collections.Generic;
using System.Text;

namespace LINQAndTesting.Library
{
    // C# supports adding methods to classes that 
    //  are already defined even the framework's 
    //  classes liek List<> or string<>
    public static class MyCollectionExtensions
    {
        public static bool Empty(this MyCollection coll)
        {
            return coll.Length == 0;
        }
        /***** Extension Methods *****/
        // As long as someone has a using statement to this namespace
        //  every MyCollection they see will have this extra method on it
        
    }
}
