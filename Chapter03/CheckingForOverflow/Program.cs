using System;
using static System.Console;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    var x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                } // end of checked
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but I caught the exception.");
            }
            WriteLine($"{2.1 / 0}");
        }
    }
}