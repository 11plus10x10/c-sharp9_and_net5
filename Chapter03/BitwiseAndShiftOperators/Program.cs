using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0000 1010.
            var a = 10;
            // 0000 0110.
            var b = 6;
            
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            
            // 2-bit column only.
            WriteLine($"a & b = {a & b}");
            
            // 8, 4 and 2-bit columns.
            WriteLine($"a | b = {a | b}");
            
            // 8 and 4-bit columns.
            WriteLine($"a ^ b = {a ^ b}");
            
            // 0101 0000 left-shift "a" by three bit columns.
            WriteLine($"a << 3 = {a << 3}");
            
            // Multiply "a" by 8.
            WriteLine($"a * 8 = {a * 8}");
            
            // 0000 0011 right-shift "b" by one bit column
            WriteLine($"b >> 1 = {b >> 1}");
        }
    }
}