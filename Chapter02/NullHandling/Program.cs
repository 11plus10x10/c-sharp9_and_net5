// #nullable enable

using System;

namespace NullHandling
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    
    class Program
    {
        static void Main()
        {
            var thisCannotBeNull = 4;
            // thisCannotBeNull = null;
            
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            
            var address = new Address
            {
                Region = null,
                City = "London",
                Street = null,
                Building = null
            };
            
            // Check that the variable is not null before using it.
            if (thisCouldBeNull != null)
            {
                // Access a member of thisCouldBeNull.
                // Could throw exception
                int length = thisCouldBeNull.Value;
            }

            string authorName = null;

            // The following throws a NullReferenceException.
            var x = authorName.Length;
            
            // Instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;
            
            // Or I can use null-coalescing operator.
            var res = authorName?.Length ?? 3;
        }
    }
}