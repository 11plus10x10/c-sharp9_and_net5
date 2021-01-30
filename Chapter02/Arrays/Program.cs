using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Can reference any array of string.
            var names = new string[4];
            
            // Storing items at index positions.
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            
            // Or like this.
            var names2 = new string[]
            {
                "Bob",
                "Michael",
                "Tony",
                "Mary"
            };
        }
    }
}