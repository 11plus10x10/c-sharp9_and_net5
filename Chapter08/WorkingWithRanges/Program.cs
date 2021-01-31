using System;
using static System.Console;

namespace WorkingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Samantha Jones";

            var lengthOfFirst = name.IndexOf(' ');
            var lengthOfLast = name.Length - lengthOfFirst - 1;

            var firstName = name.Substring(0, lengthOfFirst);
            var lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);
            
            WriteLine($"First name: {firstName}, Last name: {lastName}");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();

            var firstNameSpan = nameAsSpan[0..lengthOfFirst];
            var lastNameSpan = nameAsSpan[^lengthOfLast..^0];
            
            WriteLine($"First name: {firstNameSpan.ToString()}, Last name: {lastNameSpan.ToString()}");
        }
    }
}