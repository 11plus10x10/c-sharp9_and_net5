using System;
using System.Collections.Generic;

namespace PacktLibrary
{
    // GenericThing could be any type that implements IComparable.
    public class GenericThing<T> where T : IComparable
    {
        // Field.
        public T Data = default(T);
        
        // Method.
        public string Process(T input)
        {
            return Data.CompareTo(input) == 0 ? "Data and input are the same." : "Data and input are not the same.";
        }
    }
}