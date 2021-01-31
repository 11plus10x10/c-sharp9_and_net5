using System;
using System.Collections.Generic;
using static System.Console;

namespace WorkingWithDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var keywords = new Dictionary<string, string>
            {
                {"int", "32-bit integer data type"},
                {"long", "64-bit integer data type"},
                {"float", "Single precision floating point number"}
            };
            
            WriteLine("Keywords and their definitions:");
            foreach (var item in keywords)
            {
                WriteLine($" {item.Key, 5}: {item.Value}");
            }
            WriteLine($"The definition of long is {keywords["long"]}");
        }
    }
}
