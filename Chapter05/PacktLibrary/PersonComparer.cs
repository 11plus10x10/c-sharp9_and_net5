using System.Collections.Generic;

namespace PacktLibrary
{
    /// <summary>
    /// Provides an IComparer interface to Person Class.
    /// Comparison goes by length and if it's equal than by Name.
    /// </summary>
    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // Comparing the Name field lengths
            var result = x.Name.Length
                .CompareTo(y.Name.Length);
            
            // If they are equal compare them by Names, else return result.
            return result == 0 ? x.Name.CompareTo(y.Name) : result;
        }
    }
}
